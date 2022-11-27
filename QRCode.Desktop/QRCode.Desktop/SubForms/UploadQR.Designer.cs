namespace QRCodeReader.Desktop.SubForms
{
    partial class UploadQR
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
            this.picQR = new System.Windows.Forms.PictureBox();
            this.btnUploadQR = new System.Windows.Forms.Button();
            this.txtQRContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // picQR
            // 
            this.picQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQR.Location = new System.Drawing.Point(12, 12);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(338, 338);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQR.TabIndex = 0;
            this.picQR.TabStop = false;
            // 
            // btnUploadQR
            // 
            this.btnUploadQR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadQR.Location = new System.Drawing.Point(12, 364);
            this.btnUploadQR.Name = "btnUploadQR";
            this.btnUploadQR.Size = new System.Drawing.Size(338, 36);
            this.btnUploadQR.TabIndex = 1;
            this.btnUploadQR.Text = "Upload QR";
            this.btnUploadQR.UseVisualStyleBackColor = true;
            this.btnUploadQR.Click += new System.EventHandler(this.btnUploadQR_Click);
            // 
            // txtQRContent
            // 
            this.txtQRContent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQRContent.Location = new System.Drawing.Point(12, 442);
            this.txtQRContent.Multiline = true;
            this.txtQRContent.Name = "txtQRContent";
            this.txtQRContent.ReadOnly = true;
            this.txtQRContent.Size = new System.Drawing.Size(338, 89);
            this.txtQRContent.TabIndex = 0;
            this.txtQRContent.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "QR Content:";
            // 
            // UploadQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQRContent);
            this.Controls.Add(this.btnUploadQR);
            this.Controls.Add(this.picQR);
            this.Name = "UploadQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload QR";
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Button btnUploadQR;
        private System.Windows.Forms.TextBox txtQRContent;
        private System.Windows.Forms.Label label1;
    }
}