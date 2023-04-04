using Google.Apis.Bigquery.v2.Data;
using Google.Apis.Bigquery.v2;
using Google.Cloud.BigQuery.V2;
using System.Data.SqlTypes;
using System.Diagnostics;

namespace FormApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string projectId = "cloudmate-sdteam";
        string projectName = "SD Team";
        string datasetId = "ds01";
        string datasetName = "ds01";
        string tableId = "tb1";
        string tableName = "tb1";

        private void Form1_Load(object sender, EventArgs e)
        {
            //System.Reflection.Assembly[] asm = AppDomain.CurrentDomain.GetAssemblies();
            //string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"GitIgnore\cloudmate-sdteam-1060cb223333.json");
            //string[] files = File.ReadAllLines(path);
            //var f = Secret.files;

            //BigQuery_CRUD Bq = new();
            //Bq.TableInsertRows(projectId: projectId, datasetId: datasetId, tableId: tableId);

            //Google.Apis.Services.BaseClientService.Initializer init = new();

            //BigqueryService bqservice = new BigqueryService(
            //bqservice.ini
        }

        private void btn¡∂»∏_Click(object sender, EventArgs e)
        {
            string query = @"select
                        col1
                        , colString
                        , DATETIME(CURRENT_TIMESTAMP(), 'Asia/Seoul') as datetime_KST
                        , DATETIME(CURRENT_TIMESTAMP(), 'America/Los_Angeles') AS datetime_LA
                        , generate_uuid() as UUID
                        , 'asd' as VAL1
                    from `ds01.tb1`;";

            BigQueryClient client = BigQueryClient.Create(projectId, Secret.credential_SDTeam);

            var result = client.ExecuteQuery(query, parameters: null);

            client.Dispose();

            foreach (var row in result)
            {
                Debug.WriteLine($"{row["col1"]}: {row["colString"]}, {row["datetime_KST"]}, {row["datetime_LA"]}, {row["UUID"]}, {row["VAL1"]} views");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            BigQueryClient client = BigQueryClient.Create(projectId, Secret.credential_SDTeam);

            BigQueryInsertRow[] insert_rows = new BigQueryInsertRow[] {
                // The insert ID is optional, but can avoid duplicate data
                // when retrying inserts.
                new BigQueryInsertRow(insertId: "row1") {
                    { "col1", 100 },
                    { "colString", "WA" }
                },
                new BigQueryInsertRow(insertId: "row2") {
                    { "col1", 101 },
                    { "colString", "Colorado" }
                }
            };

            client.InsertRows(datasetId, tableId, insert_rows);

            client.Dispose();
        }
    }

    public class BigQuery_CRUD
    {
        public void TableInsertRows(string projectId, string datasetId, string tableId)
        {
            BigQueryClient client = BigQueryClient.Create(projectId, Secret.credential_SDTeam);

            BigQueryInsertRow[] insert_rows = new BigQueryInsertRow[] {
                // The insert ID is optional, but can avoid duplicate data
                // when retrying inserts.
                new BigQueryInsertRow(insertId: "row1") {
                    { "col1", 100 },
                    { "colString", "WA" }
                },
                new BigQueryInsertRow(insertId: "row2") {
                    { "col1", 101 },
                    { "colString", "Colorado" }
                }
            };

            client.InsertRows(datasetId, tableId, insert_rows);

            client.Dispose();
        }


        public void ExecuteSQL(BigqueryService bqservice, String ProjectID)
        {
            string sSql = "SELECT r.Dealname, r.poolnumber, r.loanid FROM [MBS_Dataset.tblRemitData] R left join each [MBS_Dataset.tblOrigData] o on R.Dealname = o.Dealname and R.Poolnumber = o.Poolnumber and R.LoanID = o.LoanID Order by o.Dealname, o.poolnumber, o.loanid limit 100000";

            QueryRequest _r = new QueryRequest();
            _r.Query = sSql;
            QueryResponse _qr = bqservice.Jobs.Query(_r, ProjectID).Execute();

            string pageToken = null;

            if (_qr.JobComplete == false)
            {
                //job not finished yet! expecting more data
                while (true)
                {
                    var resultReq = bqservice.Jobs.GetQueryResults(_qr.JobReference.ProjectId, _qr.JobReference.JobId);
                    resultReq.PageToken = pageToken;
                    var result = resultReq.Execute();

                    if (result.JobComplete == true)
                    {
                        //WriteRows(result.Rows, result.Schema.Fields);
                        pageToken = result.PageToken;
                        if (pageToken == null)
                            break;
                    }
                }
            }
            else
            {
                List<string> _fieldNames = _qr.Schema.Fields.ToList().Select(x => x.Name).ToList();
                //WriteRows(_qr.Rows, _qr.Schema.Fields);
            }
        }
    }
}