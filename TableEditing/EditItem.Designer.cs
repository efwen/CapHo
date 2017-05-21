namespace CapHo.TableEditing
{
    partial class EditItem
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
            this.Results = new System.Windows.Forms.DataGridView();
            this.ds = new System.Data.DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemid = new System.Windows.Forms.NumericUpDown();
            this.basePrice = new System.Windows.Forms.NumericUpDown();
            this.itemName = new System.Windows.Forms.TextBox();
            this.itemDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(17, 276);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(171, 59);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(17, 211);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(171, 59);
            this.modifyBtn.TabIndex = 15;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(16, 146);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(171, 59);
            this.createBtn.TabIndex = 14;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // Results
            // 
            this.Results.AllowUserToAddRows = false;
            this.Results.AllowUserToDeleteRows = false;
            this.Results.AllowUserToResizeColumns = false;
            this.Results.AllowUserToResizeRows = false;
            this.Results.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results.Location = new System.Drawing.Point(246, 12);
            this.Results.MultiSelect = false;
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Results.Size = new System.Drawing.Size(471, 334);
            this.Results.TabIndex = 17;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "itemid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "itemname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "item description";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "base price";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // itemid
            // 
            this.itemid.Location = new System.Drawing.Point(120, 10);
            this.itemid.Name = "itemid";
            this.itemid.Size = new System.Drawing.Size(120, 20);
            this.itemid.TabIndex = 22;
            // 
            // basePrice
            // 
            this.basePrice.DecimalPlaces = 2;
            this.basePrice.Location = new System.Drawing.Point(120, 93);
            this.basePrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.basePrice.Name = "basePrice";
            this.basePrice.Size = new System.Drawing.Size(120, 20);
            this.basePrice.TabIndex = 23;
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(120, 41);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(120, 20);
            this.itemName.TabIndex = 24;
            this.itemName.Text = "(none)";
            // 
            // itemDescription
            // 
            this.itemDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itemDescription.Location = new System.Drawing.Point(120, 67);
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.Size = new System.Drawing.Size(120, 20);
            this.itemDescription.TabIndex = 25;
            this.itemDescription.Text = "(none)";
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.basePrice);
            this.Controls.Add(this.itemDescription);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.itemid);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.label1);
            this.Name = "EditItem";
            this.Text = "EditItem";
            this.Load += new System.EventHandler(this.EditItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basePrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.DataGridView Results;
        private System.Data.DataSet ds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown itemid;
        private System.Windows.Forms.NumericUpDown basePrice;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.TextBox itemDescription;
    }
}