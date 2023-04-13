using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Diagnostics;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using Google.Cloud.BigQuery.V2;

namespace FormApp1
{
    public class BigQueryHttpClient
    {
        string _projectId = string.Empty; //string _projectName = "SD Team";
        string _datasetId = string.Empty;
        string _location = string.Empty;
        string _tableId = "Deal";

        Dictionary<string, string> TypeMapper; // key: BigQuery 데이터타입, value: C# 데이터타입

        string[] UserIds = new string[5];
        ItemData[] Items = new ItemData[7];

        private record ItemData
        {
            public string? ItemName { get; set; } = string.Empty;
            public float? Amount { get; set; } = 0;
        }

        public BigQueryHttpClient(string projectId = "cloudmate-sdteam", string datasetId = "ds01", string location = "asia-northeast3")
        {
            this._projectId = projectId;
            this._datasetId = datasetId;
            this._location = location;

            // key: BigQuery 데이터타입, value: C# 데이터타입
            TypeMapper = new Dictionary<string, string>();
            TypeMapper.Add("STRING", "String");
            TypeMapper.Add("BYTES", "Byte[]");
            TypeMapper.Add("INTEGER", "Int64");
            TypeMapper.Add("FLOAT", "Double");
            TypeMapper.Add("NUMERIC", "Decimal");
            TypeMapper.Add("BOOLEAN", "Boolean");
            TypeMapper.Add("TIMESTAMP", "DateTime");
            TypeMapper.Add("DATE", "DateTime");
            TypeMapper.Add("TIME", "TimeSpan");
            TypeMapper.Add("DATETIME", "DateTimeOffset");
            TypeMapper.Add("STRUCT", "DateRow");
            TypeMapper.Add("ARRAY", "object[]");
            TypeMapper.Add("GEOGRAPHY", "string");

            // UserId 5개
            UserIds = new string[] {
                                "b23f0372-51f4-452a-a3f2-115ea2f13227"
                                , "13a56e0f-7a31-4efa-a23b-852a7d95baaa"
                                , "09b548d9-bb63-47be-8a40-885437d87846"
                                , "126eb433-6087-424e-aae9-9109fbc7f28f"
                                , "31911e82-fbd2-421c-9ad4-a673c8e48c2d"
            };

            // Item 7개
            Items[0] = new ItemData { ItemName = "Google BigQuery API", Amount = 10650 };
            Items[1] = new ItemData { ItemName = "Google BigQuery Streaming API", Amount = 9850 };
            Items[2] = new ItemData { ItemName = "Google Iam-admin Service Accounts", Amount = 960 };
            Items[3] = new ItemData { ItemName = "Google Kubernetes Engine", Amount = 31470 };
            Items[4] = new ItemData { ItemName = "Google Workspace", Amount = 821 };
            Items[5] = new ItemData { ItemName = "Google App Engine", Amount = 9510 };
            Items[6] = new ItemData { ItemName = "Google Cloud Storage", Amount = 420 };
        }

        public async Task HttpRequestQuery()
        {
            Debug.WriteLine("------ 작업 시작 ------\r\n");

            string url = $"https://www.googleapis.com/bigquery/v2/projects/{_projectId}/queries?location={_location}";
            //url = $"http://20.196.221.189/bigquery/v2/projects/{_projectId}/queries?location={_location}";

            #region (주석 처리) service_account_key.json
            //string jsonPath = @"path/to/service_account_key.json";
            //string json = File.ReadAllText(jsonPath);
            //var credential = GoogleCredential.FromJson(json).CreateScoped("https://www.googleapis.com/auth/bigquery");
            //credential.GetAccessTokenForRequestAsync().Wait();
            #endregion

            var credential = Secret.credential_SDTeam.CreateScoped("https://www.googleapis.com/auth/bigquery");
            var token = await credential.UnderlyingCredential.GetAccessTokenForRequestAsync();
            
            Debug.WriteLine($"token = {token}\r\n");

            var httpReqMsg = new HttpRequestMessage(HttpMethod.Post, url);
            httpReqMsg.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            //httpReqMsg.Headers.Add("Host", "test.gscdn.com");

            //httpRequestMessage.Content = new StringContent("{ \"query\": \"select * from `cloudmate-sdteam.ds01.tb1`;\" }", Encoding.UTF8, "application/json");

            var query = new
            {
                query = $"select DealId"
                        + $", TranDate"
                        + $", DealKind"
                        + $", AccountId"
                        + $", ManagerId"
                        + $", Item"
                        + $", IsCancel"
                        + $", Amount"
                        + $", Tax"
                        + $", Total"
                        + $", Paid"
                        + $", Balance"
                        //+ $", ContId"
                        + $", IsInvoice"
                        + $", InvoiceMonth"
                        + $", Note"
                        + $", BillInfo"
                        //+ $", CreateDate"
                        //+ $", CreateId"
                        //+ $", ModifyDate"
                        //+ $", ModifyId"
                        + $" from `cloudmate-sdteam.{this._datasetId}.{this._tableId}`"
                        + $" where TranDate between Date(\"2023-01-01\") and date(\"{DateTime.Now.ToString("yyyy-MM-dd")}\")"
                        + $" limit 10;"
                , useLegacySql = false
            };
            var json = JsonConvert.SerializeObject(query);
            httpReqMsg.Content = new StringContent(json, Encoding.UTF8, "application/json");

            //var query = "select * from `cloudmate-sdteam.ds01.tb1`";
            //var queryBody = new Dictionary<string, string>
            //{
            //    { "query", query }
            //};
            //httpRequestMessage.Content = new StringContent(queryBody.ToString(), Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();

            // Send!!
            var response = await httpClient.SendAsync(httpReqMsg);
            var responseContent = await response.Content.ReadAsStringAsync();

            Debug.WriteLine("------ 결과 데이터 ------\r\n");
            Debug.WriteLine(responseContent);

            DataTable dt = ParseToDataTable(responseContent);

            Debug.WriteLine("------ 작업 완료 ------\r\n");
        }

        DataTable ParseToDataTable(string data)
        {
            var dt = new DataTable();

            try
            {
                var jobject = JObject.Parse(data);
                var rows = jobject["rows"];
                var fields = jobject["schema"]["fields"];

                // Add columns
                if (fields != null)
                {
                    foreach (var field in fields)
                    {
                        string value;
                        _ = TypeMapper.TryGetValue(key: field["type"].ToString(), value: out value);

                        dt.Columns.Add(field["name"].ToString(), Type.GetType($"System.{value}"));
                    }
                }

                // Add rows
                if (rows != null)
                {
                    foreach (var row in rows)
                    {
                        var dataRow = dt.NewRow();
                        var rowValues = row["f"];

                        for (int i = 0; i < rowValues.Count(); i++)
                        {
                            //Debug.WriteLine($"{dt.Columns[i].ColumnName} = {rowValues[i]["v"]?.ToString()}");

                            dataRow[i] = rowValues[i]["v"]?.ToString();
                        }

                        dt.Rows.Add(dataRow);
                    }
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public async Task BigQueryV2SDK_ExecuteQuery()
        {
            Debug.WriteLine("------ 작업 시작 ------\r\n");

            string query = @"
                select	col1
	                , colString
	                , CURRENT_TIMESTAMP() as TIMESTAMP
	                , DATETIME(CURRENT_TIMESTAMP(), 'Asia/Seoul') as datetime_KST
	                , DATETIME(CURRENT_TIMESTAMP(), 'America/Los_Angeles') AS datetime_LA
	                , DATE(2023, 4, 4) AS date_ymd
	                , DATETIME(DATETIME '2023-04-04 23:59:59') AS date_dt
	                , generate_uuid() as UUID
	                , 'asd' as VAL1
                from	`ds01.tb1`;
                ";

            BigQueryClient client = BigQueryClient.Create(_projectId, Secret.credential_SDTeam);

            var result = client.ExecuteQuery(query, parameters: null);

            client.Dispose();

            foreach (var row in result)
            {
                Debug.WriteLine($"{row["col1"]}" +
                    $", {row["colString"]}" +
                    $", {row["datetime_KST"]}" +
                    $", {row["datetime_LA"]}" +
                    $", {row["date_ymd"]}" +
                    $", {row["date_dt"]}" +
                    $", {row["UUID"]}" +
                    $", {row["VAL1"]}");
            }

            Debug.WriteLine("------ 작업 완료 ------\r\n");
        }

        public async Task BigQueryV2SDK_InsertData()
        {
            try
            {
                BigQueryClient client = BigQueryClient.Create(_projectId, Secret.credential_SDTeam);

                List<BigQueryInsertRow> insert_rows = new();

                foreach (var i in Enumerable.Range(1, 100000000))
                {
                    var item = Items[Random.Shared.Next(0, 6)];
                    var TranDate = DateTime.Now.AddDays(Random.Shared.Next(1, 100) * -1);

                    BigQueryInsertRow row = new BigQueryInsertRow(insertId: $"row{i}");
                    row.Add("TranDate", TranDate.ToString("yyyy-MM-dd"));
                    row.Add("DealKind", (Random.Shared.Next(0, 2) == 2) ? "매입" : "매출");
                    row.Add("AccountId", Random.Shared.Next(102, 146));
                    row.Add("ManagerId", UserIds[Random.Shared.Next(0, 4)]);
                    row.Add("Item", item.ItemName);
                    row.Add("IsCancel", (Random.Shared.Next(0, 5) == 3) ? true : false);
                    row.Add("Amount", item.Amount);
                    row.Add("Tax", item.Amount * 0.1);
                    row.Add("Total", item.Amount * 1.1);
                    row.Add("Paid", 0);
                    row.Add("Balance", item.Amount * 1.1);
                    row.Add("ContId", null);
                    row.Add("IsInvoice", (Random.Shared.Next(0, 5) >= 1) ? true : false);
                    row.Add("InvoiceMonth", TranDate.ToString("yyyyMM"));
                    //row.Add("Note", null);
                    //row.Add("BillInfo", null);
                    row.Add("CreateId", UserIds[Random.Shared.Next(0, 4)]);

                    insert_rows.Add(row);

                    if (i % 100 == 0)
                    {
                        client.InsertRows(this._datasetId, this._tableId, insert_rows);

                        insert_rows.Clear();
                    }
                }

                if (insert_rows.Count > 0)
                {
                    client.InsertRows(this._datasetId, this._tableId, insert_rows);
                }

                if (client != null)
                    client.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
    }
}