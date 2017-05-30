namespace CapHo
{
    partial class HaggleSell
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
            this.makeOfferBtn = new System.Windows.Forms.Button();
            this.offerPrice = new System.Windows.Forms.NumericUpDown();
            this.itemName = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.itemType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itemDescription = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.basePriceLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.offerPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // makeOfferBtn
            // 
            this.makeOfferBtn.Location = new System.Drawing.Point(402, 38);
            this.makeOfferBtn.Name = "makeOfferBtn";
            this.makeOfferBtn.Size = new System.Drawing.Size(75, 23);
            this.makeOfferBtn.TabIndex = 0;
            this.makeOfferBtn.Text = "Make Offer";
            this.makeOfferBtn.UseVisualStyleBackColor = true;
            this.makeOfferBtn.Click += new System.EventHandler(this.makeOfferBtn_Click);
            // 
            // offerPrice
            // 
            this.offerPrice.Location = new System.Drawing.Point(357, 12);
            this.offerPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.offerPrice.Name = "offerPrice";
            this.offerPrice.Size = new System.Drawing.Size(120, 20);
            this.offerPrice.TabIndex = 1;
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.ForeColor = System.Drawing.Color.Gold;
            this.itemName.Location = new System.Drawing.Point(89, 50);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(98, 25);
            this.itemName.TabIndex = 2;
            this.itemName.Text = "(item name)";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.ForeColor = System.Drawing.Color.Transparent;
            this.customerName.Location = new System.Drawing.Point(88, 0);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(167, 33);
            this.customerName.TabIndex = 3;
            this.customerName.Text = "(customer name)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price:";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.BackColor = System.Drawing.Color.Tan;
            this.message.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.Black;
            this.message.Location = new System.Drawing.Point(10, 167);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(80, 25);
            this.message.TabIndex = 7;
            this.message.Text = "(message)";
            // 
            // itemType
            // 
            this.itemType.AutoSize = true;
            this.itemType.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemType.ForeColor = System.Drawing.Color.Gold;
            this.itemType.Location = new System.Drawing.Point(205, 50);
            this.itemType.Name = "itemType";
            this.itemType.Size = new System.Drawing.Size(88, 29);
            this.itemType.TabIndex = 8;
            this.itemType.Text = "(item type)";
            this.itemType.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Base price:";
            // 
            // itemDescription
            // 
            this.itemDescription.AutoSize = true;
            this.itemDescription.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDescription.ForeColor = System.Drawing.Color.Gold;
            this.itemDescription.Location = new System.Drawing.Point(86, 81);
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.Size = new System.Drawing.Size(101, 29);
            this.itemDescription.TabIndex = 11;
            this.itemDescription.Text = "(description)";
            this.itemDescription.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description:";
            // 
            // basePriceLbl
            // 
            this.basePriceLbl.AutoSize = true;
            this.basePriceLbl.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basePriceLbl.ForeColor = System.Drawing.Color.Gold;
            this.basePriceLbl.Location = new System.Drawing.Point(91, 119);
            this.basePriceLbl.Name = "basePriceLbl";
            this.basePriceLbl.Size = new System.Drawing.Size(93, 25);
            this.basePriceLbl.TabIndex = 13;
            this.basePriceLbl.Text = "(base price)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Tan;
            this.pictureBox1.Location = new System.Drawing.Point(0, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 148);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // HaggleSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(489, 304);
            this.Controls.Add(this.basePriceLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.itemType);
            this.Controls.Add(this.message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.offerPrice);
            this.Controls.Add(this.makeOfferBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HaggleSell";
            this.Text = "HaggleSell";
            this.Load += new System.EventHandler(this.HaggleSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.offerPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeOfferBtn;
        private System.Windows.Forms.NumericUpDown offerPrice;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label itemType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label itemDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label basePriceLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}