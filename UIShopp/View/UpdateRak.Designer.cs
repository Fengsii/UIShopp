namespace UIShopp.View
{
    partial class UpdateRak
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
            this.btnUpdateRak = new System.Windows.Forms.Button();
            this.btnCancelRak = new System.Windows.Forms.Button();
            this.txtUpdateNamaRak = new System.Windows.Forms.TextBox();
            this.txtUpdateIDRak = new System.Windows.Forms.TextBox();
            this.lblUpdateNamaRak = new System.Windows.Forms.Label();
            this.lblUpdateIDKoleksi = new System.Windows.Forms.Label();
            this.lblUpdateRak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateRak
            // 
            this.btnUpdateRak.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdateRak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRak.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRak.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRak.Location = new System.Drawing.Point(347, 412);
            this.btnUpdateRak.Name = "btnUpdateRak";
            this.btnUpdateRak.Size = new System.Drawing.Size(129, 40);
            this.btnUpdateRak.TabIndex = 23;
            this.btnUpdateRak.Text = "Update";
            this.btnUpdateRak.UseVisualStyleBackColor = true;
            this.btnUpdateRak.Click += new System.EventHandler(this.btnUpdateRak_Click);
            // 
            // btnCancelRak
            // 
            this.btnCancelRak.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelRak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelRak.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelRak.ForeColor = System.Drawing.Color.White;
            this.btnCancelRak.Location = new System.Drawing.Point(74, 412);
            this.btnCancelRak.Name = "btnCancelRak";
            this.btnCancelRak.Size = new System.Drawing.Size(129, 40);
            this.btnCancelRak.TabIndex = 22;
            this.btnCancelRak.Text = "Cancel";
            this.btnCancelRak.UseVisualStyleBackColor = true;
            this.btnCancelRak.Click += new System.EventHandler(this.btnCancelRak_Click);
            // 
            // txtUpdateNamaRak
            // 
            this.txtUpdateNamaRak.Location = new System.Drawing.Point(262, 262);
            this.txtUpdateNamaRak.Multiline = true;
            this.txtUpdateNamaRak.Name = "txtUpdateNamaRak";
            this.txtUpdateNamaRak.Size = new System.Drawing.Size(214, 33);
            this.txtUpdateNamaRak.TabIndex = 21;
            // 
            // txtUpdateIDRak
            // 
            this.txtUpdateIDRak.Location = new System.Drawing.Point(262, 170);
            this.txtUpdateIDRak.Multiline = true;
            this.txtUpdateIDRak.Name = "txtUpdateIDRak";
            this.txtUpdateIDRak.Size = new System.Drawing.Size(214, 33);
            this.txtUpdateIDRak.TabIndex = 20;
            // 
            // lblUpdateNamaRak
            // 
            this.lblUpdateNamaRak.AutoSize = true;
            this.lblUpdateNamaRak.Font = new System.Drawing.Font("Bernard MT Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateNamaRak.ForeColor = System.Drawing.Color.White;
            this.lblUpdateNamaRak.Location = new System.Drawing.Point(69, 262);
            this.lblUpdateNamaRak.Name = "lblUpdateNamaRak";
            this.lblUpdateNamaRak.Size = new System.Drawing.Size(99, 26);
            this.lblUpdateNamaRak.TabIndex = 19;
            this.lblUpdateNamaRak.Text = "Nama Rak";
            // 
            // lblUpdateIDKoleksi
            // 
            this.lblUpdateIDKoleksi.AutoSize = true;
            this.lblUpdateIDKoleksi.Font = new System.Drawing.Font("Bernard MT Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateIDKoleksi.ForeColor = System.Drawing.Color.White;
            this.lblUpdateIDKoleksi.Location = new System.Drawing.Point(69, 177);
            this.lblUpdateIDKoleksi.Name = "lblUpdateIDKoleksi";
            this.lblUpdateIDKoleksi.Size = new System.Drawing.Size(69, 26);
            this.lblUpdateIDKoleksi.TabIndex = 18;
            this.lblUpdateIDKoleksi.Text = "ID Rak";
            // 
            // lblUpdateRak
            // 
            this.lblUpdateRak.AutoSize = true;
            this.lblUpdateRak.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateRak.ForeColor = System.Drawing.Color.White;
            this.lblUpdateRak.Location = new System.Drawing.Point(181, 51);
            this.lblUpdateRak.Name = "lblUpdateRak";
            this.lblUpdateRak.Size = new System.Drawing.Size(185, 33);
            this.lblUpdateRak.TabIndex = 17;
            this.lblUpdateRak.Text = "UPDATE RAK";
            // 
            // UpdateRak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(545, 503);
            this.Controls.Add(this.btnUpdateRak);
            this.Controls.Add(this.btnCancelRak);
            this.Controls.Add(this.txtUpdateNamaRak);
            this.Controls.Add(this.txtUpdateIDRak);
            this.Controls.Add(this.lblUpdateNamaRak);
            this.Controls.Add(this.lblUpdateIDKoleksi);
            this.Controls.Add(this.lblUpdateRak);
            this.Name = "UpdateRak";
            this.Text = "UpdateRak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateRak;
        private System.Windows.Forms.Button btnCancelRak;
        public System.Windows.Forms.TextBox txtUpdateNamaRak;
        public System.Windows.Forms.TextBox txtUpdateIDRak;
        private System.Windows.Forms.Label lblUpdateNamaRak;
        private System.Windows.Forms.Label lblUpdateIDKoleksi;
        private System.Windows.Forms.Label lblUpdateRak;
    }
}