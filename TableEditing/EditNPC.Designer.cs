namespace CapHo.TableEditing
{
    partial class EditNPC
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
            this.Results = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.npcid = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.race = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.ds = new System.Data.DataSet();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // Results
            // 
            this.Results.AllowUserToAddRows = false;
            this.Results.AllowUserToDeleteRows = false;
            this.Results.AllowUserToResizeColumns = false;
            this.Results.AllowUserToResizeRows = false;
            this.Results.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results.Location = new System.Drawing.Point(192, 10);
            this.Results.MultiSelect = false;
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Results.Size = new System.Drawing.Size(471, 334);
            this.Results.TabIndex = 0;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(66, 10);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(120, 20);
            this.name.TabIndex = 1;
            this.name.Text = "(none)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // npcid
            // 
            this.npcid.Location = new System.Drawing.Point(67, 36);
            this.npcid.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.npcid.Name = "npcid";
            this.npcid.Size = new System.Drawing.Size(120, 20);
            this.npcid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "npcid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender";
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.gender.Location = new System.Drawing.Point(67, 69);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(120, 21);
            this.gender.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(67, 102);
            this.age.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(119, 20);
            this.age.TabIndex = 8;
            // 
            // race
            // 
            this.race.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.race.FormattingEnabled = true;
            this.race.Items.AddRange(new object[] {
            "Elf",
            "Fairy",
            "Human",
            "Golem"});
            this.race.Location = new System.Drawing.Point(67, 128);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(119, 21);
            this.race.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Race";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(15, 155);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(171, 59);
            this.createBtn.TabIndex = 11;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(16, 220);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(171, 59);
            this.modifyBtn.TabIndex = 12;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(16, 285);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(171, 59);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // EditNPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 356);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.race);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.npcid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Results);
            this.Name = "EditNPC";
            this.Text = "EditNPC";
            this.Load += new System.EventHandler(this.EditNPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Results;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown npcid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.ComboBox race;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createBtn;
        private System.Data.DataSet ds;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}