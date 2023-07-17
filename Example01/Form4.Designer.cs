namespace Example01
{
    partial class Form4
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
            this.lbSox = new System.Windows.Forms.Label();
            this.lbSoy = new System.Windows.Forms.Label();
            this.lbKetqua = new System.Windows.Forms.Label();
            this.txtSox = new System.Windows.Forms.TextBox();
            this.txtSoy = new System.Windows.Forms.TextBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btnCộng = new System.Windows.Forms.Button();
            this.btnNhân = new System.Windows.Forms.Button();
            this.btnThoát = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSox
            // 
            this.lbSox.AutoSize = true;
            this.lbSox.Location = new System.Drawing.Point(43, 42);
            this.lbSox.Name = "lbSox";
            this.lbSox.Size = new System.Drawing.Size(35, 17);
            this.lbSox.TabIndex = 0;
            this.lbSox.Text = "So x";
            // 
            // lbSoy
            // 
            this.lbSoy.AutoSize = true;
            this.lbSoy.Location = new System.Drawing.Point(43, 95);
            this.lbSoy.Name = "lbSoy";
            this.lbSoy.Size = new System.Drawing.Size(36, 17);
            this.lbSoy.TabIndex = 1;
            this.lbSoy.Text = "So y";
            // 
            // lbKetqua
            // 
            this.lbKetqua.AutoSize = true;
            this.lbKetqua.Location = new System.Drawing.Point(43, 159);
            this.lbKetqua.Name = "lbKetqua";
            this.lbKetqua.Size = new System.Drawing.Size(57, 17);
            this.lbKetqua.TabIndex = 2;
            this.lbKetqua.Text = "Ket qua";
            // 
            // txtSox
            // 
            this.txtSox.Location = new System.Drawing.Point(206, 39);
            this.txtSox.Name = "txtSox";
            this.txtSox.Size = new System.Drawing.Size(246, 22);
            this.txtSox.TabIndex = 3;
            // 
            // txtSoy
            // 
            this.txtSoy.Location = new System.Drawing.Point(206, 92);
            this.txtSoy.Name = "txtSoy";
            this.txtSoy.Size = new System.Drawing.Size(246, 22);
            this.txtSoy.TabIndex = 4;
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(206, 159);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(246, 22);
            this.txtKetqua.TabIndex = 5;
            // 
            // btnCộng
            // 
            this.btnCộng.Location = new System.Drawing.Point(65, 294);
            this.btnCộng.Name = "btnCộng";
            this.btnCộng.Size = new System.Drawing.Size(89, 33);
            this.btnCộng.TabIndex = 6;
            this.btnCộng.Text = "Cộng";
            this.btnCộng.UseVisualStyleBackColor = true;
            this.btnCộng.Click += new System.EventHandler(this.btnCộng_Click);
            // 
            // btnNhân
            // 
            this.btnNhân.Location = new System.Drawing.Point(262, 294);
            this.btnNhân.Name = "btnNhân";
            this.btnNhân.Size = new System.Drawing.Size(75, 23);
            this.btnNhân.TabIndex = 7;
            this.btnNhân.Text = "Nhân";
            this.btnNhân.UseVisualStyleBackColor = true;
            // 
            // btnThoát
            // 
            this.btnThoát.Location = new System.Drawing.Point(451, 294);
            this.btnThoát.Name = "btnThoát";
            this.btnThoát.Size = new System.Drawing.Size(75, 23);
            this.btnThoát.TabIndex = 8;
            this.btnThoát.Text = "Thoát";
            this.btnThoát.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 436);
            this.Controls.Add(this.btnThoát);
            this.Controls.Add(this.btnNhân);
            this.Controls.Add(this.btnCộng);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.txtSoy);
            this.Controls.Add(this.txtSox);
            this.Controls.Add(this.lbKetqua);
            this.Controls.Add(this.lbSoy);
            this.Controls.Add(this.lbSox);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSox;
        private System.Windows.Forms.Label lbSoy;
        private System.Windows.Forms.Label lbKetqua;
        private System.Windows.Forms.TextBox txtSox;
        private System.Windows.Forms.TextBox txtSoy;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button btnCộng;
        private System.Windows.Forms.Button btnNhân;
        private System.Windows.Forms.Button btnThoát;
    }
}