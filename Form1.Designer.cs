
namespace TugasTiga1
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
            this.lblDataDiri = new System.Windows.Forms.Label();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnKosongkan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDataDiri
            // 
            this.lblDataDiri.AutoSize = true;
            this.lblDataDiri.Location = new System.Drawing.Point(61, 51);
            this.lblDataDiri.Name = "lblDataDiri";
            this.lblDataDiri.Size = new System.Drawing.Size(51, 20);
            this.lblDataDiri.TabIndex = 0;
            this.lblDataDiri.Text = "label1";
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(65, 197);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(107, 32);
            this.btnTampilkan.TabIndex = 1;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnKosongkan
            // 
            this.btnKosongkan.Location = new System.Drawing.Point(193, 197);
            this.btnKosongkan.Name = "btnKosongkan";
            this.btnKosongkan.Size = new System.Drawing.Size(103, 32);
            this.btnKosongkan.TabIndex = 2;
            this.btnKosongkan.Text = "Kosongkan";
            this.btnKosongkan.UseVisualStyleBackColor = true;
            this.btnKosongkan.Click += new System.EventHandler(this.btnKosongkan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 274);
            this.Controls.Add(this.btnKosongkan);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.lblDataDiri);
            this.Name = "Form1";
            this.Text = "Tugas 3.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataDiri;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnKosongkan;
    }
}

