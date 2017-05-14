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
            this.Title = new System.Windows.Forms.Label();
            this.SubTitle = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.DBEditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(14, 9);
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
            this.DBEditButton.Click += new System.EventHandler(this.DBEditButton_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 565);
            this.Controls.Add(this.DBEditButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.SubTitle);
            this.Controls.Add(this.Title);
            this.Name = "Start";
            this.Text = "Capitalism, Ho!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label SubTitle;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button DBEditButton;
    }
}

