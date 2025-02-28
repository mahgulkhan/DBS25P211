namespace Task1
{
    partial class Form1
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
            this.header = new System.Windows.Forms.Label();
            this.header2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Old English Text MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.header.Location = new System.Drawing.Point(291, 65);
            this.header.MaximumSize = new System.Drawing.Size(900, 100);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(825, 44);
            this.header.TabIndex = 0;
            this.header.Text = "University of Engineering and Technology Lahore";
            // 
            // header2
            // 
            this.header2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.header2.AutoSize = true;
            this.header2.BackColor = System.Drawing.Color.CadetBlue;
            this.header2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.header2.Font = new System.Drawing.Font("Perpetua Titling MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.header2.Location = new System.Drawing.Point(471, 160);
            this.header2.MaximumSize = new System.Drawing.Size(600, 450);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(512, 46);
            this.header2.TabIndex = 1;
            this.header2.Text = "Faculty Management";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(607, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 82);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click to Proceed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Task1.Properties.Resources.Navy_large_retro_geometric_shape_wallpaper_mural;
            this.ClientSize = new System.Drawing.Size(1385, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.header2);
            this.Controls.Add(this.header);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label header2;
        private System.Windows.Forms.Button button1;
    }
}

