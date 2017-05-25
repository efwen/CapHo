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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dayPeriodLbl = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openShop = new System.Windows.Forms.Button();
            this.buyFromGuild = new System.Windows.Forms.Button();
            this.goToMarket = new System.Windows.Forms.Button();
            this.ds = new System.Data.DataSet();
            this.shopPanel = new System.Windows.Forms.Panel();
            this.marketPanel = new System.Windows.Forms.Panel();
            this.returnFromMarket = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.guildBuyDGV = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guildPanel = new System.Windows.Forms.Panel();
            this.guildBuySellTabControl = new System.Windows.Forms.TabControl();
            this.guildBuyTab = new System.Windows.Forms.TabPage();
            this.guildSellTab = new System.Windows.Forms.TabPage();
            this.guildSellDGV = new System.Windows.Forms.DataGridView();
            this.guildPanelSell = new System.Windows.Forms.Button();
            this.guildPanelBuy = new System.Windows.Forms.Button();
            this.finishGuild = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.merchantLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.marketPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guildBuyDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guildPanel.SuspendLayout();
            this.guildBuySellTabControl.SuspendLayout();
            this.guildBuyTab.SuspendLayout();
            this.guildSellTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guildSellDGV)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Balance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Days to next payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Merchant Level:";
            // 
            // dayPeriodLbl
            // 
            this.dayPeriodLbl.AutoSize = true;
            this.dayPeriodLbl.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BalanceLabel.Location = new System.Drawing.Point(12, 65);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(49, 43);
            this.BalanceLabel.TabIndex = 7;
            this.BalanceLabel.Text = "$0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Payment Amount:";
            // 
            // openShop
            // 
            this.openShop.Location = new System.Drawing.Point(23, 21);
            this.openShop.Name = "openShop";
            this.openShop.Size = new System.Drawing.Size(144, 57);
            this.openShop.TabIndex = 9;
            this.openShop.Text = "Open Shop";
            this.openShop.UseVisualStyleBackColor = true;
            this.openShop.Click += new System.EventHandler(this.openShop_Click);
            // 
            // buyFromGuild
            // 
            this.buyFromGuild.Location = new System.Drawing.Point(23, 84);
            this.buyFromGuild.Name = "buyFromGuild";
            this.buyFromGuild.Size = new System.Drawing.Size(144, 57);
            this.buyFromGuild.TabIndex = 10;
            this.buyFromGuild.Text = "Visit Merchant\'s Guild";
            this.buyFromGuild.UseVisualStyleBackColor = true;
            this.buyFromGuild.Click += new System.EventHandler(this.buyFromGuild_Click);
            // 
            // goToMarket
            // 
            this.goToMarket.Location = new System.Drawing.Point(23, 148);
            this.goToMarket.Name = "goToMarket";
            this.goToMarket.Size = new System.Drawing.Size(144, 57);
            this.goToMarket.TabIndex = 11;
            this.goToMarket.Text = "Go To Market";
            this.goToMarket.UseVisualStyleBackColor = true;
            this.goToMarket.Click += new System.EventHandler(this.goToMarket_Click);
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            // 
            // shopPanel
            // 
            this.shopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shopPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shopPanel.BackgroundImage")));
            this.shopPanel.Enabled = false;
            this.shopPanel.Location = new System.Drawing.Point(263, 5);
            this.shopPanel.Name = "shopPanel";
            this.shopPanel.Size = new System.Drawing.Size(618, 510);
            this.shopPanel.TabIndex = 12;
            this.shopPanel.Visible = false;
            // 
            // marketPanel
            // 
            this.marketPanel.BackColor = System.Drawing.Color.DimGray;
            this.marketPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("marketPanel.BackgroundImage")));
            this.marketPanel.Controls.Add(this.returnFromMarket);
            this.marketPanel.Enabled = false;
            this.marketPanel.Location = new System.Drawing.Point(224, 30);
            this.marketPanel.Name = "marketPanel";
            this.marketPanel.Size = new System.Drawing.Size(618, 513);
            this.marketPanel.TabIndex = 18;
            this.marketPanel.Visible = false;
            // 
            // returnFromMarket
            // 
            this.returnFromMarket.Location = new System.Drawing.Point(14, 11);
            this.returnFromMarket.Name = "returnFromMarket";
            this.returnFromMarket.Size = new System.Drawing.Size(172, 71);
            this.returnFromMarket.TabIndex = 0;
            this.returnFromMarket.Text = "Return Home";
            this.returnFromMarket.UseVisualStyleBackColor = true;
            this.returnFromMarket.Click += new System.EventHandler(this.returnFromMarket_Click);
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homePanel.Controls.Add(this.openShop);
            this.homePanel.Controls.Add(this.buyFromGuild);
            this.homePanel.Controls.Add(this.goToMarket);
            this.homePanel.Enabled = false;
            this.homePanel.Location = new System.Drawing.Point(201, 54);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(618, 510);
            this.homePanel.TabIndex = 13;
            this.homePanel.Visible = false;
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
            this.guildBuyDGV.Size = new System.Drawing.Size(409, 202);
            this.guildBuyDGV.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 3);
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
            this.guildPanel.Controls.Add(this.guildBuySellTabControl);
            this.guildPanel.Controls.Add(this.guildPanelSell);
            this.guildPanel.Controls.Add(this.guildPanelBuy);
            this.guildPanel.Controls.Add(this.finishGuild);
            this.guildPanel.Controls.Add(this.pictureBox1);
            this.guildPanel.Enabled = false;
            this.guildPanel.Location = new System.Drawing.Point(240, 12);
            this.guildPanel.Name = "guildPanel";
            this.guildPanel.Size = new System.Drawing.Size(618, 510);
            this.guildPanel.TabIndex = 14;
            this.guildPanel.Visible = false;
            // 
            // guildBuySellTabControl
            // 
            this.guildBuySellTabControl.Controls.Add(this.guildBuyTab);
            this.guildBuySellTabControl.Controls.Add(this.guildSellTab);
            this.guildBuySellTabControl.Location = new System.Drawing.Point(195, 276);
            this.guildBuySellTabControl.Multiline = true;
            this.guildBuySellTabControl.Name = "guildBuySellTabControl";
            this.guildBuySellTabControl.SelectedIndex = 0;
            this.guildBuySellTabControl.Size = new System.Drawing.Size(423, 234);
            this.guildBuySellTabControl.TabIndex = 5;
            // 
            // guildBuyTab
            // 
            this.guildBuyTab.Controls.Add(this.guildBuyDGV);
            this.guildBuyTab.Location = new System.Drawing.Point(4, 22);
            this.guildBuyTab.Name = "guildBuyTab";
            this.guildBuyTab.Padding = new System.Windows.Forms.Padding(3);
            this.guildBuyTab.Size = new System.Drawing.Size(415, 208);
            this.guildBuyTab.TabIndex = 0;
            this.guildBuyTab.Text = "Buy";
            this.guildBuyTab.UseVisualStyleBackColor = true;
            // 
            // guildSellTab
            // 
            this.guildSellTab.BackColor = System.Drawing.Color.Transparent;
            this.guildSellTab.Controls.Add(this.guildSellDGV);
            this.guildSellTab.Location = new System.Drawing.Point(4, 22);
            this.guildSellTab.Name = "guildSellTab";
            this.guildSellTab.Padding = new System.Windows.Forms.Padding(3);
            this.guildSellTab.Size = new System.Drawing.Size(415, 208);
            this.guildSellTab.TabIndex = 1;
            this.guildSellTab.Text = "Sell";
            // 
            // guildSellDGV
            // 
            this.guildSellDGV.AllowUserToAddRows = false;
            this.guildSellDGV.AllowUserToDeleteRows = false;
            this.guildSellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guildSellDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guildSellDGV.Location = new System.Drawing.Point(3, 3);
            this.guildSellDGV.Name = "guildSellDGV";
            this.guildSellDGV.ReadOnly = true;
            this.guildSellDGV.Size = new System.Drawing.Size(409, 202);
            this.guildSellDGV.TabIndex = 0;
            // 
            // guildPanelSell
            // 
            this.guildPanelSell.Location = new System.Drawing.Point(17, 384);
            this.guildPanelSell.Name = "guildPanelSell";
            this.guildPanelSell.Size = new System.Drawing.Size(172, 52);
            this.guildPanelSell.TabIndex = 4;
            this.guildPanelSell.Text = "Sell Items";
            this.guildPanelSell.UseVisualStyleBackColor = true;
            this.guildPanelSell.Click += new System.EventHandler(this.guildPanelSell_Click);
            // 
            // guildPanelBuy
            // 
            this.guildPanelBuy.Location = new System.Drawing.Point(14, 329);
            this.guildPanelBuy.Name = "guildPanelBuy";
            this.guildPanelBuy.Size = new System.Drawing.Size(175, 49);
            this.guildPanelBuy.TabIndex = 3;
            this.guildPanelBuy.Text = "Buy Items";
            this.guildPanelBuy.UseVisualStyleBackColor = true;
            this.guildPanelBuy.Click += new System.EventHandler(this.guildPanelBuy_Click);
            // 
            // finishGuild
            // 
            this.finishGuild.Location = new System.Drawing.Point(17, 442);
            this.finishGuild.Name = "finishGuild";
            this.finishGuild.Size = new System.Drawing.Size(172, 46);
            this.finishGuild.TabIndex = 2;
            this.finishGuild.Text = "Finish";
            this.finishGuild.UseVisualStyleBackColor = true;
            this.finishGuild.Click += new System.EventHandler(this.finishGuild_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 43);
            this.label2.TabIndex = 15;
            this.label2.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 43);
            this.label7.TabIndex = 16;
            this.label7.Text = "$0";
            // 
            // merchantLevel
            // 
            this.merchantLevel.AutoSize = true;
            this.merchantLevel.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.merchantLevel.ForeColor = System.Drawing.Color.White;
            this.merchantLevel.Location = new System.Drawing.Point(12, 248);
            this.merchantLevel.Name = "merchantLevel";
            this.merchantLevel.Size = new System.Drawing.Size(34, 43);
            this.merchantLevel.TabIndex = 17;
            this.merchantLevel.Text = "0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(870, 531);
            this.Controls.Add(this.marketPanel);
            this.Controls.Add(this.shopPanel);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.merchantLevel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guildPanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.dayPeriodLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dayNumLbl);
            this.Controls.Add(this.label1);
            this.Name = "Game";
            this.Text = "Capitalism, Ho!";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.marketPanel.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guildBuyDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guildPanel.ResumeLayout(false);
            this.guildBuySellTabControl.ResumeLayout(false);
            this.guildBuyTab.ResumeLayout(false);
            this.guildSellTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guildSellDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dayNumLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dayPeriodLbl;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button openShop;
        private System.Windows.Forms.Button buyFromGuild;
        private System.Windows.Forms.Button goToMarket;
        private System.Data.DataSet ds;
        private System.Windows.Forms.Panel shopPanel;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView guildBuyDGV;
        private System.Windows.Forms.Panel guildPanel;
        private System.Windows.Forms.TabControl guildBuySellTabControl;
        private System.Windows.Forms.TabPage guildBuyTab;
        private System.Windows.Forms.TabPage guildSellTab;
        private System.Windows.Forms.DataGridView guildSellDGV;
        private System.Windows.Forms.Button guildPanelSell;
        private System.Windows.Forms.Button guildPanelBuy;
        private System.Windows.Forms.Button finishGuild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label merchantLevel;
        private System.Windows.Forms.Button returnFromMarket;
        private System.Windows.Forms.Panel marketPanel;
    }
}