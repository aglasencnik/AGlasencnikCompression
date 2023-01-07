namespace AGlasencnikCompression
{
    partial class MainForm
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
            this.btnOpenFileCompress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenFileDecompress = new System.Windows.Forms.Button();
            this.tbxCompress = new System.Windows.Forms.TextBox();
            this.tbxDecompress = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnDecompress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFileCompress
            // 
            this.btnOpenFileCompress.BackColor = System.Drawing.Color.Silver;
            this.btnOpenFileCompress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFileCompress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpenFileCompress.Location = new System.Drawing.Point(12, 59);
            this.btnOpenFileCompress.Name = "btnOpenFileCompress";
            this.btnOpenFileCompress.Size = new System.Drawing.Size(209, 85);
            this.btnOpenFileCompress.TabIndex = 0;
            this.btnOpenFileCompress.Text = "Odpri datoteko za stiskanje";
            this.btnOpenFileCompress.UseVisualStyleBackColor = false;
            this.btnOpenFileCompress.Click += new System.EventHandler(this.btnOpenFileCompress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Program za stiskanje datotek";
            // 
            // btnOpenFileDecompress
            // 
            this.btnOpenFileDecompress.BackColor = System.Drawing.Color.Silver;
            this.btnOpenFileDecompress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFileDecompress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpenFileDecompress.Location = new System.Drawing.Point(12, 163);
            this.btnOpenFileDecompress.Name = "btnOpenFileDecompress";
            this.btnOpenFileDecompress.Size = new System.Drawing.Size(209, 85);
            this.btnOpenFileDecompress.TabIndex = 2;
            this.btnOpenFileDecompress.Text = "Odpri datoteko za razširjanje";
            this.btnOpenFileDecompress.UseVisualStyleBackColor = false;
            this.btnOpenFileDecompress.Click += new System.EventHandler(this.btnOpenFileDecompress_Click);
            // 
            // tbxCompress
            // 
            this.tbxCompress.BackColor = System.Drawing.Color.LightGray;
            this.tbxCompress.Enabled = false;
            this.tbxCompress.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbxCompress.Location = new System.Drawing.Point(227, 77);
            this.tbxCompress.Name = "tbxCompress";
            this.tbxCompress.ReadOnly = true;
            this.tbxCompress.Size = new System.Drawing.Size(378, 43);
            this.tbxCompress.TabIndex = 3;
            // 
            // tbxDecompress
            // 
            this.tbxDecompress.BackColor = System.Drawing.Color.LightGray;
            this.tbxDecompress.Enabled = false;
            this.tbxDecompress.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbxDecompress.Location = new System.Drawing.Point(227, 181);
            this.tbxDecompress.Name = "tbxDecompress";
            this.tbxDecompress.ReadOnly = true;
            this.tbxDecompress.Size = new System.Drawing.Size(378, 43);
            this.tbxDecompress.TabIndex = 4;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 254);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(808, 34);
            this.progressBar.TabIndex = 5;
            // 
            // btnCompress
            // 
            this.btnCompress.BackColor = System.Drawing.Color.Silver;
            this.btnCompress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCompress.Location = new System.Drawing.Point(611, 59);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(209, 85);
            this.btnCompress.TabIndex = 6;
            this.btnCompress.Text = "Začni stiskanje";
            this.btnCompress.UseVisualStyleBackColor = false;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // btnDecompress
            // 
            this.btnDecompress.BackColor = System.Drawing.Color.Silver;
            this.btnDecompress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecompress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDecompress.Location = new System.Drawing.Point(611, 163);
            this.btnDecompress.Name = "btnDecompress";
            this.btnDecompress.Size = new System.Drawing.Size(209, 85);
            this.btnDecompress.TabIndex = 7;
            this.btnDecompress.Text = "Začni razširjanje";
            this.btnDecompress.UseVisualStyleBackColor = false;
            this.btnDecompress.Click += new System.EventHandler(this.btnDecompress_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(831, 300);
            this.Controls.Add(this.btnDecompress);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tbxDecompress);
            this.Controls.Add(this.tbxCompress);
            this.Controls.Add(this.btnOpenFileDecompress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenFileCompress);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program za stiskanje datotek";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFileCompress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenFileDecompress;
        private System.Windows.Forms.TextBox tbxCompress;
        private System.Windows.Forms.TextBox tbxDecompress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Button btnDecompress;
    }
}

