namespace CapHo.TableEditing
{
    partial class EditPlayerShop
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.shopLevel = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ownerid = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.shopName = new System.Windows.Forms.TextBox();
            this.Results = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.shopid = new System.Windows.Forms.NumericUpDown();
            this.location = new System.Windows.Forms.TextBox();
            this.ds = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.shopLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Shop Name";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(9, 285);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(219, 59);
            this.deleteBtn.TabIndex = 56;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(9, 220);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(219, 59);
            this.modifyBtn.TabIndex = 55;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(9, 155);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(219, 59);
            this.createBtn.TabIndex = 54;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // shopLevel
            // 
            this.shopLevel.Location = new System.Drawing.Point(105, 129);
            this.shopLevel.Name = "shopLevel";
            this.shopLevel.Size = new System.Drawing.Size(123, 20);
            this.shopLevel.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Shop Level";
            // 
            // ownerid
            // 
            this.ownerid.Location = new System.Drawing.Point(105, 12);
            this.ownerid.Name = "ownerid";
            this.ownerid.Size = new System.Drawing.Size(123, 20);
            this.ownerid.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "owner id";
            // 
            // shopName
            // 
            this.shopName.Location = new System.Drawing.Point(105, 74);
            this.shopName.Name = "shopName";
            this.shopName.Size = new System.Drawing.Size(123, 20);
            this.shopName.TabIndex = 47;
            this.shopName.Text = "(none)";
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
            this.Results.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Shop Id";
            // 
            // shopid
            // 
            this.shopid.Location = new System.Drawing.Point(105, 41);
            this.shopid.Name = "shopid";
            this.shopid.Size = new System.Drawing.Size(123, 20);
            this.shopid.TabIndex = 63;
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(105, 100);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(123, 20);
            this.location.TabIndex = 64;
            this.location.Text = "(none)";
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            // 
            // EditPlayerShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 356);
            this.Controls.Add(this.location);
            this.Controls.Add(this.shopid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.shopLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ownerid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shopName);
            this.Controls.Add(this.Results);
            this.Name = "EditPlayerShop";
            this.Text = "EditPlayerShop";
            this.Load += new System.EventHandler(this.EditPlayerShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.NumericUpDown shopLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ownerid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shopName;
        private System.Windows.Forms.DataGridView Results;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown shopid;
        private System.Windows.Forms.TextBox location;
        private System.Data.DataSet ds;
    }
}