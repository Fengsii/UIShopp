namespace UIShopp.View
{
    partial class AddKoleksi
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
            this.lblAddRak = new System.Windows.Forms.Label();
            this.lblIdKoleksi = new System.Windows.Forms.Label();
            this.lblNamaKoleksi = new System.Windows.Forms.Label();
            this.txtAddIDKoleksi = new System.Windows.Forms.TextBox();
            this.txtAddNamaKoleksi = new System.Windows.Forms.TextBox();
            this.btnCancelKoleksi = new System.Windows.Forms.Button();
            this.btnAddKoleksi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddRak
            // 
            this.lblAddRak.AutoSize = true;
            this.lblAddRak.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRak.ForeColor = System.Drawing.Color.White;
            this.lblAddRak.Location = new System.Drawing.Point(199, 48);
            this.lblAddRak.Name = "lblAddRak";
            this.lblAddRak.Size = new System.Drawing.Size(193, 33);
            this.lblAddRak.TabIndex = 2;
            this.lblAddRak.Text = "ADD KOLEKSI";
            // 
            // lblIdKoleksi
            // 
            this.lblIdKoleksi.AutoSize = true;
            this.lblIdKoleksi.Font = new System.Drawing.Font("Bernard MT Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdKoleksi.ForeColor = System.Drawing.Color.White;
            this.lblIdKoleksi.Location = new System.Drawing.Point(73, 174);
            this.lblIdKoleksi.Name = "lblIdKoleksi";
            this.lblIdKoleksi.Size = new System.Drawing.Size(98, 26);
            this.lblIdKoleksi.TabIndex = 3;
            this.lblIdKoleksi.Text = "ID Koleksi";
            // 
            // lblNamaKoleksi
            // 
            this.lblNamaKoleksi.AutoSize = true;
            this.lblNamaKoleksi.Font = new System.Drawing.Font("Bernard MT Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaKoleksi.ForeColor = System.Drawing.Color.White;
            this.lblNamaKoleksi.Location = new System.Drawing.Point(73, 259);
            this.lblNamaKoleksi.Name = "lblNamaKoleksi";
            this.lblNamaKoleksi.Size = new System.Drawing.Size(128, 26);
            this.lblNamaKoleksi.TabIndex = 5;
            this.lblNamaKoleksi.Text = "Nama Koleksi";
            // 
            // txtAddIDKoleksi
            // 
            this.txtAddIDKoleksi.Location = new System.Drawing.Point(266, 167);
            this.txtAddIDKoleksi.Multiline = true;
            this.txtAddIDKoleksi.Name = "txtAddIDKoleksi";
            this.txtAddIDKoleksi.Size = new System.Drawing.Size(214, 33);
            this.txtAddIDKoleksi.TabIndex = 6;
            // 
            // txtAddNamaKoleksi
            // 
            this.txtAddNamaKoleksi.Location = new System.Drawing.Point(266, 259);
            this.txtAddNamaKoleksi.Multiline = true;
            this.txtAddNamaKoleksi.Name = "txtAddNamaKoleksi";
            this.txtAddNamaKoleksi.Size = new System.Drawing.Size(214, 33);
            this.txtAddNamaKoleksi.TabIndex = 7;
            // 
            // btnCancelKoleksi
            // 
            this.btnCancelKoleksi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelKoleksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelKoleksi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelKoleksi.ForeColor = System.Drawing.Color.White;
            this.btnCancelKoleksi.Location = new System.Drawing.Point(78, 409);
            this.btnCancelKoleksi.Name = "btnCancelKoleksi";
            this.btnCancelKoleksi.Size = new System.Drawing.Size(129, 40);
            this.btnCancelKoleksi.TabIndex = 8;
            this.btnCancelKoleksi.Text = "Cancel";
            this.btnCancelKoleksi.UseVisualStyleBackColor = true;
            this.btnCancelKoleksi.Click += new System.EventHandler(this.btnCancelKoleksi_Click);
            // 
            // btnAddKoleksi
            // 
            this.btnAddKoleksi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddKoleksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddKoleksi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKoleksi.ForeColor = System.Drawing.Color.White;
            this.btnAddKoleksi.Location = new System.Drawing.Point(351, 409);
            this.btnAddKoleksi.Name = "btnAddKoleksi";
            this.btnAddKoleksi.Size = new System.Drawing.Size(129, 40);
            this.btnAddKoleksi.TabIndex = 9;
            this.btnAddKoleksi.Text = "Add";
            this.btnAddKoleksi.UseVisualStyleBackColor = true;
            this.btnAddKoleksi.Click += new System.EventHandler(this.btnAddKoleksi_Click);
            // 
            // AddKoleksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(545, 503);
            this.Controls.Add(this.btnAddKoleksi);
            this.Controls.Add(this.btnCancelKoleksi);
            this.Controls.Add(this.txtAddNamaKoleksi);
            this.Controls.Add(this.txtAddIDKoleksi);
            this.Controls.Add(this.lblNamaKoleksi);
            this.Controls.Add(this.lblIdKoleksi);
            this.Controls.Add(this.lblAddRak);
            this.Name = "AddKoleksi";
            this.Text = "AddKoleksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddRak;
        private System.Windows.Forms.Label lblIdKoleksi;
        private System.Windows.Forms.Label lblNamaKoleksi;
        private System.Windows.Forms.Button btnCancelKoleksi;
        private System.Windows.Forms.Button btnAddKoleksi;
        public System.Windows.Forms.TextBox txtAddIDKoleksi;
        public System.Windows.Forms.TextBox txtAddNamaKoleksi;
    }
}