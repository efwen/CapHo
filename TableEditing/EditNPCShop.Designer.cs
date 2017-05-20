namespace CapHo.TableEditing
{
    partial class EditNPCShop
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
            this.npc_shopid = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.npc_ownerid = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.shopname = new System.Windows.Forms.TextBox();
            this.Results = new System.Windows.Forms.DataGridView();
            this.ds = new System.Data.DataSet();
            this.location = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.npc_shopid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npc_ownerid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(10, 264);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(171, 59);
            this.deleteBtn.TabIndex = 27;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(10, 199);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(171, 59);
            this.modifyBtn.TabIndex = 26;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(10, 134);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(171, 59);
            this.createBtn.TabIndex = 25;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // npc_shopid
            // 
            this.npc_shopid.Location = new System.Drawing.Point(81, 38);
            this.npc_shopid.Name = "npc_shopid";
            this.npc_shopid.Size = new System.Drawing.Size(119, 20);
            this.npc_shopid.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Shop Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "npc_shopid";
            // 
            // npc_ownerid
            // 
            this.npc_ownerid.Location = new System.Drawing.Point(81, 12);
            this.npc_ownerid.Name = "npc_ownerid";
            this.npc_ownerid.Size = new System.Drawing.Size(120, 20);
            this.npc_ownerid.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "npc_ownerid";
            // 
            // shopname
            // 
            this.shopname.Location = new System.Drawing.Point(81, 71);
            this.shopname.Name = "shopname";
            this.shopname.Size = new System.Drawing.Size(120, 20);
            this.shopname.TabIndex = 15;
            this.shopname.Text = "(none)";
            // 
            // Results
            // 
            this.Results.AllowUserToAddRows = false;
            this.Results.AllowUserToDeleteRows = false;
            this.Results.AllowUserToResizeColumns = false;
            this.Results.AllowUserToResizeRows = false;
            this.Results.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results.Location = new System.Drawing.Point(207, 12);
            this.Results.MultiSelect = false;
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Results.Size = new System.Drawing.Size(471, 334);
            this.Results.TabIndex = 14;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(81, 97);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(120, 20);
            this.location.TabIndex = 28;
            this.location.Text = "(none)";
            // 
            // EditNPCShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 351);
            this.Controls.Add(this.location);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.npc_shopid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.npc_ownerid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shopname);
            this.Controls.Add(this.Results);
            this.Name = "EditNPCShop";
            this.Text = "EditNPCShop";
            this.Load += new System.EventHandler(this.EditNPCShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.npc_shopid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npc_ownerid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.NumericUpDown npc_shopid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown npc_ownerid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shopname;
        private System.Windows.Forms.DataGridView Results;
        private System.Data.DataSet ds;
        private System.Windows.Forms.TextBox location;
    }
}