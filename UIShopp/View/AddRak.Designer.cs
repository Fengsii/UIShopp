namespace UIShopp.View
{
    partial class AddRak
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
            this.btnAddRak = new System.Windows.Forms.Button();
            this.btnCancelRak = new System.Windows.Forms.Button();
            this.txtAddNamaRak = new System.Windows.Forms.TextBox();
            this.txtAddIDRak = new System.Windows.Forms.TextBox();
            this.lblNamaRak = new System.Windows.Forms.Label();
            this.lblIdKoleksi = new System.Windows.Forms.Label();
            this.lblAddKoleksi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddRak
            // 
            this.btnAddRak.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddRak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRak.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRak.ForeColor = System.Drawing.Color.White;
            this.btnAddRak.Location = new System.Drawing.Point(349, 410);
            this.btnAddRak.Name = "btnAddRak";
            this.btnAddRak.Size = new System.Drawing.Size(129, 40);
            this.btnAddRak.TabIndex = 16;
            this.btnAddRak.Text = "Add";
            this.btnAddRak.UseVisualStyleBackColor = true;
            this.btnAddRak.Click += new System.EventHandler(this.btnAddKoleksi_Click);
            // 
            // btnCancelRak
            // 
            this.btnCancelRak.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelRak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelRak.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelRak.ForeColor = System.Drawing.Color.White;
            this.btnCancelRak.Location = new System.Drawing.Point(76, 410);
            this.btnCancelRak.Name = "btnCancelRak";
            this.btnCancelRak.Size = new System.Drawing.Size(129, 40);
            this.btnCancelRak.TabIndex = 15;
            this.btnCancelRak.Text = "Cancel";
            this.btnCancelRak.UseVisualStyleBackColor = true;
            this.btnCancelRak.Click += new System.EventHandler(this.btnCancelRak_Click);
            // 
            // txtAddNamaRak
            // 
            this.txtAddNamaRak.Location = new System.Drawing.Point(264, 260);
            this.txtAddNamaRak.Multiline = true;
            this.txtAddNamaRak.Name = "txtAddNamaRak";
            this.txtAddNamaRak.Size = new System.Drawing.Size(214, 33);
            this.txtAddNamaRak.TabIndex = 14;
            // 
            // txtAddIDRak
            // 
            this.txtAddIDRak.Location = new System.Drawing.Point(264, 168);
            this.txtAddIDRak.Multiline = true;
            this.txtAddIDRak.Name = "txtAddIDRak";
            this.txtAddIDRak.Size = new System.Drawing.Size(214, 33);
            this.txtAddIDRak.TabIndex = 13;
            // 
            // lblNamaRak
            // 
            this.lblNamaRak.AutoSize = true;
            this.lblNamaRak.Font = new System.Drawing.Font("Bernard MT Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaRak.ForeColor = System.Drawing.Color.White;
            this.lblNamaRak.Location = new System.Drawing.Point(71, 260);
            this.lblNamaRak.Name = "lblNamaRak";
            this.lblNamaRak.Size = new System.Drawing.Size(128, 26);
            this.lblNamaRak.TabIndex = 12;
            this.lblNamaRak.Text = "Nama Koleksi";
            // 
            // lblIdKoleksi
            // 
            this.lblIdKoleksi.AutoSize = true;
            this.lblIdKoleksi.Font = new System.Drawing.Font("Bernard MT Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdKoleksi.ForeColor = System.Drawing.Color.White;
            this.lblIdKoleksi.Location = new System.Drawing.Point(71, 175);
            this.lblIdKoleksi.Name = "lblIdKoleksi";
            this.lblIdKoleksi.Size = new System.Drawing.Size(69, 26);
            this.lblIdKoleksi.TabIndex = 11;
            this.lblIdKoleksi.Text = "ID Rak";
            // 
            // lblAddKoleksi
            // 
            this.lblAddKoleksi.AutoSize = true;
            this.lblAddKoleksi.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddKoleksi.ForeColor = System.Drawing.Color.White;
            this.lblAddKoleksi.Location = new System.Drawing.Point(208, 52);
            this.lblAddKoleksi.Name = "lblAddKoleksi";
            this.lblAddKoleksi.Size = new System.Drawing.Size(133, 33);
            this.lblAddKoleksi.TabIndex = 10;
            this.lblAddKoleksi.Text = "ADD RAK";
            // 
            // AddRak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(545, 503);
            this.Controls.Add(this.btnAddRak);
            this.Controls.Add(this.btnCancelRak);
            this.Controls.Add(this.txtAddNamaRak);
            this.Controls.Add(this.txtAddIDRak);
            this.Controls.Add(this.lblNamaRak);
            this.Controls.Add(this.lblIdKoleksi);
            this.Controls.Add(this.lblAddKoleksi);
            this.Name = "AddRak";
            this.Text = "AddRak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRak;
        private System.Windows.Forms.Button btnCancelRak;
        public System.Windows.Forms.TextBox txtAddNamaRak;
        public System.Windows.Forms.TextBox txtAddIDRak;
        private System.Windows.Forms.Label lblNamaRak;
        private System.Windows.Forms.Label lblIdKoleksi;
        private System.Windows.Forms.Label lblAddKoleksi;
    }
}