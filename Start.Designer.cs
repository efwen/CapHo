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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.Title = new System.Windows.Forms.Label();
            this.SubTitle = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.DBEditButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Monotype Corsiva", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Silver;
            this.Title.Location = new System.Drawing.Point(-2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(585, 117);
            this.Title.TabIndex = 21;
            this.Title.Text = "Capitalism, Ho!";
            // 
            // SubTitle
            // 
            this.SubTitle.AutoSize = true;
            this.SubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTitle.Location = new System.Drawing.Point(12, 117);
            this.SubTitle.Name = "SubTitle";
            this.SubTitle.Size = new System.Drawing.Size(392, 33);
            this.SubTitle.TabIndex = 22;
            this.SubTitle.Text = "Justin Baker, Nick Carpenetti";
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Firebrick;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(329, 241);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(409, 170);
            this.PlayButton.TabIndex = 23;
            this.PlayButton.Text = "Play!";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // DBEditButton
            // 
            this.DBEditButton.BackColor = System.Drawing.Color.Firebrick;
            this.DBEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBEditButton.Location = new System.Drawing.Point(329, 417);
            this.DBEditButton.Name = "DBEditButton";
            this.DBEditButton.Size = new System.Drawing.Size(409, 170);
            this.DBEditButton.TabIndex = 24;
            this.DBEditButton.Text = "Edit Database";
            this.DBEditButton.UseVisualStyleBackColor = false;
            this.DBEditButton.Click += new System.EventHandler(this.DBEditButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 402);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 33);
            this.label1.TabIndex = 26;
            this.label1.Text = "Brian Lorton, Chris Luong";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(750, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DBEditButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.SubTitle);
            this.Controls.Add(this.Title);
            this.Name = "Start";
            this.Text = "Capitalism, Ho!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label SubTitle;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button DBEditButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

