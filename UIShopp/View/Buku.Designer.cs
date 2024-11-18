namespace UIShopp.View
{
    partial class Buku
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
            this.pndDSBuku = new System.Windows.Forms.Panel();
            this.dgvBuku = new System.Windows.Forms.DataGridView();
            this.pnlBukuJud = new System.Windows.Forms.Panel();
            this.lblDataBuku = new System.Windows.Forms.Label();
            this.pnlInfoBuku = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateBuku = new System.Windows.Forms.Button();
            this.btnAddBuku = new System.Windows.Forms.Button();
            this.txtDelete2 = new System.Windows.Forms.TextBox();
            this.txtDelete1 = new System.Windows.Forms.TextBox();
            this.txtDelete3 = new System.Windows.Forms.TextBox();
            this.txtDelete5 = new System.Windows.Forms.TextBox();
            this.txtDelete6 = new System.Windows.Forms.TextBox();
            this.txtDelete7 = new System.Windows.Forms.TextBox();
            this.txtDelete4 = new System.Windows.Forms.TextBox();
            this.pndDSBuku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).BeginInit();
            this.pnlBukuJud.SuspendLayout();
            this.pnlInfoBuku.SuspendLayout();
            this.SuspendLayout();
            // 
            // pndDSBuku
            // 
            this.pndDSBuku.BackColor = System.Drawing.Color.White;
            this.pndDSBuku.Controls.Add(this.dgvBuku);
            this.pndDSBuku.Controls.Add(this.pnlBukuJud);
            this.pndDSBuku.Location = new System.Drawing.Point(21, 22);
            this.pndDSBuku.Name = "pndDSBuku";
            this.pndDSBuku.Size = new System.Drawing.Size(937, 351);
            this.pndDSBuku.TabIndex = 2;
            // 
            // dgvBuku
            // 
            this.dgvBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuku.Location = new System.Drawing.Point(22, 57);
            this.dgvBuku.Name = "dgvBuku";
            this.dgvBuku.RowHeadersWidth = 62;
            this.dgvBuku.RowTemplate.Height = 28;
            this.dgvBuku.Size = new System.Drawing.Size(897, 279);
            this.dgvBuku.TabIndex = 1;
            this.dgvBuku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuku_CellClick);
            // 
            // pnlBukuJud
            // 
            this.pnlBukuJud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.pnlBukuJud.Controls.Add(this.lblDataBuku);
            this.pnlBukuJud.Location = new System.Drawing.Point(22, 15);
            this.pnlBukuJud.Name = "pnlBukuJud";
            this.pnlBukuJud.Size = new System.Drawing.Size(897, 36);
            this.pnlBukuJud.TabIndex = 0;
            // 
            // lblDataBuku
            // 
            this.lblDataBuku.AutoSize = true;
            this.lblDataBuku.Font = new System.Drawing.Font("Elephant", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBuku.ForeColor = System.Drawing.Color.White;
            this.lblDataBuku.Location = new System.Drawing.Point(374, 8);
            this.lblDataBuku.Name = "lblDataBuku";
            this.lblDataBuku.Size = new System.Drawing.Size(123, 21);
            this.lblDataBuku.TabIndex = 2;
            this.lblDataBuku.Text = "DATA BUKU";
            // 
            // pnlInfoBuku
            // 
            this.pnlInfoBuku.BackColor = System.Drawing.Color.White;
            this.pnlInfoBuku.Controls.Add(this.txtDelete4);
            this.pnlInfoBuku.Controls.Add(this.txtDelete7);
            this.pnlInfoBuku.Controls.Add(this.txtDelete6);
            this.pnlInfoBuku.Controls.Add(this.txtDelete5);
            this.pnlInfoBuku.Controls.Add(this.txtDelete3);
            this.pnlInfoBuku.Controls.Add(this.btnClear);
            this.pnlInfoBuku.Controls.Add(this.btnDelete);
            this.pnlInfoBuku.Controls.Add(this.btnUpdateBuku);
            this.pnlInfoBuku.Controls.Add(this.btnAddBuku);
            this.pnlInfoBuku.Controls.Add(this.txtDelete2);
            this.pnlInfoBuku.Controls.Add(this.txtDelete1);
            this.pnlInfoBuku.Location = new System.Drawing.Point(21, 393);
            this.pnlInfoBuku.Name = "pnlInfoBuku";
            this.pnlInfoBuku.Size = new System.Drawing.Size(939, 243);
            this.pnlInfoBuku.TabIndex = 4;
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
            // btnUpdateBuku
            // 
            this.btnUpdateBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnUpdateBuku.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBuku.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBuku.Location = new System.Drawing.Point(308, 166);
            this.btnUpdateBuku.Name = "btnUpdateBuku";
            this.btnUpdateBuku.Size = new System.Drawing.Size(120, 50);
            this.btnUpdateBuku.TabIndex = 3;
            this.btnUpdateBuku.Text = "UPDATE";
            this.btnUpdateBuku.UseVisualStyleBackColor = false;
            this.btnUpdateBuku.Click += new System.EventHandler(this.btnUpdateBuku_Click);
            // 
            // btnAddBuku
            // 
            this.btnAddBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnAddBuku.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBuku.ForeColor = System.Drawing.Color.White;
            this.btnAddBuku.Location = new System.Drawing.Point(113, 166);
            this.btnAddBuku.Name = "btnAddBuku";
            this.btnAddBuku.Size = new System.Drawing.Size(120, 50);
            this.btnAddBuku.TabIndex = 2;
            this.btnAddBuku.Text = "ADD";
            this.btnAddBuku.UseVisualStyleBackColor = false;
            this.btnAddBuku.Click += new System.EventHandler(this.btnAddBuku_Click);
            // 
            // txtDelete2
            // 
            this.txtDelete2.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDelete2.Location = new System.Drawing.Point(295, 28);
            this.txtDelete2.Multiline = true;
            this.txtDelete2.Name = "txtDelete2";
            this.txtDelete2.Size = new System.Drawing.Size(123, 32);
            this.txtDelete2.TabIndex = 1;
            // 
            // txtDelete1
            // 
            this.txtDelete1.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDelete1.Location = new System.Drawing.Point(77, 28);
            this.txtDelete1.Multiline = true;
            this.txtDelete1.Name = "txtDelete1";
            this.txtDelete1.Size = new System.Drawing.Size(123, 32);
            this.txtDelete1.TabIndex = 0;
            // 
            // txtDelete3
            // 
            this.txtDelete3.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDelete3.Location = new System.Drawing.Point(528, 28);
            this.txtDelete3.Multiline = true;
            this.txtDelete3.Name = "txtDelete3";
            this.txtDelete3.Size = new System.Drawing.Size(123, 32);
            this.txtDelete3.TabIndex = 6;
            // 
            // txtDelete5
            // 
            this.txtDelete5.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDelete5.Location = new System.Drawing.Point(77, 82);
            this.txtDelete5.Multiline = true;
            this.txtDelete5.Name = "txtDelete5";
            this.txtDelete5.Size = new System.Drawing.Size(123, 32);
            this.txtDelete5.TabIndex = 7;
            // 
            // txtDelete6
            // 
            this.txtDelete6.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDelete6.Location = new System.Drawing.Point(295, 82);
            this.txtDelete6.Multiline = true;
            this.txtDelete6.Name = "txtDelete6";
            this.txtDelete6.Size = new System.Drawing.Size(123, 32);
            this.txtDelete6.TabIndex = 8;
            // 
            // txtDelete7
            // 
            this.txtDelete7.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDelete7.Location = new System.Drawing.Point(528, 82);
            this.txtDelete7.Multiline = true;
            this.txtDelete7.Name = "txtDelete7";
            this.txtDelete7.Size = new System.Drawing.Size(123, 32);
            this.txtDelete7.TabIndex = 9;
            // 
            // txtDelete4
            // 
            this.txtDelete4.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDelete4.Location = new System.Drawing.Point(730, 30);
            this.txtDelete4.Multiline = true;
            this.txtDelete4.Name = "txtDelete4";
            this.txtDelete4.Size = new System.Drawing.Size(123, 32);
            this.txtDelete4.TabIndex = 10;
            // 
            // Buku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlInfoBuku);
            this.Controls.Add(this.pndDSBuku);
            this.Name = "Buku";
            this.Size = new System.Drawing.Size(975, 662);
            this.Load += new System.EventHandler(this.Buku_Load);
            this.pndDSBuku.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).EndInit();
            this.pnlBukuJud.ResumeLayout(false);
            this.pnlBukuJud.PerformLayout();
            this.pnlInfoBuku.ResumeLayout(false);
            this.pnlInfoBuku.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pndDSBuku;
        private System.Windows.Forms.DataGridView dgvBuku;
        private System.Windows.Forms.Panel pnlBukuJud;
        private System.Windows.Forms.Label lblDataBuku;
        private System.Windows.Forms.Panel pnlInfoBuku;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateBuku;
        private System.Windows.Forms.Button btnAddBuku;
        private System.Windows.Forms.TextBox txtDelete2;
        private System.Windows.Forms.TextBox txtDelete1;
        private System.Windows.Forms.TextBox txtDelete6;
        private System.Windows.Forms.TextBox txtDelete5;
        private System.Windows.Forms.TextBox txtDelete3;
        private System.Windows.Forms.TextBox txtDelete4;
        private System.Windows.Forms.TextBox txtDelete7;
    }
}
