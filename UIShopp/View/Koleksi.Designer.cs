namespace UIShopp.View
{
    partial class Koleksi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pndDSKoleksi = new System.Windows.Forms.Panel();
            this.pnlKoleksiJud = new System.Windows.Forms.Panel();
            this.dgvKoleksi = new System.Windows.Forms.DataGridView();
            this.lblDataKoleksi = new System.Windows.Forms.Label();
            this.pnlInfoKoleksi = new System.Windows.Forms.Panel();
            this.txtDelete1 = new System.Windows.Forms.TextBox();
            this.txtDelete2 = new System.Windows.Forms.TextBox();
            this.btnAddKoleksi = new System.Windows.Forms.Button();
            this.btnUpdateKoleksi = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pndDSKoleksi.SuspendLayout();
            this.pnlKoleksiJud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKoleksi)).BeginInit();
            this.pnlInfoKoleksi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pndDSKoleksi
            // 
            this.pndDSKoleksi.BackColor = System.Drawing.Color.White;
            this.pndDSKoleksi.Controls.Add(this.dgvKoleksi);
            this.pndDSKoleksi.Controls.Add(this.pnlKoleksiJud);
            this.pndDSKoleksi.Location = new System.Drawing.Point(21, 22);
            this.pndDSKoleksi.Name = "pndDSKoleksi";
            this.pndDSKoleksi.Size = new System.Drawing.Size(937, 351);
            this.pndDSKoleksi.TabIndex = 0;
            // 
            // pnlKoleksiJud
            // 
            this.pnlKoleksiJud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.pnlKoleksiJud.Controls.Add(this.lblDataKoleksi);
            this.pnlKoleksiJud.Location = new System.Drawing.Point(22, 15);
            this.pnlKoleksiJud.Name = "pnlKoleksiJud";
            this.pnlKoleksiJud.Size = new System.Drawing.Size(897, 36);
            this.pnlKoleksiJud.TabIndex = 0;
            // 
            // dgvKoleksi
            // 
            this.dgvKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKoleksi.Location = new System.Drawing.Point(22, 57);
            this.dgvKoleksi.Name = "dgvKoleksi";
            this.dgvKoleksi.RowHeadersWidth = 62;
            this.dgvKoleksi.RowTemplate.Height = 28;
            this.dgvKoleksi.Size = new System.Drawing.Size(897, 279);
            this.dgvKoleksi.TabIndex = 1;
            this.dgvKoleksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKoleksi_CellClick);
            // 
            // lblDataKoleksi
            // 
            this.lblDataKoleksi.AutoSize = true;
            this.lblDataKoleksi.Font = new System.Drawing.Font("Elephant", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataKoleksi.ForeColor = System.Drawing.Color.White;
            this.lblDataKoleksi.Location = new System.Drawing.Point(374, 8);
            this.lblDataKoleksi.Name = "lblDataKoleksi";
            this.lblDataKoleksi.Size = new System.Drawing.Size(158, 21);
            this.lblDataKoleksi.TabIndex = 2;
            this.lblDataKoleksi.Text = "DATA KOLEKSI";
            // 
            // pnlInfoKoleksi
            // 
            this.pnlInfoKoleksi.BackColor = System.Drawing.Color.White;
            this.pnlInfoKoleksi.Controls.Add(this.btnClear);
            this.pnlInfoKoleksi.Controls.Add(this.btnDelete);
            this.pnlInfoKoleksi.Controls.Add(this.btnUpdateKoleksi);
            this.pnlInfoKoleksi.Controls.Add(this.btnAddKoleksi);
            this.pnlInfoKoleksi.Controls.Add(this.txtDelete2);
            this.pnlInfoKoleksi.Controls.Add(this.txtDelete1);
            this.pnlInfoKoleksi.Location = new System.Drawing.Point(21, 393);
            this.pnlInfoKoleksi.Name = "pnlInfoKoleksi";
            this.pnlInfoKoleksi.Size = new System.Drawing.Size(939, 243);
            this.pnlInfoKoleksi.TabIndex = 3;
            // 
            // txtDelete1
            // 
            this.txtDelete1.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDelete1.Location = new System.Drawing.Point(221, 49);
            this.txtDelete1.Multiline = true;
            this.txtDelete1.Name = "txtDelete1";
            this.txtDelete1.Size = new System.Drawing.Size(207, 32);
            this.txtDelete1.TabIndex = 0;
            // 
            // txtDelete2
            // 
            this.txtDelete2.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDelete2.Location = new System.Drawing.Point(505, 49);
            this.txtDelete2.Multiline = true;
            this.txtDelete2.Name = "txtDelete2";
            this.txtDelete2.Size = new System.Drawing.Size(207, 32);
            this.txtDelete2.TabIndex = 1;
            // 
            // btnAddKoleksi
            // 
            this.btnAddKoleksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnAddKoleksi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKoleksi.ForeColor = System.Drawing.Color.White;
            this.btnAddKoleksi.Location = new System.Drawing.Point(113, 166);
            this.btnAddKoleksi.Name = "btnAddKoleksi";
            this.btnAddKoleksi.Size = new System.Drawing.Size(120, 50);
            this.btnAddKoleksi.TabIndex = 2;
            this.btnAddKoleksi.Text = "ADD";
            this.btnAddKoleksi.UseVisualStyleBackColor = false;
            this.btnAddKoleksi.Click += new System.EventHandler(this.btnAddKoleksi_Click);
            // 
            // btnUpdateKoleksi
            // 
            this.btnUpdateKoleksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnUpdateKoleksi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateKoleksi.ForeColor = System.Drawing.Color.White;
            this.btnUpdateKoleksi.Location = new System.Drawing.Point(308, 166);
            this.btnUpdateKoleksi.Name = "btnUpdateKoleksi";
            this.btnUpdateKoleksi.Size = new System.Drawing.Size(120, 50);
            this.btnUpdateKoleksi.TabIndex = 3;
            this.btnUpdateKoleksi.Text = "UPDATE";
            this.btnUpdateKoleksi.UseVisualStyleBackColor = false;
            this.btnUpdateKoleksi.Click += new System.EventHandler(this.btnUpdateKoleksi_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(505, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 50);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(701, 166);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 50);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Koleksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlInfoKoleksi);
            this.Controls.Add(this.pndDSKoleksi);
            this.Name = "Koleksi";
            this.Size = new System.Drawing.Size(975, 662);
            this.Load += new System.EventHandler(this.Koleksi_Load);
            this.pndDSKoleksi.ResumeLayout(false);
            this.pnlKoleksiJud.ResumeLayout(false);
            this.pnlKoleksiJud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKoleksi)).EndInit();
            this.pnlInfoKoleksi.ResumeLayout(false);
            this.pnlInfoKoleksi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pndDSKoleksi;
        private System.Windows.Forms.Panel pnlKoleksiJud;
        private System.Windows.Forms.DataGridView dgvKoleksi;
        private System.Windows.Forms.Label lblDataKoleksi;
        private System.Windows.Forms.Panel pnlInfoKoleksi;
        private System.Windows.Forms.TextBox txtDelete1;
        private System.Windows.Forms.Button btnAddKoleksi;
        private System.Windows.Forms.TextBox txtDelete2;
        private System.Windows.Forms.Button btnUpdateKoleksi;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
    }
}
