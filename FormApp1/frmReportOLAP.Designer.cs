namespace FormApp1
{
    partial class frmReportOLAP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            btnTestForm = new Button();
            panel6 = new Panel();
            label6 = new Label();
            cboHost = new ComboBox();
            btnSearch = new Button();
            panel2 = new Panel();
            label2 = new Label();
            cboQuarter = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            cboYear = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel7 = new Panel();
            panel5 = new Panel();
            lblTopSellingProduct = new Label();
            txtTopSellingProduct = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            label8 = new Label();
            txtTotalNumberOfSales = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            txtTotalSales = new TextBox();
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            chartDoughtnut = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanel4 = new TableLayoutPanel();
            chartSpline = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartStackedColumn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDoughtnut).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartSpline).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartStackedColumn).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.2F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(8);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 119F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 190F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.43299F));
            tableLayoutPanel1.Size = new Size(1788, 988);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTestForm);
            groupBox1.Controls.Add(panel6);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(11, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(1766, 113);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnTestForm
            // 
            btnTestForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTestForm.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTestForm.Location = new Point(1615, 24);
            btnTestForm.Name = "btnTestForm";
            btnTestForm.Size = new Size(142, 79);
            btnTestForm.TabIndex = 5;
            btnTestForm.TabStop = false;
            btnTestForm.Text = "Test Form";
            btnTestForm.UseVisualStyleBackColor = true;
            btnTestForm.Click += btnTestForm_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label6);
            panel6.Controls.Add(cboHost);
            panel6.Location = new Point(352, 24);
            panel6.Name = "panel6";
            panel6.Size = new Size(512, 79);
            panel6.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 7);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 1;
            label6.Text = "Host";
            // 
            // cboHost
            // 
            cboHost.FlatStyle = FlatStyle.Flat;
            cboHost.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cboHost.FormattingEnabled = true;
            cboHost.Items.AddRange(new object[] { "1Q", "2Q", "3Q", "4Q" });
            cboHost.Location = new Point(13, 30);
            cboHost.Margin = new Padding(4);
            cboHost.Name = "cboHost";
            cboHost.Size = new Size(487, 38);
            cboHost.TabIndex = 0;
            cboHost.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(878, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(296, 79);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cboQuarter);
            panel2.Location = new Point(217, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(122, 79);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 7);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Quarter";
            // 
            // cboQuarter
            // 
            cboQuarter.FlatStyle = FlatStyle.Flat;
            cboQuarter.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cboQuarter.FormattingEnabled = true;
            cboQuarter.Items.AddRange(new object[] { "1Q", "2Q", "3Q", "4Q" });
            cboQuarter.Location = new Point(13, 30);
            cboQuarter.Margin = new Padding(4);
            cboQuarter.Name = "cboQuarter";
            cboQuarter.Size = new Size(92, 38);
            cboQuarter.TabIndex = 0;
            cboQuarter.TabStop = false;
            cboQuarter.Text = "1Q";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboYear);
            panel1.Location = new Point(13, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 79);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 7);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 1;
            label1.Text = "Year";
            // 
            // cboYear
            // 
            cboYear.FlatStyle = FlatStyle.Flat;
            cboYear.Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cboYear.FormattingEnabled = true;
            cboYear.Items.AddRange(new object[] { "2023", "2022", "2021", "2020" });
            cboYear.Location = new Point(13, 30);
            cboYear.Margin = new Padding(4);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(163, 38);
            cboYear.TabIndex = 0;
            cboYear.TabStop = false;
            cboYear.Text = "2023";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.3861828F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.4246883F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.6749725F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.6274061F));
            tableLayoutPanel2.Controls.Add(panel7, 3, 0);
            tableLayoutPanel2.Controls.Add(panel5, 2, 0);
            tableLayoutPanel2.Controls.Add(panel4, 1, 0);
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(11, 130);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1766, 184);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(1545, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(218, 178);
            panel7.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lblTopSellingProduct);
            panel5.Controls.Add(txtTopSellingProduct);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(863, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(676, 178);
            panel5.TabIndex = 6;
            // 
            // lblTopSellingProduct
            // 
            lblTopSellingProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTopSellingProduct.AutoSize = true;
            lblTopSellingProduct.Font = new Font("Cascadia Code", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTopSellingProduct.Location = new Point(16, 83);
            lblTopSellingProduct.Name = "lblTopSellingProduct";
            lblTopSellingProduct.Size = new Size(638, 72);
            lblTopSellingProduct.TabIndex = 4;
            lblTopSellingProduct.Text = "Google BigQuery API";
            lblTopSellingProduct.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTopSellingProduct
            // 
            txtTopSellingProduct.BorderStyle = BorderStyle.None;
            txtTopSellingProduct.Font = new Font("Cascadia Code", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtTopSellingProduct.Location = new Point(353, 18);
            txtTopSellingProduct.Name = "txtTopSellingProduct";
            txtTopSellingProduct.Size = new Size(166, 43);
            txtTopSellingProduct.TabIndex = 3;
            txtTopSellingProduct.TabStop = false;
            txtTopSellingProduct.Text = "Google Kubernetes Engine";
            txtTopSellingProduct.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 16);
            label5.Name = "label5";
            label5.Size = new Size(240, 27);
            label5.TabIndex = 1;
            label5.Text = "Top Selling Product";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label8);
            panel4.Controls.Add(txtTotalNumberOfSales);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(415, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(442, 178);
            panel4.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(18, 42);
            label8.Name = "label8";
            label8.Size = new Size(135, 20);
            label8.TabIndex = 4;
            label8.Text = "(record count)";
            // 
            // txtTotalNumberOfSales
            // 
            txtTotalNumberOfSales.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTotalNumberOfSales.BackColor = Color.White;
            txtTotalNumberOfSales.BorderStyle = BorderStyle.None;
            txtTotalNumberOfSales.Font = new Font("Cascadia Code", 48F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalNumberOfSales.Location = new Point(18, 69);
            txtTotalNumberOfSales.Name = "txtTotalNumberOfSales";
            txtTotalNumberOfSales.ReadOnly = true;
            txtTotalNumberOfSales.Size = new Size(404, 93);
            txtTotalNumberOfSales.TabIndex = 3;
            txtTotalNumberOfSales.TabStop = false;
            txtTotalNumberOfSales.Text = "600.1 M";
            txtTotalNumberOfSales.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 16);
            label4.Name = "label4";
            label4.Size = new Size(264, 27);
            label4.TabIndex = 1;
            label4.Text = "Total number of sales";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtTotalSales);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(406, 178);
            panel3.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(169, 15);
            label7.Name = "label7";
            label7.Size = new Size(32, 28);
            label7.TabIndex = 5;
            label7.Text = "￦";
            // 
            // txtTotalSales
            // 
            txtTotalSales.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTotalSales.BackColor = Color.White;
            txtTotalSales.BorderStyle = BorderStyle.None;
            txtTotalSales.Font = new Font("Cascadia Code", 48F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalSales.Location = new Point(18, 69);
            txtTotalSales.Name = "txtTotalSales";
            txtTotalSales.ReadOnly = true;
            txtTotalSales.Size = new Size(366, 93);
            txtTotalSales.TabIndex = 3;
            txtTotalSales.TabStop = false;
            txtTotalSales.Text = "9.9 B";
            txtTotalSales.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 16);
            label3.Name = "label3";
            label3.Size = new Size(144, 27);
            label3.TabIndex = 1;
            label3.Text = "Total Sales";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.8255959F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.1744041F));
            tableLayoutPanel3.Controls.Add(chartDoughtnut, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(11, 320);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1766, 657);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // chartDoughtnut
            // 
            chartArea4.Name = "ChartArea1";
            chartDoughtnut.ChartAreas.Add(chartArea4);
            chartDoughtnut.Dock = DockStyle.Fill;
            legend4.Name = "Legend1";
            chartDoughtnut.Legends.Add(legend4);
            chartDoughtnut.Location = new Point(3, 3);
            chartDoughtnut.Name = "chartDoughtnut";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series7.CustomProperties = "PieStartAngle=270, DoughnutRadius=50";
            series7.IsValueShownAsLabel = true;
            series7.Legend = "Legend1";
            series7.Name = "Google Cloud Services";
            chartDoughtnut.Series.Add(series7);
            chartDoughtnut.Size = new Size(662, 651);
            chartDoughtnut.TabIndex = 0;
            chartDoughtnut.TabStop = false;
            chartDoughtnut.Text = "chart1";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(chartSpline, 0, 1);
            tableLayoutPanel4.Controls.Add(chartStackedColumn, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(668, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 56.7757F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 43.2243F));
            tableLayoutPanel4.Size = new Size(1098, 657);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // chartSpline
            // 
            chartArea5.Name = "ChartArea1";
            chartSpline.ChartAreas.Add(chartArea5);
            chartSpline.Dock = DockStyle.Fill;
            legend5.Name = "Legend1";
            chartSpline.Legends.Add(legend5);
            chartSpline.Location = new Point(3, 376);
            chartSpline.Name = "chartSpline";
            series8.BorderWidth = 4;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.LabelBorderWidth = 6;
            series8.Legend = "Legend1";
            series8.MarkerBorderWidth = 5;
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series8.Name = "Google Cloud Services 1";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series9.Name = "Google Cloud Services 2";
            chartSpline.Series.Add(series8);
            chartSpline.Series.Add(series9);
            chartSpline.Size = new Size(1092, 278);
            chartSpline.TabIndex = 2;
            chartSpline.TabStop = false;
            chartSpline.Text = "chart1";
            // 
            // chartStackedColumn
            // 
            chartArea6.Name = "ChartArea1";
            chartStackedColumn.ChartAreas.Add(chartArea6);
            chartStackedColumn.Dock = DockStyle.Fill;
            legend6.Name = "Legend1";
            chartStackedColumn.Legends.Add(legend6);
            chartStackedColumn.Location = new Point(3, 3);
            chartStackedColumn.Name = "chartStackedColumn";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series10.Legend = "Legend1";
            series10.Name = "Google Cloud Services 1";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Google Cloud Services 2";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Google Cloud Services 3";
            chartStackedColumn.Series.Add(series10);
            chartStackedColumn.Series.Add(series11);
            chartStackedColumn.Series.Add(series12);
            chartStackedColumn.Size = new Size(1092, 367);
            chartStackedColumn.TabIndex = 1;
            chartStackedColumn.TabStop = false;
            chartStackedColumn.Text = "chart1";
            // 
            // frmReportOLAP
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1788, 988);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmReportOLAP";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OLAP Report - BigQuery";
            WindowState = FormWindowState.Maximized;
            Load += frmReportOLAP_BigQuery_Load;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDoughtnut).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartSpline).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartStackedColumn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private ComboBox cboYear;
        private GroupBox groupBox1;
        private Button btnSearch;
        private Panel panel2;
        private Label label2;
        private ComboBox cboQuarter;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private TextBox txtTotalSales;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel4;
        private TextBox txtTotalNumberOfSales;
        private Label label4;
        private Panel panel5;
        private TextBox txtTopSellingProduct;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoughtnut;
        private Panel panel6;
        private Label label6;
        private ComboBox cboHost;
        private TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStackedColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpline;
        private Panel panel7;
        private Label label8;
        private Button btnTestForm;
        private Label label7;
        private Label lblTopSellingProduct;
    }
}