namespace CapHo.TableEditing
{
    partial class EditNPCShopInventory
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
            this.shopid = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.itemid = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.DataGridView();
            this.limited = new System.Windows.Forms.CheckBox();
            this.ds = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.shopid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // shopid
            // 
            this.shopid.Location = new System.Drawing.Point(105, 12);
            this.shopid.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.shopid.Name = "shopid";
            this.shopid.Size = new System.Drawing.Size(123, 20);
            this.shopid.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "Shop Id";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(9, 285);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(219, 59);
            this.deleteBtn.TabIndex = 85;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(9, 220);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(219, 59);
            this.modifyBtn.TabIndex = 84;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(9, 155);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(219, 59);
            this.createBtn.TabIndex = 83;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(105, 64);
            this.quantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(123, 20);
            this.quantity.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Quantity";
            // 
            // itemid
            // 
            this.itemid.Location = new System.Drawing.Point(105, 38);
            this.itemid.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.itemid.Name = "itemid";
            this.itemid.Size = new System.Drawing.Size(123, 20);
            this.itemid.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Item Id";
            // 
            // Results
            // 
            this.Results.AllowUserToAddRows = false;
            this.Results.AllowUserToDeleteRows = false;
            this.Results.AllowUserToResizeColumns = false;
            this.Results.AllowUserToResizeRows = false;
            this.Results.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results.Location = new System.Drawing.Point(244, 12);
            this.Results.MultiSelect = false;
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Results.Size = new System.Drawing.Size(474, 332);
            this.Results.TabIndex = 78;
            // 
            // limited
            // 
            this.limited.AutoSize = true;
            this.limited.Location = new System.Drawing.Point(9, 91);
            this.limited.Name = "limited";
            this.limited.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.limited.Size = new System.Drawing.Size(59, 17);
            this.limited.TabIndex = 88;
            this.limited.Text = "Limited";
            this.limited.UseVisualStyleBackColor = true;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            // 
            // EditNPCShopInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 350);
            this.Controls.Add(this.limited);
            this.Controls.Add(this.shopid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Results);
            this.Name = "EditNPCShopInventory";
            this.Text = "EditNPCShopInventory";
            this.Load += new System.EventHandler(this.EditNPCShopInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown shopid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown itemid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Results;
        private System.Windows.Forms.CheckBox limited;
        private System.Data.DataSet ds;
    }
}