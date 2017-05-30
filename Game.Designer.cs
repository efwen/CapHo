namespace CapHo
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.label1 = new System.Windows.Forms.Label();
            this.dayNumLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dayPeriodLbl = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openShopBtn = new System.Windows.Forms.Button();
            this.buyFromGuild = new System.Windows.Forms.Button();
            this.ds = new System.Data.DataSet();
            this.shopPanel = new System.Windows.Forms.Panel();
            this.retHomeBtn = new System.Windows.Forms.Button();
            this.configDisplayBtn = new System.Windows.Forms.Button();
            this.runOpenShopBtn = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guildPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.guildPurchaseQty = new System.Windows.Forms.NumericUpDown();
            this.guildBuySellTabControl = new System.Windows.Forms.TabControl();
            this.guildBuyTab = new System.Windows.Forms.TabPage();
            this.guildBuyDGV = new System.Windows.Forms.DataGridView();
            this.guildPanelBuy = new System.Windows.Forms.Button();
            this.finishGuild = new System.Windows.Forms.Button();
            this.debtAmountLbl = new System.Windows.Forms.Label();
            this.merchantLevelLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerNameLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.daysToPaymentLbl = new System.Windows.Forms.Label();
            this.paymentAmtLbl = new System.Windows.Forms.Label();
            this.quitGameBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.shopPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guildPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guildPurchaseQty)).BeginInit();
            this.guildBuySellTabControl.SuspendLayout();
            this.guildBuyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guildBuyDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Day";
            // 
            // dayNumLbl
            // 
            this.dayNumLbl.AutoSize = true;
            this.dayNumLbl.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNumLbl.ForeColor = System.Drawing.Color.White;
            this.dayNumLbl.Location = new System.Drawing.Point(44, 9);
            this.dayNumLbl.Name = "dayNumLbl";
            this.dayNumLbl.Size = new System.Drawing.Size(34, 43);
            this.dayNumLbl.TabIndex = 1;
            this.dayNumLbl.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Balance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Merchant Level:";
            // 
            // dayPeriodLbl
            // 
            this.dayPeriodLbl.AutoSize = true;
            this.dayPeriodLbl.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayPeriodLbl.ForeColor = System.Drawing.Color.Gold;
            this.dayPeriodLbl.Location = new System.Drawing.Point(84, 22);
            this.dayPeriodLbl.Name = "dayPeriodLbl";
            this.dayPeriodLbl.Size = new System.Drawing.Size(87, 25);
            this.dayPeriodLbl.TabIndex = 6;
            this.dayPeriodLbl.Text = "(Morning)";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.ForeColor = System.Drawing.Color.White;
            this.BalanceLabel.Location = new System.Drawing.Point(12, 192);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(49, 43);
            this.BalanceLabel.TabIndex = 7;
            this.BalanceLabel.Text = "$0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Current Debt";
            // 
            // openShopBtn
            // 
            this.openShopBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openShopBtn.BackgroundImage")));
            this.openShopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openShopBtn.ForeColor = System.Drawing.Color.Gold;
            this.openShopBtn.Location = new System.Drawing.Point(3, 3);
            this.openShopBtn.Name = "openShopBtn";
            this.openShopBtn.Size = new System.Drawing.Size(319, 544);
            this.openShopBtn.TabIndex = 9;
            this.openShopBtn.Text = "Open Shop";
            this.openShopBtn.UseVisualStyleBackColor = true;
            this.openShopBtn.Click += new System.EventHandler(this.openShop_Click);
            // 
            // buyFromGuild
            // 
            this.buyFromGuild.BackColor = System.Drawing.Color.Black;
            this.buyFromGuild.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buyFromGuild.BackgroundImage")));
            this.buyFromGuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyFromGuild.ForeColor = System.Drawing.Color.Gold;
            this.buyFromGuild.Location = new System.Drawing.Point(325, 3);
            this.buyFromGuild.Name = "buyFromGuild";
            this.buyFromGuild.Size = new System.Drawing.Size(321, 544);
            this.buyFromGuild.TabIndex = 10;
            this.buyFromGuild.Text = "Visit Merchant\'s Guild";
            this.buyFromGuild.UseVisualStyleBackColor = false;
            this.buyFromGuild.Click += new System.EventHandler(this.buyFromGuild_Click);
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            // 
            // shopPanel
            // 
            this.shopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shopPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shopPanel.BackgroundImage")));
            this.shopPanel.Controls.Add(this.retHomeBtn);
            this.shopPanel.Controls.Add(this.configDisplayBtn);
            this.shopPanel.Controls.Add(this.runOpenShopBtn);
            this.shopPanel.Enabled = false;
            this.shopPanel.Location = new System.Drawing.Point(201, 46);
            this.shopPanel.Name = "shopPanel";
            this.shopPanel.Size = new System.Drawing.Size(650, 500);
            this.shopPanel.TabIndex = 12;
            this.shopPanel.Visible = false;
            // 
            // retHomeBtn
            // 
            this.retHomeBtn.Location = new System.Drawing.Point(491, 152);
            this.retHomeBtn.Name = "retHomeBtn";
            this.retHomeBtn.Size = new System.Drawing.Size(156, 50);
            this.retHomeBtn.TabIndex = 3;
            this.retHomeBtn.Text = "Return Home";
            this.retHomeBtn.UseVisualStyleBackColor = true;
            this.retHomeBtn.Click += new System.EventHandler(this.retHomeBtn_Click);
            // 
            // configDisplayBtn
            // 
            this.configDisplayBtn.Location = new System.Drawing.Point(491, 38);
            this.configDisplayBtn.Name = "configDisplayBtn";
            this.configDisplayBtn.Size = new System.Drawing.Size(156, 52);
            this.configDisplayBtn.TabIndex = 1;
            this.configDisplayBtn.Text = "Configure Display";
            this.configDisplayBtn.UseVisualStyleBackColor = true;
            this.configDisplayBtn.Click += new System.EventHandler(this.configDisplayBtn_Click);
            // 
            // runOpenShopBtn
            // 
            this.runOpenShopBtn.Location = new System.Drawing.Point(491, 96);
            this.runOpenShopBtn.Name = "runOpenShopBtn";
            this.runOpenShopBtn.Size = new System.Drawing.Size(156, 50);
            this.runOpenShopBtn.TabIndex = 0;
            this.runOpenShopBtn.Text = "Open Shop";
            this.runOpenShopBtn.UseVisualStyleBackColor = true;
            this.runOpenShopBtn.Click += new System.EventHandler(this.runOpenShopBtn_Click);
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homePanel.Controls.Add(this.openShopBtn);
            this.homePanel.Controls.Add(this.buyFromGuild);
            this.homePanel.Enabled = false;
            this.homePanel.Location = new System.Drawing.Point(240, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(650, 550);
            this.homePanel.TabIndex = 13;
            this.homePanel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(353, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 276);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // guildPanel
            // 
            this.guildPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guildPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guildPanel.BackgroundImage")));
            this.guildPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guildPanel.Controls.Add(this.label8);
            this.guildPanel.Controls.Add(this.guildPurchaseQty);
            this.guildPanel.Controls.Add(this.guildBuySellTabControl);
            this.guildPanel.Controls.Add(this.guildPanelBuy);
            this.guildPanel.Controls.Add(this.finishGuild);
            this.guildPanel.Controls.Add(this.pictureBox1);
            this.guildPanel.Enabled = false;
            this.guildPanel.Location = new System.Drawing.Point(232, 22);
            this.guildPanel.Name = "guildPanel";
            this.guildPanel.Size = new System.Drawing.Size(650, 550);
            this.guildPanel.TabIndex = 14;
            this.guildPanel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(42, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Qty";
            // 
            // guildPurchaseQty
            // 
            this.guildPurchaseQty.Location = new System.Drawing.Point(94, 463);
            this.guildPurchaseQty.Name = "guildPurchaseQty";
            this.guildPurchaseQty.Size = new System.Drawing.Size(120, 20);
            this.guildPurchaseQty.TabIndex = 6;
            // 
            // guildBuySellTabControl
            // 
            this.guildBuySellTabControl.Controls.Add(this.guildBuyTab);
            this.guildBuySellTabControl.Location = new System.Drawing.Point(231, 282);
            this.guildBuySellTabControl.Multiline = true;
            this.guildBuySellTabControl.Name = "guildBuySellTabControl";
            this.guildBuySellTabControl.SelectedIndex = 0;
            this.guildBuySellTabControl.Size = new System.Drawing.Size(419, 270);
            this.guildBuySellTabControl.TabIndex = 5;
            // 
            // guildBuyTab
            // 
            this.guildBuyTab.Controls.Add(this.guildBuyDGV);
            this.guildBuyTab.Location = new System.Drawing.Point(4, 22);
            this.guildBuyTab.Name = "guildBuyTab";
            this.guildBuyTab.Padding = new System.Windows.Forms.Padding(3);
            this.guildBuyTab.Size = new System.Drawing.Size(411, 244);
            this.guildBuyTab.TabIndex = 0;
            this.guildBuyTab.Text = "Buy";
            this.guildBuyTab.UseVisualStyleBackColor = true;
            // 
            // guildBuyDGV
            // 
            this.guildBuyDGV.AllowUserToAddRows = false;
            this.guildBuyDGV.AllowUserToDeleteRows = false;
            this.guildBuyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guildBuyDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guildBuyDGV.Location = new System.Drawing.Point(3, 3);
            this.guildBuyDGV.Name = "guildBuyDGV";
            this.guildBuyDGV.ReadOnly = true;
            this.guildBuyDGV.Size = new System.Drawing.Size(405, 238);
            this.guildBuyDGV.TabIndex = 0;
            // 
            // guildPanelBuy
            // 
            this.guildPanelBuy.Location = new System.Drawing.Point(39, 410);
            this.guildPanelBuy.Name = "guildPanelBuy";
            this.guildPanelBuy.Size = new System.Drawing.Size(175, 49);
            this.guildPanelBuy.TabIndex = 3;
            this.guildPanelBuy.Text = "Buy Items";
            this.guildPanelBuy.UseVisualStyleBackColor = true;
            this.guildPanelBuy.Click += new System.EventHandler(this.guildPanelBuy_Click);
            // 
            // finishGuild
            // 
            this.finishGuild.Location = new System.Drawing.Point(42, 492);
            this.finishGuild.Name = "finishGuild";
            this.finishGuild.Size = new System.Drawing.Size(172, 46);
            this.finishGuild.TabIndex = 2;
            this.finishGuild.Text = "Finish";
            this.finishGuild.UseVisualStyleBackColor = true;
            this.finishGuild.Click += new System.EventHandler(this.finishGuild_Click);
            // 
            // debtAmountLbl
            // 
            this.debtAmountLbl.AutoSize = true;
            this.debtAmountLbl.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtAmountLbl.ForeColor = System.Drawing.Color.White;
            this.debtAmountLbl.Location = new System.Drawing.Point(12, 259);
            this.debtAmountLbl.Name = "debtAmountLbl";
            this.debtAmountLbl.Size = new System.Drawing.Size(49, 43);
            this.debtAmountLbl.TabIndex = 16;
            this.debtAmountLbl.Text = "$0";
            // 
            // merchantLevelLbl
            // 
            this.merchantLevelLbl.AutoSize = true;
            this.merchantLevelLbl.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.merchantLevelLbl.ForeColor = System.Drawing.Color.White;
            this.merchantLevelLbl.Location = new System.Drawing.Point(12, 136);
            this.merchantLevelLbl.Name = "merchantLevelLbl";
            this.merchantLevelLbl.Size = new System.Drawing.Size(34, 43);
            this.merchantLevelLbl.TabIndex = 17;
            this.merchantLevelLbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name:";
            // 
            // playerNameLbl
            // 
            this.playerNameLbl.AutoSize = true;
            this.playerNameLbl.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLbl.ForeColor = System.Drawing.Color.White;
            this.playerNameLbl.Location = new System.Drawing.Point(12, 69);
            this.playerNameLbl.Name = "playerNameLbl";
            this.playerNameLbl.Size = new System.Drawing.Size(101, 43);
            this.playerNameLbl.TabIndex = 20;
            this.playerNameLbl.Text = "(name)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Next Payment in:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Payment Amount:";
            // 
            // daysToPaymentLbl
            // 
            this.daysToPaymentLbl.AutoSize = true;
            this.daysToPaymentLbl.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysToPaymentLbl.ForeColor = System.Drawing.Color.White;
            this.daysToPaymentLbl.Location = new System.Drawing.Point(12, 316);
            this.daysToPaymentLbl.Name = "daysToPaymentLbl";
            this.daysToPaymentLbl.Size = new System.Drawing.Size(34, 43);
            this.daysToPaymentLbl.TabIndex = 23;
            this.daysToPaymentLbl.Text = "0";
            // 
            // paymentAmtLbl
            // 
            this.paymentAmtLbl.AutoSize = true;
            this.paymentAmtLbl.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentAmtLbl.ForeColor = System.Drawing.Color.White;
            this.paymentAmtLbl.Location = new System.Drawing.Point(12, 381);
            this.paymentAmtLbl.Name = "paymentAmtLbl";
            this.paymentAmtLbl.Size = new System.Drawing.Size(49, 43);
            this.paymentAmtLbl.TabIndex = 24;
            this.paymentAmtLbl.Text = "$0";
            // 
            // quitGameBtn
            // 
            this.quitGameBtn.Location = new System.Drawing.Point(15, 445);
            this.quitGameBtn.Name = "quitGameBtn";
            this.quitGameBtn.Size = new System.Drawing.Size(189, 55);
            this.quitGameBtn.TabIndex = 25;
            this.quitGameBtn.Text = "Quit Game";
            this.quitGameBtn.UseVisualStyleBackColor = true;
            this.quitGameBtn.Click += new System.EventHandler(this.quitGameBtn_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(890, 550);
            this.Controls.Add(this.shopPanel);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.quitGameBtn);
            this.Controls.Add(this.paymentAmtLbl);
            this.Controls.Add(this.daysToPaymentLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.playerNameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.merchantLevelLbl);
            this.Controls.Add(this.debtAmountLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.dayPeriodLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dayNumLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guildPanel);
            this.Name = "Game";
            this.Text = "Capitalism, Ho!";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.shopPanel.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guildPanel.ResumeLayout(false);
            this.guildPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guildPurchaseQty)).EndInit();
            this.guildBuySellTabControl.ResumeLayout(false);
            this.guildBuyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guildBuyDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dayNumLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dayPeriodLbl;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button openShopBtn;
        private System.Windows.Forms.Button buyFromGuild;
        private System.Data.DataSet ds;
        private System.Windows.Forms.Panel shopPanel;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel guildPanel;
        private System.Windows.Forms.TabControl guildBuySellTabControl;
        private System.Windows.Forms.Button guildPanelBuy;
        private System.Windows.Forms.Button finishGuild;
        private System.Windows.Forms.Label debtAmountLbl;
        private System.Windows.Forms.Label merchantLevelLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playerNameLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label daysToPaymentLbl;
        private System.Windows.Forms.Label paymentAmtLbl;
        private System.Windows.Forms.Button quitGameBtn;
        private System.Windows.Forms.TabPage guildBuyTab;
        private System.Windows.Forms.DataGridView guildBuyDGV;
        private System.Windows.Forms.NumericUpDown guildPurchaseQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button runOpenShopBtn;
        private System.Windows.Forms.Button configDisplayBtn;
        private System.Windows.Forms.Button retHomeBtn;
    }
}