namespace CapHo
{
    partial class Editor
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
            this.SQLCmdBox = new System.Windows.Forms.RichTextBox();
            this.InputSQLLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Results = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.ds = new System.Data.DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.selectTable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // SQLCmdBox
            // 
            this.SQLCmdBox.Location = new System.Drawing.Point(3, 55);
            this.SQLCmdBox.Name = "SQLCmdBox";
            this.SQLCmdBox.Size = new System.Drawing.Size(210, 87);
            this.SQLCmdBox.TabIndex = 2;
            this.SQLCmdBox.Text = "";
            // 
            // InputSQLLabel
            // 
            this.InputSQLLabel.AutoSize = true;
            this.InputSQLLabel.Location = new System.Drawing.Point(3, 39);
            this.InputSQLLabel.Name = "InputSQLLabel";
            this.InputSQLLabel.Size = new System.Drawing.Size(78, 13);
            this.InputSQLLabel.TabIndex = 3;
            this.InputSQLLabel.Text = "SQL Command";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Results";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Results);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.SQLCmdBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.InputSQLLabel);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 346);
            this.panel1.TabIndex = 5;
            // 
            // Results
            // 
            this.Results.AllowUserToAddRows = false;
            this.Results.AllowUserToDeleteRows = false;
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results.Location = new System.Drawing.Point(6, 161);
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.Size = new System.Drawing.Size(269, 177);
            this.Results.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 87);
            this.button3.TabIndex = 6;
            this.button3.Text = "Execute";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Query Entry";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 21);
            this.button1.TabIndex = 13;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectTable
            // 
            this.selectTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTable.FormattingEnabled = true;
            this.selectTable.Location = new System.Drawing.Point(12, 36);
            this.selectTable.Name = "selectTable";
            this.selectTable.Size = new System.Drawing.Size(191, 21);
            this.selectTable.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Choose a table editing tool:";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 435);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectTable);
            this.Controls.Add(this.panel1);
            this.Name = "Editor";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox SQLCmdBox;
        private System.Windows.Forms.Label InputSQLLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Results;
        private System.Windows.Forms.Button button3;
        private System.Data.DataSet ds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox selectTable;
        private System.Windows.Forms.Label label3;
    }
}