namespace _29_06_20_Proxy_design_pattern_WinForm
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
            this.btnImage = new System.Windows.Forms.Button();
            this.pbxDisplayImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisplayImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(23, 410);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(134, 23);
            this.btnImage.TabIndex = 0;
            this.btnImage.Text = "Pick up image to diaplay";
            this.btnImage.UseVisualStyleBackColor = true;
            // 
            // pbxDisplayImage
            // 
            this.pbxDisplayImage.Location = new System.Drawing.Point(13, 13);
            this.pbxDisplayImage.Name = "pbxDisplayImage";
            this.pbxDisplayImage.Size = new System.Drawing.Size(108, 93);
            this.pbxDisplayImage.TabIndex = 1;
            this.pbxDisplayImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.pbxDisplayImage);
            this.Controls.Add(this.btnImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisplayImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.PictureBox pbxDisplayImage;
    }
}

