namespace CapHo.TableEditing
{
    partial class EditCustomer
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
            this.baseBudget = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.npcid = new System.Windows.Forms.NumericUpDown();
            this.Results = new System.Windows.Forms.DataGridView();
            this.budgetScaling = new System.Windows.Forms.NumericUpDown();
            this.stinginess = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plainPref = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lightPref = new System.Windows.Forms.NumericUpDown();
            this.relationship = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.ds = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.baseBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetScaling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stinginess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainPref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightPref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(11, 323);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(226, 59);
            this.deleteBtn.TabIndex = 27;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(11, 258);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(226, 59);
            this.modifyBtn.TabIndex = 26;
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(10, 193);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(226, 59);
            this.createBtn.TabIndex = 25;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // baseBudget
            // 
            this.baseBudget.DecimalPlaces = 2;
            this.baseBudget.Location = new System.Drawing.Point(117, 36);
            this.baseBudget.Name = "baseBudget";
            this.baseBudget.Size = new System.Drawing.Size(120, 20);
            this.baseBudget.TabIndex = 22;
            this.baseBudget.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Budget Scaling";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "npcid";
            // 
            // npcid
            // 
            this.npcid.Location = new System.Drawing.Point(117, 10);
            this.npcid.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.npcid.Name = "npcid";
            this.npcid.Size = new System.Drawing.Size(120, 20);
            this.npcid.TabIndex = 17;
            // 
            // Results
            // 
            this.Results.AllowUserToAddRows = false;
            this.Results.AllowUserToDeleteRows = false;
            this.Results.AllowUserToResizeColumns = false;
            this.Results.AllowUserToResizeRows = false;
            this.Results.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results.Location = new System.Drawing.Point(252, 10);
            this.Results.MultiSelect = false;
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Results.Size = new System.Drawing.Size(484, 372);
            this.Results.TabIndex = 14;
            // 
            // budgetScaling
            // 
            this.budgetScaling.DecimalPlaces = 3;
            this.budgetScaling.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.budgetScaling.Location = new System.Drawing.Point(117, 60);
            this.budgetScaling.Name = "budgetScaling";
            this.budgetScaling.Size = new System.Drawing.Size(120, 20);
            this.budgetScaling.TabIndex = 28;
            // 
            // stinginess
            // 
            this.stinginess.DecimalPlaces = 3;
            this.stinginess.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.stinginess.Location = new System.Drawing.Point(117, 112);
            this.stinginess.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stinginess.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.stinginess.Name = "stinginess";
            this.stinginess.Size = new System.Drawing.Size(120, 20);
            this.stinginess.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Stinginess";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Base Budget";
            // 
            // plainPref
            // 
            this.plainPref.DecimalPlaces = 3;
            this.plainPref.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.plainPref.Location = new System.Drawing.Point(117, 138);
            this.plainPref.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.plainPref.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.plainPref.Name = "plainPref";
            this.plainPref.Size = new System.Drawing.Size(120, 20);
            this.plainPref.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Plain Preference";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Light Preference";
            // 
            // lightPref
            // 
            this.lightPref.DecimalPlaces = 3;
            this.lightPref.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.lightPref.Location = new System.Drawing.Point(117, 164);
            this.lightPref.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lightPref.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.lightPref.Name = "lightPref";
            this.lightPref.Size = new System.Drawing.Size(120, 20);
            this.lightPref.TabIndex = 35;
            // 
            // relationship
            // 
            this.relationship.Location = new System.Drawing.Point(117, 86);
            this.relationship.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.relationship.Name = "relationship";
            this.relationship.Size = new System.Drawing.Size(120, 20);
            this.relationship.TabIndex = 36;
            this.relationship.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Relationship";
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 393);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.relationship);
            this.Controls.Add(this.lightPref);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.plainPref);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stinginess);
            this.Controls.Add(this.budgetScaling);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.baseBudget);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.npcid);
            this.Controls.Add(this.Results);
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npcid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetScaling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stinginess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plainPref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightPref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.NumericUpDown baseBudget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown npcid;
        private System.Windows.Forms.DataGridView Results;
        private System.Windows.Forms.NumericUpDown budgetScaling;
        private System.Windows.Forms.NumericUpDown stinginess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown plainPref;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown lightPref;
        private System.Windows.Forms.NumericUpDown relationship;
        private System.Windows.Forms.Label label5;
        private System.Data.DataSet ds;
    }
}