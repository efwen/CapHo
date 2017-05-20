namespace CapHo.TableEditing
{
    partial class EditPlayerCharacter
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.merchantlevel = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerid = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.Results = new System.Windows.Forms.DataGridView();
            this.ds = new System.Data.DataSet();
            this.currentbalance = new System.Windows.Forms.NumericUpDown();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.currentdebt = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.merchantlevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentbalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentdebt)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(15, 309);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(213, 59);
            this.deleteBtn.TabIndex = 39;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(12, 244);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(216, 59);
            this.modifyBtn.TabIndex = 38;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(12, 179);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(216, 59);
            this.createBtn.TabIndex = 37;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // merchantlevel
            // 
            this.merchantlevel.Location = new System.Drawing.Point(108, 99);
            this.merchantlevel.Name = "merchantlevel";
            this.merchantlevel.Size = new System.Drawing.Size(120, 20);
            this.merchantlevel.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Current balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(9, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Merchant Level";
            // 
            // playerid
            // 
            this.playerid.Location = new System.Drawing.Point(108, 8);
            this.playerid.Name = "playerid";
            this.playerid.Size = new System.Drawing.Size(120, 20);
            this.playerid.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "playerid";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(108, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(120, 20);
            this.name.TabIndex = 30;
            this.name.Text = "(none)";
            // 
            // Results
            // 
            this.Results.AllowUserToAddRows = false;
            this.Results.AllowUserToDeleteRows = false;
            this.Results.AllowUserToResizeColumns = false;
            this.Results.AllowUserToResizeRows = false;
            this.Results.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results.Location = new System.Drawing.Point(243, 8);
            this.Results.MultiSelect = false;
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Results.Size = new System.Drawing.Size(471, 360);
            this.Results.TabIndex = 29;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            // 
            // currentbalance
            // 
            this.currentbalance.DecimalPlaces = 2;
            this.currentbalance.Location = new System.Drawing.Point(108, 127);
            this.currentbalance.Name = "currentbalance";
            this.currentbalance.Size = new System.Drawing.Size(120, 20);
            this.currentbalance.TabIndex = 41;
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.gender.Location = new System.Drawing.Point(108, 70);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(120, 21);
            this.gender.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Gender";
            // 
            // currentdebt
            // 
            this.currentdebt.DecimalPlaces = 2;
            this.currentdebt.Location = new System.Drawing.Point(108, 153);
            this.currentdebt.Name = "currentdebt";
            this.currentdebt.Size = new System.Drawing.Size(120, 20);
            this.currentdebt.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Current debt";
            // 
            // EditPlayerCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 381);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.currentdebt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.currentbalance);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.merchantlevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Results);
            this.Name = "EditPlayerCharacter";
            this.Text = "EditPlayerCharacter";
            this.Load += new System.EventHandler(this.EditPlayerCharacter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.merchantlevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentbalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentdebt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.NumericUpDown merchantlevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown playerid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DataGridView Results;
        private System.Data.DataSet ds;
        private System.Windows.Forms.NumericUpDown currentbalance;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown currentdebt;
        private System.Windows.Forms.Label label6;
    }
}