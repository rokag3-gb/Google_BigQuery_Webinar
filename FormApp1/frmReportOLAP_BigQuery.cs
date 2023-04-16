using Google.Apis.Bigquery.v2.Data;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormApp1
{
    public partial class frmReportOLAP_BigQuery : Form
    {
        public frmReportOLAP_BigQuery()
        {
            InitializeComponent();
        }

        private void frmReportOLAP_BigQuery_Load(object sender, EventArgs e)
        {
            cboYear.Text = "2023";
            cboQuarter.Text = "1Q";

            cboHost.Items.Clear();
            cboHost.Items.Add(new ComboBoxItem("Google BigQuery", "https://www.googleapis.com"));
            cboHost.Items.Add(new ComboBoxItem("CacheCat on Google Compute Engine", "http://34.64.87.33"));
            cboHost.Items.Add(new ComboBoxItem("Azure VM", "http://20.196.221.189"));
            cboHost.SelectedIndex = 0;

            DataInit();
        }

        void DataInit()
        {
            txtTotalSales.Text = "0";
            txtTotalNumberOfSales.Text = "0";
            txtTopSellingProduct.Text = "";

            chartDoughtnut.Series.Clear();
            chartStackedColumn.Series.Clear();
            chartSpline.Series.Clear();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            DataInit();

            BigQueryHttpClient client;

            string host = ((ComboBoxItem)cboHost.SelectedItem).Value.ToString();
            string query;
            string response;

            int n = 0;

            try
            {
                btnSearch.Text = "Loading..";
                btnSearch.Enabled = false;

                #region HttpRequestQuery로 데이터 가져오기

                client = new BigQueryHttpClient(projectId: "cloudmate-sdteam", datasetId: "ds01", location: "asia-northeast3");

                /////////////////////////////////////////////////////////////////////////////////////////////////////
                // Query[0] 상단 Total Namecard에 표현할 데이터 가져오기
                query = "select\t(\r\n\tselect\tsum(Amount)\r\n\tfrom\tds01.Deal\r\n\twhere\tTranDate between '2023-01-01' and '2023-03-31'\r\n\tand\tDealKind = '매출'\r\n\tand\tIsCancel = false\r\n\t) as TotalSales\r\n\t, (\r\n\tselect\tcount(DealId)\r\n\tfrom\tds01.Deal\r\n\twhere\tTranDate between '2023-01-01' and '2023-03-31'\r\n\tand\tDealKind = '매출'\r\n\tand\tIsCancel = false\r\n\t) as TotalNumberOfSales\r\n\t, (\r\n\tselect\ttop.Item\r\n\tfrom\t(\r\n\t\tselect\tItem\r\n\t\t\t, sum(Amount)\r\n\t\tfrom\tds01.Deal\r\n\t\twhere\tTranDate between '2023-01-01' and '2023-03-31'\r\n\t\tand\tDealKind = '매출'\r\n\t\tand\tIsCancel = false\r\n\t\tgroup by Item\r\n\t\torder by 2 desc\r\n\t\tlimit 1\r\n\t\t) top\r\n\t) as TopSellingProduct\r\n\t, case when RAND() > 0 then 1 else 0 end as rnd;";

                response = await client.HttpRequestQueryAsync(host, query);
                var dt_total = client.ParseToDataTable(response);

                /////////////////////////////////////////////////////////////////////////////////////////////////////
                // Query[1] 좌측 Doughnut Chart에 표현할 데이터 가져오기
                query = "select\tItem\r\n\t, sum(Amount) as TotalAmount\r\n\t, sum(Amount)\r\n\t/\r\n\t(\r\n\tselect\tsum(Amount)\r\n\tfrom\tds01.Deal\r\n\twhere\tTranDate between '2023-01-01' and '2023-03-31'\r\n\tand\tDealKind = '매출'\r\n\tand\tIsCancel = false\r\n\t) as Percent\r\n\t, case when RAND() > 0 then 1 else 0 end as rnd\r\nfrom\tds01.Deal\r\nwhere\tTranDate between '2023-01-01' and '2023-03-31'\r\nand\tDealKind = '매출'\r\nand\tIsCancel = false\r\ngroup by Item\r\norder by 2 desc;";

                response = await client.HttpRequestQueryAsync(host, query);

                var dt_2 = client.ParseToDataTable(response);

                /////////////////////////////////////////////////////////////////////////////////////////////////////
                // Query[2] 우측상단 StackedColumn Chart에 표현할 데이터 가져오기
                query = "select\ta.TranYearMonth\r\n\t, (\r\n\tselect\tsum(Amount)\r\n\tfrom\tds01.Deal\r\n\twhere\tcast((extract(year from TranDate) * 100 + extract(month from TranDate)) as string) = a.TranYearMonth\r\n\tand\tTranDate is not null\r\n\tand\tDealKind = '매출'\r\n\tand\tIsCancel = false\r\n\tand\tItem = 'Google Kubernetes Engine'\r\n\t) as Value1\r\n\t, (\r\n\tselect\tsum(Amount)\r\n\tfrom\tds01.Deal\r\n\twhere\tcast((extract(year from TranDate) * 100 + extract(month from TranDate)) as string) = a.TranYearMonth\r\n\tand\tTranDate is not null\r\n\tand\tDealKind = '매출'\r\n\tand\tIsCancel = false\r\n\tand\tItem = 'Google BigQuery API'\r\n\t) as Value2\r\n\t, (\r\n\tselect\tsum(Amount)\r\n\tfrom\tds01.Deal\r\n\twhere\tcast((extract(year from TranDate) * 100 + extract(month from TranDate)) as string) = a.TranYearMonth\r\n\tand\tTranDate is not null\r\n\tand\tDealKind = '매출'\r\n\tand\tIsCancel = false\r\n\tand\tItem = 'Google BigQuery Streaming API'\r\n\t) as Value3\r\n\t, (\r\n\tselect\tsum(Amount)\r\n\tfrom\tds01.Deal\r\n\twhere\tcast((extract(year from TranDate) * 100 + extract(month from TranDate)) as string) = a.TranYearMonth\r\n\tand\tTranDate is not null\r\n\tand\tDealKind = '매출'\r\n\tand\tIsCancel = false\r\n\tand\tItem = 'Google App Engine'\r\n\t) as Value4\r\n\t, (\r\n\tselect\tsum(Amount)\r\n\tfrom\tds01.Deal\r\n\twhere\tcast((extract(year from TranDate) * 100 + extract(month from TranDate)) as string) = a.TranYearMonth\r\n\tand\tTranDate is not null\r\n\tand\tDealKind = '매출'\r\n\tand\tIsCancel = false\r\n\tand\tItem = 'Google Iam-admin Service Accounts'\r\n\t) as Value5\r\n\t, (\r\n\tselect\tsum(Amount)\r\n\tfrom\tds01.Deal\r\n\twhere\tcast((extract(year from TranDate) * 100 + extract(month from TranDate)) as string) = a.TranYearMonth\r\n\tand\tTranDate is not null\r\n\tand\tDealKind = '매출'\r\n\tand\tIsCancel = false\r\n\tand\tItem = 'Google Workspace'\r\n\t) as Value6\r\n\t, case when RAND() > 0 then 1 else 0 end as rnd\r\nfrom\t(\r\n\tselect\tcast((extract(year from TranDate) * 100 + extract(month from TranDate)) as string) as TranYearMonth\r\n\tfrom\tds01.Deal\r\n\twhere\tTranDate between '2023-01-01' and '2023-03-31'\r\n\tand\tDealKind = '매출'\r\n\tand\tIsCancel = false\r\n\tgroup by cast((extract(year from TranDate) * 100 + extract(month from TranDate)) as string)\r\n\t) a\r\norder by 1;";

                response = await client.HttpRequestQueryAsync(host, query);

                var dt_StackedColumn = client.ParseToDataTable(response);

                /////////////////////////////////////////////////////////////////////////////////////////////////////
                // Query[3] 우측하단 Spline Chart에 표현할 데이터 가져오기
                query = "select\tTranDate\r\n\t, Item\r\n\t, sum(Amount) as Amount\r\n\t, case when RAND() > 0 then 1 else 0 end as rnd\r\nfrom\tds01.Deal\r\nwhere\tTranDate between '2023-01-01' and '2023-03-31'\r\nand\tDealKind = '매출'\r\nand\tIsCancel = false\r\n--and\tItem = 'Google Kubernetes Engine'\r\ngroup by\r\n\tTranDate\r\n\t, Item\r\norder by TranDate, Item;";

                response = await client.HttpRequestQueryAsync(host, query);

                var dt_Spline = client.ParseToDataTable(response);

                #endregion

                #region 가져온 데이터 표현

                /////////////////////////////////////////////////////////////////////////////////////////////////////
                // 상단 Total Namecard에 데이터 표현
                if (dt_total != null)
                {
                    foreach (var row in dt_total.Rows)
                    {
                        DataRow dr = (DataRow)row;

                        txtTotalSales.Text = string.Format("{0:#,##0}", decimal.Parse(dr["TotalSales"].ToString()));
                        txtTotalNumberOfSales.Text = string.Format("{0:#,##0}", decimal.Parse(dr["TotalNumberOfSales"].ToString()));
                        txtTopSellingProduct.Text = dr["TopSellingProduct"].ToString();
                    }
                }

                /////////////////////////////////////////////////////////////////////////////////////////////////////
                // 좌측 Doughnut Chart에 데이터 표현
                Series doughnutSeries = new Series("Doughnut");
                doughnutSeries.ChartType = SeriesChartType.Doughnut;
                doughnutSeries.BorderColor = Color.Transparent;
                doughnutSeries.BorderWidth = 1;
                doughnutSeries.LabelForeColor = Color.Black;

                doughnutSeries["DoughnutRadius"] = "50";
                doughnutSeries["PieStartAngle"] = "270"; // 12시 방향

                if (dt_2 != null)
                {
                    n = 0;

                    foreach (var row in dt_2.Rows)
                    {
                        DataRow dr = (DataRow)row;

                        doughnutSeries.Points.Add(new DataPoint(n, new double[] { Convert.ToDouble(dr["TotalAmount"]) }) { LegendText = dr["Item"].ToString() });

                        doughnutSeries.Points[n].Font = new Font("Consolas", 12);
                        doughnutSeries.Points[n].Label = Math.Round((Convert.ToDouble(dr["Percent"]) * 100), 2).ToString() + "%";
                        doughnutSeries.Points[n].LabelForeColor = Color.Black;
                        doughnutSeries.Points[n].LabelBackColor = Color.White;
                        doughnutSeries.Points[n].LabelBackColor = Color.FromArgb(96, 255, 255, 255);

                        n++;
                    }
                }

                chartDoughtnut.Series.Add(doughnutSeries);

                foreach (var legend in chartDoughtnut.Legends)
                    legend.Font = new Font("Consolas", 16);

                /////////////////////////////////////////////////////////////////////////////////////////////////////
                // 우측상단 StackedColumn Chart에 데이터 표현

                // Series 생성
                var series1 = new Series("Google Kubernetes Engine") { LegendText = "Google Kubernetes Engine", ChartType = SeriesChartType.StackedColumn };
                var series2 = new Series("Google BigQuery API") { LegendText = "Google BigQuery API", ChartType = SeriesChartType.StackedColumn };
                var series3 = new Series("Google BigQuery Streaming API") { LegendText = "Google BigQuery Streaming API", ChartType = SeriesChartType.StackedColumn };
                var series4 = new Series("Google App Engine") { LegendText = "Google App Engine", ChartType = SeriesChartType.StackedColumn };
                var series5 = new Series("Google Iam - admin Service Accounts") { LegendText = "Google Iam - admin Service Accounts", ChartType = SeriesChartType.StackedColumn };
                var series6 = new Series("Google Workspace") { LegendText = "Google Workspace", ChartType = SeriesChartType.StackedColumn };

                int _idx;

                if (dt_StackedColumn != null)
                {
                    foreach (var row in dt_StackedColumn.Rows)
                    {
                        DataRow dr = (DataRow)row;

                        _idx = series1.Points.AddXY(dr["TranYearMonth"].ToString(), Convert.ToDouble(dr["Value1"]));
                        //series1.Points[_idx].Font = new Font("Consolas", 9);
                        //series1.Points[_idx].Label = Convert.ToDouble(dr["Value1"]).ToString();
                        //series1.Points[_idx].LabelFormat = "#,##0";
                        //series1.Points[_idx].LabelForeColor = Color.Black;
                        //series1.Points[_idx].LabelBackColor = Color.White;

                        _idx = series2.Points.AddXY(dr["TranYearMonth"].ToString(), Convert.ToDouble(dr["Value2"]));
                        _idx = series3.Points.AddXY(dr["TranYearMonth"].ToString(), Convert.ToDouble(dr["Value3"]));
                        _idx = series4.Points.AddXY(dr["TranYearMonth"].ToString(), Convert.ToDouble(dr["Value4"]));
                        _idx = series5.Points.AddXY(dr["TranYearMonth"].ToString(), Convert.ToDouble(dr["Value5"]));
                        _idx = series6.Points.AddXY(dr["TranYearMonth"].ToString(), Convert.ToDouble(dr["Value6"]));
                    }
                }

                // Series를 Chart에 추가
                chartStackedColumn.Series.Add(series1);
                chartStackedColumn.Series.Add(series2);
                chartStackedColumn.Series.Add(series3);
                chartStackedColumn.Series.Add(series4);
                chartStackedColumn.Series.Add(series5);
                chartStackedColumn.Series.Add(series6);

                chartStackedColumn.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0";
                chartStackedColumn.Legends.Clear();

                //foreach (var legend in chartStackedColumn.Legends)
                //    legend.Font = new Font("Consolas", 12);

                /////////////////////////////////////////////////////////////////////////////////////////////////////
                // 우측하단 Spline Chart에 데이터 표현
                Series seriesSpl_1GKE = new Series("Google Kubernetes Engine")
                {
                    ChartType = SeriesChartType.Spline,
                    MarkerStyle = MarkerStyle.Circle,
                    BorderWidth = 3,
                };
                Series seriesSpl_2BQ = new Series("Google BigQuery API")
                {
                    ChartType = SeriesChartType.Spline,
                    MarkerStyle = MarkerStyle.Circle,
                    BorderWidth = 3,
                };
                Series seriesSpl_3BQS = new Series("Google BigQuery Streaming API")
                {
                    ChartType = SeriesChartType.Spline,
                    MarkerStyle = MarkerStyle.Circle,
                    BorderWidth = 3,
                };
                Series seriesSpl_4GAE = new Series("Google App Engine")
                {
                    ChartType = SeriesChartType.Spline,
                    MarkerStyle = MarkerStyle.Circle,
                    BorderWidth = 3,
                };
                Series seriesSpl_5IAM = new Series("Google Iam - admin Service Accounts")
                {
                    ChartType = SeriesChartType.Spline,
                    MarkerStyle = MarkerStyle.Circle,
                    BorderWidth = 3,
                };
                Series seriesSpl_6GWS = new Series("Google Workspace")
                {
                    ChartType = SeriesChartType.Spline,
                    MarkerStyle = MarkerStyle.Circle,
                    BorderWidth = 3,
                };

                // Series 데이터 설정
                if (dt_Spline != null)
                {
                    foreach (var row in dt_Spline.Rows)
                    {
                        DataRow dr = (DataRow)row;

                        if (dr["Item"].ToString() == "Google Kubernetes Engine")
                            _ = seriesSpl_1GKE.Points.AddXY(Convert.ToDateTime(dr["TranDate"]).ToString("MM-dd").Replace("-", "/"), Convert.ToDouble(dr["Amount"]));
                        else if (dr["Item"].ToString() == "Google BigQuery API")
                            _ = seriesSpl_2BQ.Points.AddXY(Convert.ToDateTime(dr["TranDate"]).ToString("MM-dd").Replace("-", "/"), Convert.ToDouble(dr["Amount"]));
                        else if (dr["Item"].ToString() == "Google BigQuery Streaming API")
                            _ = seriesSpl_3BQS.Points.AddXY(Convert.ToDateTime(dr["TranDate"]).ToString("MM-dd").Replace("-", "/"), Convert.ToDouble(dr["Amount"]));
                        else if (dr["Item"].ToString() == "Google App Engine")
                            _ = seriesSpl_4GAE.Points.AddXY(Convert.ToDateTime(dr["TranDate"]).ToString("MM-dd").Replace("-", "/"), Convert.ToDouble(dr["Amount"]));
                        else if (dr["Item"].ToString() == "Google Iam - admin Service Accounts")
                            _ = seriesSpl_5IAM.Points.AddXY(Convert.ToDateTime(dr["TranDate"]).ToString("MM-dd").Replace("-", "/"), Convert.ToDouble(dr["Amount"]));
                        else if (dr["Item"].ToString() == "Google Workspace")
                            _ = seriesSpl_6GWS.Points.AddXY(Convert.ToDateTime(dr["TranDate"]).ToString("MM-dd").Replace("-", "/"), Convert.ToDouble(dr["Amount"]));
                    }
                }

                // Dummy data
                //seriesSpl1.Points.AddXY("2023-01-01", 22);
                //seriesSpl1.Points.AddXY("2023-01-02", 57);
                //seriesSpl1.Points.AddXY("2023-01-03", 45);
                //seriesSpl1.Points.AddXY("2023-01-04", 39);
                //seriesSpl1.Points.AddXY("2023-01-05", 31);

                chartSpline.Series.Add(seriesSpl_1GKE);
                chartSpline.Series.Add(seriesSpl_2BQ);
                chartSpline.Series.Add(seriesSpl_3BQS);
                chartSpline.Series.Add(seriesSpl_4GAE);
                chartSpline.Series.Add(seriesSpl_5IAM);
                chartSpline.Series.Add(seriesSpl_6GWS);

                chartSpline.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0";

                chartSpline.Legends.Clear();

                //foreach (var legend in chartStackedColumn.Legends)
                //    legend.Font = new Font("Consolas", 12);

                //foreach (var series in chartSpline.Series)
                //    series.Color = Color.FromArgb(128, series.Color.R, series.Color.G, series.Color.B);

                #endregion

                //MessageBox.Show(response.Substring(0, 100));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                btnSearch.Text = "Search";
                btnSearch.Enabled = true;
                if (!btnSearch.Focused)
                    btnSearch.Focus();
            }
        }

        private void btnTestForm_Click(object sender, EventArgs e)
        {
            frmTest1 frm = new frmTest1();

            frm.Show();
        }
    }
}