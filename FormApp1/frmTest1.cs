using System.Data;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace FormApp1
{
    public partial class frmTest1 : Form
    {
        public frmTest1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Doughnut chart

            Series doughnutSeries = new Series("Doughnut");
            doughnutSeries.ChartType = SeriesChartType.Doughnut;

            // Dummy data
            doughnutSeries.Points.Add(new DataPoint(0, new double[] { 370 }) { LegendText = "GKE" });
            doughnutSeries.Points.Add(new DataPoint(1, new double[] { 260 }) { LegendText = "BigQuery API" });
            doughnutSeries.Points.Add(new DataPoint(2, new double[] { 180 }) { LegendText = "BigQuery Streaming API" });
            doughnutSeries.Points.Add(new DataPoint(3, new double[] { 165 }) { LegendText = "App Engine" });
            doughnutSeries.Points.Add(new DataPoint(4, new double[] { 70 }) { LegendText = "Iam-admin Service Accounts" });
            doughnutSeries.Points.Add(new DataPoint(5, new double[] { 30 }) { LegendText = "GWS" });

            doughnutSeries.Points[0].Font = new Font("Consolas", 14);
            doughnutSeries.Points[0].Label = "BigQuery " + doughnutSeries.Points[0].YValues[0].ToString();
            doughnutSeries.Points[0].LabelForeColor = Color.White;

            chart1.Series.Add(doughnutSeries);

            ///////////////////////////////////////////////////

            // StackedColumn chart
            // Series 생성
            var series1 = new Series("Series 1") { LegendText = "BQ" };
            series1.ChartType = SeriesChartType.StackedColumn;
            series1.Points.AddXY("202301", 10);
            series1.Points.AddXY("202302", 20);
            series1.Points.AddXY("202303", 30);

            var series2 = new Series("Series 2") { LegendText = "GCS" };
            series2.ChartType = SeriesChartType.StackedColumn;
            series2.Points.AddXY("202301", 7);
            series2.Points.AddXY("202302", 9);
            series2.Points.AddXY("202303", 4);

            var series3 = new Series("Series 3") { LegendText = "GCE" };
            series3.ChartType = SeriesChartType.StackedColumn;
            series3.Points.AddXY("202301", 14);
            series3.Points.AddXY("202302", 12);
            series3.Points.AddXY("202303", 7);

            // 데이터 추가
            //series1.Points.Add(10);
            //series1.Points.Add(20);
            //series1.Points.Add(30);

            //series2.Points.Add(20);
            //series2.Points.Add(30);
            //series2.Points.Add(40);

            //series3.Points.Add(30);
            //series3.Points.Add(40);
            //series3.Points.Add(50);

            // Series를 Chart에 추가
            chart2.Series.Add(series1);
            chart2.Series.Add(series2);
            chart2.Series.Add(series3);

            ///////////////////////////////////////////////////

            // Column chart

            // Chart Area 설정
            //ChartArea chartArea = new ChartArea();
            //chartArea.AxisX.Title = "Month";
            //chartArea.AxisY.Title = "Value";
            //chart2.ChartAreas.Add(chartArea);

            //// Series 설정
            //Series series = new Series();
            //series.ChartType = SeriesChartType.Column;
            //series.Name = "MySeries";

            //// 데이터 설정
            //series.Points.AddXY("202301", 1, 2, 3, 4, 5, 6);
            //series.Points.AddXY("202302", 2, 4, 6, 8, 10, 12);
            //series.Points.AddXY("202303", 3, 6, 9, 12, 15, 18);

            //chart2.Series.Add(series);
        }

        private async void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            BigQueryHttpClient client = new BigQueryHttpClient(
                projectId: "cloudmate-sdteam"
                , datasetId: "ds01"
                , location: "asia-northeast3");

            int loopCount = (string.IsNullOrEmpty(txtLoopCount.Text) == false
                && Convert.ToInt32(txtLoopCount.Text?.ToString()) > 0) ? Convert.ToInt32(txtLoopCount.Text?.ToString()) : 1;

            string response;

            foreach (var i in Enumerable.Range(1, loopCount))
            {
                response = await client.HttpRequestQueryAsync();

                if (i % 6 == 0)
                    Application.DoEvents();

                txtResponse.Text += "-------------------------\r\n" + response;
            }

            DataTable dt = null;

            //dataGridView1.DataSource = dt;
            //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            //dataGridView1.Columns["Amount"].DefaultCellStyle.Format = "N2";
            //dataGridView1.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btn조회_Click(object sender, EventArgs e)
        {
            BigQueryHttpClient client = new BigQueryHttpClient(
                projectId: "cloudmate-sdteam"
                , datasetId: "ds01"
                , location: "asia-northeast3");

            client.BigQueryV2SDK_ExecuteQuery();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                BigQueryHttpClient client = new BigQueryHttpClient(
                projectId: "cloudmate-sdteam"
                , datasetId: "ds01"
                , location: "asia-northeast3");

                client.BigQueryV2SDK_InsertData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }
    }
}