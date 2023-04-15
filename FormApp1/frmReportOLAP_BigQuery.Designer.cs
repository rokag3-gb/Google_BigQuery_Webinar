namespace FormApp1
{
    partial class frmReportOLAP_BigQuery
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            txtTopSellingProduct = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            label8 = new Label();
            txtTotalNumberOfSales = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 172F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.43299F));
            tableLayoutPanel1.Size = new Size(1788, 741);
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
            btnTestForm.Location = new Point(1556, 24);
            btnTestForm.Name = "btnTestForm";
            btnTestForm.Size = new Size(201, 79);
            btnTestForm.TabIndex = 5;
            btnTestForm.Text = "Test Form";
            btnTestForm.UseVisualStyleBackColor = true;
            btnTestForm.Click += btnTestForm_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label6);
            panel6.Controls.Add(cboHost);
            panel6.Location = new Point(659, 24);
            panel6.Name = "panel6";
            panel6.Size = new Size(517, 79);
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
            cboHost.Size = new Size(494, 38);
            cboHost.TabIndex = 0;
            cboHost.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(352, 24);
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
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.7633076F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.5549259F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.8992081F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.89581F));
            tableLayoutPanel2.Controls.Add(panel7, 3, 0);
            tableLayoutPanel2.Controls.Add(panel5, 2, 0);
            tableLayoutPanel2.Controls.Add(panel4, 1, 0);
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(11, 130);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1766, 166);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(1346, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(417, 160);
            panel7.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(txtTopSellingProduct);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(766, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(574, 160);
            panel5.TabIndex = 6;
            // 
            // txtTopSellingProduct
            // 
            txtTopSellingProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTopSellingProduct.Font = new Font("Cascadia Code", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            txtTopSellingProduct.Location = new Point(18, 73);
            txtTopSellingProduct.Name = "txtTopSellingProduct";
            txtTopSellingProduct.Size = new Size(538, 46);
            txtTopSellingProduct.TabIndex = 3;
            txtTopSellingProduct.TabStop = false;
            txtTopSellingProduct.Text = "Google Kubernetes Engine";
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
            panel4.Location = new Point(404, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(356, 160);
            panel4.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(18, 43);
            label8.Name = "label8";
            label8.Size = new Size(150, 22);
            label8.TabIndex = 4;
            label8.Text = "(record count)";
            // 
            // txtTotalNumberOfSales
            // 
            txtTotalNumberOfSales.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTotalNumberOfSales.Font = new Font("Cascadia Code", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalNumberOfSales.Location = new Point(18, 73);
            txtTotalNumberOfSales.Name = "txtTotalNumberOfSales";
            txtTotalNumberOfSales.Size = new Size(318, 54);
            txtTotalNumberOfSales.TabIndex = 3;
            txtTotalNumberOfSales.TabStop = false;
            txtTotalNumberOfSales.Text = "750,971,902";
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
            panel3.Controls.Add(txtTotalSales);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(395, 160);
            panel3.TabIndex = 4;
            // 
            // txtTotalSales
            // 
            txtTotalSales.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTotalSales.Font = new Font("Cascadia Code", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalSales.Location = new Point(18, 73);
            txtTotalSales.Name = "txtTotalSales";
            txtTotalSales.Size = new Size(355, 54);
            txtTotalSales.TabIndex = 3;
            txtTotalSales.TabStop = false;
            txtTotalSales.Text = "7,912,277,885";
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
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.02814F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.97186F));
            tableLayoutPanel3.Controls.Add(chartDoughtnut, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(11, 302);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1766, 428);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // chartDoughtnut
            // 
            chartArea1.Name = "ChartArea1";
            chartDoughtnut.ChartAreas.Add(chartArea1);
            chartDoughtnut.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartDoughtnut.Legends.Add(legend1);
            chartDoughtnut.Location = new Point(3, 3);
            chartDoughtnut.Name = "chartDoughtnut";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDoughtnut.Series.Add(series1);
            chartDoughtnut.Size = new Size(789, 422);
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
            tableLayoutPanel4.Location = new Point(795, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 56.7757F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 43.2243F));
            tableLayoutPanel4.Size = new Size(971, 428);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // chartSpline
            // 
            chartArea2.Name = "ChartArea1";
            chartSpline.ChartAreas.Add(chartArea2);
            chartSpline.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartSpline.Legends.Add(legend2);
            chartSpline.Location = new Point(3, 246);
            chartSpline.Name = "chartSpline";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartSpline.Series.Add(series2);
            chartSpline.Size = new Size(965, 179);
            chartSpline.TabIndex = 2;
            chartSpline.TabStop = false;
            chartSpline.Text = "chart1";
            // 
            // chartStackedColumn
            // 
            chartArea3.Name = "ChartArea1";
            chartStackedColumn.ChartAreas.Add(chartArea3);
            chartStackedColumn.Dock = DockStyle.Fill;
            legend3.Name = "Legend1";
            chartStackedColumn.Legends.Add(legend3);
            chartStackedColumn.Location = new Point(3, 3);
            chartStackedColumn.Name = "chartStackedColumn";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartStackedColumn.Series.Add(series3);
            chartStackedColumn.Size = new Size(965, 237);
            chartStackedColumn.TabIndex = 1;
            chartStackedColumn.TabStop = false;
            chartStackedColumn.Text = "chart1";
            // 
            // frmReportOLAP_BigQuery
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1788, 741);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Cascadia Code", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmReportOLAP_BigQuery";
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
    }
}