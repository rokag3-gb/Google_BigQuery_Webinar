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
            Series doughnutSeries = new Series("Doughnut");
            doughnutSeries.ChartType = SeriesChartType.Doughnut;

            doughnutSeries.Points.Add(new DataPoint(0, new double[] { 20, 90 }) { LegendText = "BigQuery" });
            doughnutSeries.Points.Add(new DataPoint(1, new double[] { 30, 370 }) { LegendText = "GCS" });
            doughnutSeries.Points.Add(new DataPoint(2, new double[] { 40, 180 }) { LegendText = "GCE" });

            doughnutSeries.Points[0].Font = new Font("Consolas", 14);
            doughnutSeries.Points[0].Label = "BigQuery " + doughnutSeries.Points[0].YValues[1].ToString();
            doughnutSeries.Points[0].LabelForeColor = Color.White;

            chart1.Series.Add(doughnutSeries);

            ///////////////////////////////////////////////////

            // Series ����
            var series1 = new Series("Series 1") { LegendText = "BQ" }; series1.ChartType = SeriesChartType.StackedColumn;
            var series2 = new Series("Series 2") { LegendText = "GCS" }; series2.ChartType = SeriesChartType.StackedColumn;
            var series3 = new Series("Series 3") { LegendText = "GCE" }; series3.ChartType = SeriesChartType.StackedColumn;

            // ������ �߰�
            series1.Points.Add(10);
            series1.Points.Add(20);
            series1.Points.Add(30);

            series2.Points.Add(20);
            series2.Points.Add(30);
            series2.Points.Add(40);

            series3.Points.Add(30);
            series3.Points.Add(40);
            series3.Points.Add(50);

            // Series�� Chart�� �߰�
            chart2.Series.Add(series1);
            chart2.Series.Add(series2);
            chart2.Series.Add(series3);

            // Chart ��Ʈ�ѿ� ������ �߰�
            //Legend legend = new Legend();
            //chart1.Legends.Add(legend);

            // �� �����忡 �� �߰�
            //for (int i = 0; i < doughnutSeries.Points.Count; i++)
            //{
            //    string labelText = doughnutSeries.Points[i].LegendText;

            //    LegendItem legendItem = new LegendItem(labelText, Color.Transparent, Application.StartupPath + "\\dh.png");

            //    legendItem.Cells.Add(new LegendCell(LegendCellType.SeriesSymbol, "", ContentAlignment.MiddleCenter));
            //    legendItem.Cells.Add(new LegendCell(LegendCellType.Text, labelText, ContentAlignment.MiddleLeft));
            //    legend.CustomItems.Add(legendItem);
            //}

            //chart1.Series.Clear();
            //chart1.Series["SeriesDoughnut"].Points.Add(10);
            //chart1.Series["SeriesDoughnut"].Points.Add(20);
            //chart1.Series["SeriesDoughnut"].Points.Add(30);
            //chart1.Series["SeriesDoughnut"].Points.Add(40);
            //chart1.Series["SeriesDoughnut"].Points.Add(50);
            //chart1.Series["SeriesDoughnut"].Points.Add(25);
            //chart1.Show();
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

        private void btn��ȸ_Click(object sender, EventArgs e)
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