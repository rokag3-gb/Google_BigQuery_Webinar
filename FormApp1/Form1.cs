using System.Diagnostics;

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

            //BigQuery_CRUD Bq = new();
            //Bq.TableInsertRows(projectId: projectId, datasetId: datasetId, tableId: tableId);

            //Google.Apis.Services.BaseClientService.Initializer init = new();

            //BigqueryService bqservice = new BigqueryService(
            //bqservice.ini
        }

        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            BigQueryHttpClient client = new BigQueryHttpClient(
                projectId: "cloudmate-sdteam"
                , datasetId: "ds01"
                , location: "asia-northeast3");

            client.HttpRequestQuery();
        }

        private void btn¡∂»∏_Click(object sender, EventArgs e)
        {
            BigQueryHttpClient client = new BigQueryHttpClient(
                projectId: "cloudmate-sdteam"
                , datasetId: "ds01"
                , location: "asia-northeast3");

            client.BigQueryV2SDK_ExecuteQuery();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            BigQueryHttpClient client = new BigQueryHttpClient(
                projectId: "cloudmate-sdteam"
                , datasetId: "ds01"
                , location: "asia-northeast3");

            client.BigQueryV2SDK_InsertData();
        }
    }
}