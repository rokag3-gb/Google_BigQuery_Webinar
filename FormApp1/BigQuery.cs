using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Diagnostics;
using System.Text;
//using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using Google.Apis.Auth.OAuth2;

namespace FormApp1
{
    public class BigQueryClient3
    {
        string projectId = "cloudmate-sdteam";
        //string projectName = "SD Team";
        string datasetId = "ds01";
        string tableId = "Deal";
        string location = "asia-northeast3";

        Dictionary<string, string> TypeMapper; // key: BigQuery 데이터타입, value: C# 데이터타입
        
        public BigQueryClient3()
        {
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
        }

        public async Task ExecuteQuery()
        {
            string url = $"https://www.googleapis.com/bigquery/v2/projects/{projectId}/queries?location={location}";

            //string jsonPath = @"path/to/service_account_key.json";
            //string json = File.ReadAllText(jsonPath);
            //var credential = GoogleCredential.FromJson(json).CreateScoped("https://www.googleapis.com/auth/bigquery");
            //credential.GetAccessTokenForRequestAsync().Wait();
            
            var credential = Secret.credential_SDTeam.CreateScoped("https://www.googleapis.com/auth/bigquery");
            var token = await credential.UnderlyingCredential.GetAccessTokenForRequestAsync();
            
            var httpReqMsg = new HttpRequestMessage(HttpMethod.Post, url);
            httpReqMsg.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

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
                        + $", ContId"
                        + $", IsInvoice"
                        + $", InvoiceMonth"
                        + $", Note"
                        + $", BillInfo"
                        + $", CreateDate"
                        + $", CreateId"
                        + $", ModifyDate"
                        + $", ModifyId"
                        + $" from `cloudmate-sdteam.{datasetId}.{tableId}`"
                        + $" where TranDate between Date(\"2023-01-01\") and date(\"{DateTime.Now.ToString("yyyy-MM-dd")}\");"
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
            //var response = httpClient.SendAsync(httpRequestMessage).Result;
            //var responseContent = response.Content.ReadAsStringAsync().Result;

            var response = await httpClient.SendAsync(httpReqMsg);
            var responseContent = await response.Content.ReadAsStringAsync();

            Debug.WriteLine(responseContent);

            DataTable dt = ParseToDataTable(responseContent);

            Debug.WriteLine("------ 작업 완료 ------");
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
                        TypeMapper.TryGetValue(field["type"].ToString(), out value);

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
                            dataRow[i] = rowValues[i]["v"].ToString();
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
    }

    /// <summary>
    /// 작동 안함
    /// </summary>
    public class BigQuery_Client
    {
        string projectId = "cloudmate-sdteam";
        string projectName = "SD Team";
        string datasetId = "ds01";
        string datasetName = "ds01";
        string tableId = "Deal";
        string tableName = "Deal";

        public BigQuery_Client() { }

        public async Task ExecuteQuery()
        {
            // Google OAuth2.0 인증 정보 가져오기
            var authUrl = "https://accounts.google.com/o/oauth2/token";
            var authBody = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("grant_type", "refresh_token"),
                new KeyValuePair<string, string>("client_id", "388375681381-0idvqr38p61mb54lfnb8e1eevds1jh32.apps.googleusercontent.com"),
                new KeyValuePair<string, string>("client_secret", "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"),
                //new KeyValuePair<string, string>("refresh_token", "{your_refresh_token}")
            };
            var authResponse = await SendRequest(authUrl, HttpMethod.Post, null, authBody);

            // BigQuery 쿼리 실행
            var queryUrl = $"https://bigquery.googleapis.com/bigquery/v2/projects/{projectId}/queries";
            var query = "SELECT * FROM ds01.tb1";
            var queryBody = new Dictionary<string, string>
            {
                { "query", query }
            };
            var queryResponse = await SendRequest(queryUrl, HttpMethod.Post, authResponse["access_token"], queryBody);

            // 결과 출력
            foreach (var row in queryResponse["rows"])
            {
                Debug.WriteLine(string.Join(", ", row["f"]));
            }
        }

        private async Task<Dictionary<string, dynamic>> SendRequest(string url, HttpMethod method, string accessToken, object body)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(method, url);

                if (accessToken != null)
                {
                    request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                }

                if (body != null)
                {
                    var content = new StringContent(body.ToString(), Encoding.UTF8, "application/json");
                    request.Content = content;
                    //request.Content = new FormUrlEncodedContent(GetKeyValuePairs(body));
                }

                var response = await client.SendAsync(request);
                var responseContent = await response.Content.ReadAsStringAsync();

                var json = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(responseContent);
                return json;
            }
        }

        private IEnumerable<KeyValuePair<string, string>> GetKeyValuePairs(object obj)
        {
            var properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                var key = property.Name;
                var value = property.GetValue(obj)?.ToString();

                if (value != null)
                {
                    yield return new KeyValuePair<string, string>(key, value);
                }
            }
        }
    }
    
    /// <summary>
    /// 작동 안함
    /// </summary>
    public class clsBigQuery
    {
        string projectId = "cloudmate-sdteam";
        string projectName = "SD Team";
        string datasetId = "ds01";
        string datasetName = "ds01";
        string tableId = "Deal";
        string tableName = "Deal";

        public async Task Execute()
        {
            // BigQuery API 키 가져오기
            var apiKey = "AIzaSyAs4_RgR84GZsSey4c2_7np4DamkjbJ50g";

            // BigQuery 쿼리 실행
            var queryUrl = $"https://bigquery.googleapis.com/bigquery/v2/projects/{projectId}/queries?key={apiKey}";
            var query = "SELECT * FROM ds01.tb1";
            var queryBody = new Dictionary<string, string>
            {
                { "query", query }
            };
            var queryResponse = await SendRequest(queryUrl, HttpMethod.Post, null, queryBody);
            
            // 결과 출력
            //foreach (var row in queryResponse["rows"])
            //{
            //    Debug.WriteLine(string.Join(", ", row["f"]));
            //}
            Debug.WriteLine(queryResponse.ToString());
        }

        public async Task<Dictionary<string, dynamic>> SendRequest(string url, HttpMethod method, string accessToken, object body)
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(method, url);

                if (accessToken != null)
                {
                    request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                }

                if (body != null)
                {
                    var content = new StringContent("SELECT * FROM ds01.tb1", Encoding.UTF8, "application/json");
                    request.Content = content;
                    //request.Content = new FormUrlEncodedContent(GetKeyValuePairs(body));
                }

                var response = await client.SendAsync(request);
                var responseContent = await response.Content.ReadAsStringAsync();

                var json = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(responseContent);
                return json;
            }
        }

        public IEnumerable<KeyValuePair<string, string>> GetKeyValuePairs(object obj)
        {
            var properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                var key = property.Name;
                var value = property.GetValue(obj)?.ToString();

                if (value != null)
                {
                    yield return new KeyValuePair<string, string>(key, value);
                }
            }
        }
    }
}