using Google.Cloud.BigQuery.V2;
using System.Reflection;

namespace FormApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //System.Reflection.Assembly[] asm = AppDomain.CurrentDomain.GetAssemblies();
            //string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"GitIgnore\cloudmate-sdteam-1060cb223333.json");
            //string[] files = File.ReadAllLines(path);
            //var f = Secret.files;

            BigQueryTableInsertRows BQ = new BigQueryTableInsertRows();
            BQ.TableInsertRows();
        }
    }

    public class BigQueryTableInsertRows
    {
        public void TableInsertRows(
            string projectId = "cloudmate-sdteam",
            string datasetId = "ds01",
            string tableId = "tb1")
        {
            var credentials = Secret.cred_Bq_SDTeam;
            BigQueryClient client = BigQueryClient.Create(projectId, credentials);

            var result = client.ExecuteQuery("select "
                + "DATETIME(CURRENT_TIMESTAMP(), 'Asia/Seoul') as datetime_KST"
                + ", DATETIME(CURRENT_TIMESTAMP(), 'America/Los_Angeles') AS datetime_LA"
                + ", generate_uuid() as UUID"
                + ", 'asd' as VAL1;"
                , parameters: null);

            BigQueryInsertRow[] rows = new BigQueryInsertRow[] {
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

            client.InsertRows(datasetId, tableId, rows);

            client.Dispose();
        }
    }
}