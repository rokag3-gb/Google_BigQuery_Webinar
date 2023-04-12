namespace FormApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn조회 = new Button();
            btnInsert = new Button();
            btnExecuteQuery = new Button();
            SuspendLayout();
            // 
            // btn조회
            // 
            btn조회.Location = new Point(447, 115);
            btn조회.Name = "btn조회";
            btn조회.Size = new Size(265, 81);
            btn조회.TabIndex = 0;
            btn조회.Text = "Get BigQuery Data Select (SDK)";
            btn조회.UseVisualStyleBackColor = true;
            btn조회.Click += btn조회_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(447, 256);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(265, 81);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Insert into BigQuery (SDK)";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnExecuteQuery
            // 
            btnExecuteQuery.Location = new Point(74, 115);
            btnExecuteQuery.Name = "btnExecuteQuery";
            btnExecuteQuery.Size = new Size(265, 81);
            btnExecuteQuery.TabIndex = 0;
            btnExecuteQuery.Text = "Execute Query (Http)";
            btnExecuteQuery.UseVisualStyleBackColor = true;
            btnExecuteQuery.Click += btnExecuteQuery_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExecuteQuery);
            Controls.Add(btnInsert);
            Controls.Add(btn조회);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn조회;
        private Button btnInsert;
        private Button btnExecuteQuery;
    }
}