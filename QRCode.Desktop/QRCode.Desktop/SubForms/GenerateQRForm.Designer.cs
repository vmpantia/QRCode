namespace QRCodeReader.Desktop.SubForms
{
    partial class GenerateQRForm
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
            this.txtQRContent = new System.Windows.Forms.TextBox();
            this.btnGenerateQR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "QR Content:";
            // 
            // txtQRContent
            // 
            this.txtQRContent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQRContent.Location = new System.Drawing.Point(12, 42);
            this.txtQRContent.Multiline = true;
            this.txtQRContent.Name = "txtQRContent";
            this.txtQRContent.Size = new System.Drawing.Size(374, 86);
            this.txtQRContent.TabIndex = 1;
            // 
            // btnGenerateQR
            // 
            this.btnGenerateQR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateQR.Location = new System.Drawing.Point(12, 142);
            this.btnGenerateQR.Name = "btnGenerateQR";
            this.btnGenerateQR.Size = new System.Drawing.Size(374, 32);
            this.btnGenerateQR.TabIndex = 2;
            this.btnGenerateQR.Text = "Generate QR";
            this.btnGenerateQR.UseVisualStyleBackColor = true;
            this.btnGenerateQR.Click += new System.EventHandler(this.btnGenerateQR_Click);
            // 
            // GenerateQRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 186);
            this.Controls.Add(this.btnGenerateQR);
            this.Controls.Add(this.txtQRContent);
            this.Controls.Add(this.label1);
            this.Name = "GenerateQRForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateQRForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQRContent;
        private System.Windows.Forms.Button btnGenerateQR;
    }
}