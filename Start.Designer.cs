namespace CapHo
{
    partial class Start
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbDBName = new System.Windows.Forms.TextBox();
            this.QueryResults = new System.Windows.Forms.DataGridView();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.Title = new System.Windows.Forms.Label();
            this.SubTitle = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.DBEditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QueryResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(775, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Port";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(537, 128);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 20);
            this.tbUser.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "DBName";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(537, 154);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 13;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(660, 152);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 14;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(537, 187);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(321, 20);
            this.tbHost.TabIndex = 15;
            this.tbHost.Text = "css475sp17-capho.c2b3wqyc8e3g.us-west-2.rds.amazonaws.com";
            // 
            // tbDBName
            // 
            this.tbDBName.Location = new System.Drawing.Point(713, 128);
            this.tbDBName.Name = "tbDBName";
            this.tbDBName.Size = new System.Drawing.Size(100, 20);
            this.tbDBName.TabIndex = 17;
            this.tbDBName.Text = "CapHo";
            // 
            // QueryResults
            // 
            this.QueryResults.AllowUserToAddRows = false;
            this.QueryResults.AllowUserToDeleteRows = false;
            this.QueryResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueryResults.Location = new System.Drawing.Point(462, 225);
            this.QueryResults.Name = "QueryResults";
            this.QueryResults.ReadOnly = true;
            this.QueryResults.Size = new System.Drawing.Size(485, 321);
            this.QueryResults.TabIndex = 19;
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(807, 159);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(120, 20);
            this.numPort.TabIndex = 20;
            this.numPort.Tag = "";
            this.numPort.Value = new decimal(new int[] {
            5432,
            0,
            0,
            0});
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(693, 108);
            this.Title.TabIndex = 21;
            this.Title.Text = "Capitalism, Ho!";
            // 
            // SubTitle
            // 
            this.SubTitle.AutoSize = true;
            this.SubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTitle.Location = new System.Drawing.Point(20, 117);
            this.SubTitle.Name = "SubTitle";
            this.SubTitle.Size = new System.Drawing.Size(398, 55);
            this.SubTitle.TabIndex = 22;
            this.SubTitle.Text = "[Group Members]";
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(30, 188);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(409, 170);
            this.PlayButton.TabIndex = 23;
            this.PlayButton.Text = "Play!";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // DBEditButton
            // 
            this.DBEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBEditButton.Location = new System.Drawing.Point(30, 376);
            this.DBEditButton.Name = "DBEditButton";
            this.DBEditButton.Size = new System.Drawing.Size(409, 170);
            this.DBEditButton.TabIndex = 24;
            this.DBEditButton.Text = "Edit Database";
            this.DBEditButton.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 565);
            this.Controls.Add(this.DBEditButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.SubTitle);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.QueryResults);
            this.Controls.Add(this.tbDBName);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Start";
            this.Text = "Capitalism, Ho!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QueryResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbDBName;
        private System.Windows.Forms.DataGridView QueryResults;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label SubTitle;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button DBEditButton;
    }
}

