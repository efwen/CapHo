namespace CapHo.TableEditing
{
    partial class EditShopTransaction
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
            this.label5 = new System.Windows.Forms.Label();
            this.customerid = new System.Windows.Forms.NumericUpDown();
            this.transactionAmt = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemid = new System.Windows.Forms.NumericUpDown();
            this.shopid = new System.Windows.Forms.NumericUpDown();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.transactionType = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transactionid = new System.Windows.Forms.NumericUpDown();
            this.Results = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.transactionTime = new System.Windows.Forms.ComboBox();
            this.transactionday = new System.Windows.Forms.NumericUpDown();
            this.ds = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.customerid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "customer id";
            // 
            // customerid
            // 
            this.customerid.Location = new System.Drawing.Point(116, 88);
            this.customerid.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.customerid.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.customerid.Name = "customerid";
            this.customerid.Size = new System.Drawing.Size(120, 20);
            this.customerid.TabIndex = 54;
            this.customerid.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // transactionAmt
            // 
            this.transactionAmt.DecimalPlaces = 2;
            this.transactionAmt.Location = new System.Drawing.Point(116, 166);
            this.transactionAmt.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.transactionAmt.Name = "transactionAmt";
            this.transactionAmt.Size = new System.Drawing.Size(120, 20);
            this.transactionAmt.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "transaction amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "quantity";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(116, 140);
            this.quantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(120, 20);
            this.quantity.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Transaction Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "item id";
            // 
            // itemid
            // 
            this.itemid.Location = new System.Drawing.Point(116, 114);
            this.itemid.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.itemid.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itemid.Name = "itemid";
            this.itemid.Size = new System.Drawing.Size(120, 20);
            this.itemid.TabIndex = 47;
            this.itemid.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // shopid
            // 
            this.shopid.Location = new System.Drawing.Point(116, 62);
            this.shopid.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.shopid.Name = "shopid";
            this.shopid.Size = new System.Drawing.Size(120, 20);
            this.shopid.TabIndex = 46;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(12, 390);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(226, 59);
            this.deleteBtn.TabIndex = 45;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(12, 325);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(226, 59);
            this.modifyBtn.TabIndex = 44;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(11, 260);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(226, 59);
            this.createBtn.TabIndex = 43;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // transactionType
            // 
            this.transactionType.Location = new System.Drawing.Point(116, 38);
            this.transactionType.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.transactionType.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.transactionType.Name = "transactionType";
            this.transactionType.Size = new System.Drawing.Size(120, 20);
            this.transactionType.TabIndex = 42;
            this.transactionType.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "shopid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Transaction ID";
            // 
            // transactionid
            // 
            this.transactionid.Location = new System.Drawing.Point(116, 12);
            this.transactionid.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.transactionid.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.transactionid.Name = "transactionid";
            this.transactionid.Size = new System.Drawing.Size(120, 20);
            this.transactionid.TabIndex = 39;
            this.transactionid.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Results
            // 
            this.Results.AllowUserToAddRows = false;
            this.Results.AllowUserToDeleteRows = false;
            this.Results.AllowUserToResizeColumns = false;
            this.Results.AllowUserToResizeRows = false;
            this.Results.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results.Location = new System.Drawing.Point(251, 12);
            this.Results.MultiSelect = false;
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Results.Size = new System.Drawing.Size(762, 437);
            this.Results.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "transaction day";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "transaction time";
            // 
            // transactionTime
            // 
            this.transactionTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transactionTime.FormattingEnabled = true;
            this.transactionTime.Items.AddRange(new object[] {
            "Morning",
            "Noon",
            "Evening",
            "Night"});
            this.transactionTime.Location = new System.Drawing.Point(116, 231);
            this.transactionTime.Name = "transactionTime";
            this.transactionTime.Size = new System.Drawing.Size(120, 21);
            this.transactionTime.TabIndex = 58;
            // 
            // transactionday
            // 
            this.transactionday.Location = new System.Drawing.Point(116, 199);
            this.transactionday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.transactionday.Name = "transactionday";
            this.transactionday.Size = new System.Drawing.Size(120, 20);
            this.transactionday.TabIndex = 59;
            this.transactionday.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            // 
            // EditShopTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 463);
            this.Controls.Add(this.transactionday);
            this.Controls.Add(this.transactionTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customerid);
            this.Controls.Add(this.transactionAmt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemid);
            this.Controls.Add(this.shopid);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.transactionType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transactionid);
            this.Controls.Add(this.Results);
            this.Name = "EditShopTransaction";
            this.Text = "EditShopTransaction";
            this.Load += new System.EventHandler(this.EditShopTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown customerid;
        private System.Windows.Forms.NumericUpDown transactionAmt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown itemid;
        private System.Windows.Forms.NumericUpDown shopid;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.NumericUpDown transactionType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown transactionid;
        private System.Windows.Forms.DataGridView Results;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox transactionTime;
        private System.Windows.Forms.NumericUpDown transactionday;
        private System.Data.DataSet ds;
    }
}