namespace CapHo.TableEditing
{
    partial class EditNPCInventory
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
            this.npcid = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.itemid = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.DataGridView();
            this.ds = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.npcid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // npcid
            // 
            this.npcid.Location = new System.Drawing.Point(107, 12);
            this.npcid.Name = "npcid";
            this.npcid.Size = new System.Drawing.Size(123, 20);
            this.npcid.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "NPC ID";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(11, 285);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(219, 59);
            this.deleteBtn.TabIndex = 85;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(11, 220);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(219, 59);
            this.modifyBtn.TabIndex = 84;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(11, 155);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(219, 59);
            this.createBtn.TabIndex = 83;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(107, 64);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(123, 20);
            this.quantity.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Quantity";
            // 
            // itemid
            // 
            this.itemid.Location = new System.Drawing.Point(107, 38);
            this.itemid.Name = "itemid";
            this.itemid.Size = new System.Drawing.Size(123, 20);
            this.itemid.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 40);
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
            this.Results.Location = new System.Drawing.Point(246, 12);
            this.Results.MultiSelect = false;
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Results.Size = new System.Drawing.Size(474, 332);
            this.Results.TabIndex = 78;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            // 
            // EditNPCInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 352);
            this.Controls.Add(this.npcid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Results);
            this.Name = "EditNPCInventory";
            this.Text = "EditNPCInventory";
            this.Load += new System.EventHandler(this.EditNPCInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.npcid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown npcid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown itemid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Results;
        private System.Data.DataSet ds;
    }
}