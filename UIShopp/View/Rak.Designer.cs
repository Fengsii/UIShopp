namespace UIShopp.View
{
    partial class Rak
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
            this.pndDSRak = new System.Windows.Forms.Panel();
            this.dgvRak = new System.Windows.Forms.DataGridView();
            this.pnlRakJud = new System.Windows.Forms.Panel();
            this.lblDataRak = new System.Windows.Forms.Label();
            this.pnlInfoRak = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateRak = new System.Windows.Forms.Button();
            this.btnAddRak = new System.Windows.Forms.Button();
            this.txtDelete2 = new System.Windows.Forms.TextBox();
            this.txtDelete1 = new System.Windows.Forms.TextBox();
            this.pndDSRak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRak)).BeginInit();
            this.pnlRakJud.SuspendLayout();
            this.pnlInfoRak.SuspendLayout();
            this.SuspendLayout();
            // 
            // pndDSRak
            // 
            this.pndDSRak.BackColor = System.Drawing.Color.White;
            this.pndDSRak.Controls.Add(this.dgvRak);
            this.pndDSRak.Controls.Add(this.pnlRakJud);
            this.pndDSRak.Location = new System.Drawing.Point(21, 22);
            this.pndDSRak.Name = "pndDSRak";
            this.pndDSRak.Size = new System.Drawing.Size(937, 351);
            this.pndDSRak.TabIndex = 1;
            // 
            // dgvRak
            // 
            this.dgvRak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRak.Location = new System.Drawing.Point(22, 57);
            this.dgvRak.Name = "dgvRak";
            this.dgvRak.RowHeadersWidth = 62;
            this.dgvRak.RowTemplate.Height = 28;
            this.dgvRak.Size = new System.Drawing.Size(897, 279);
            this.dgvRak.TabIndex = 1;
            this.dgvRak.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRak_CellClick);
            // 
            // pnlRakJud
            // 
            this.pnlRakJud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.pnlRakJud.Controls.Add(this.lblDataRak);
            this.pnlRakJud.Location = new System.Drawing.Point(22, 15);
            this.pnlRakJud.Name = "pnlRakJud";
            this.pnlRakJud.Size = new System.Drawing.Size(897, 36);
            this.pnlRakJud.TabIndex = 0;
            // 
            // lblDataRak
            // 
            this.lblDataRak.AutoSize = true;
            this.lblDataRak.Font = new System.Drawing.Font("Elephant", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataRak.ForeColor = System.Drawing.Color.White;
            this.lblDataRak.Location = new System.Drawing.Point(374, 8);
            this.lblDataRak.Name = "lblDataRak";
            this.lblDataRak.Size = new System.Drawing.Size(108, 21);
            this.lblDataRak.TabIndex = 2;
            this.lblDataRak.Text = "DATA RAK";
            // 
            // pnlInfoRak
            // 
            this.pnlInfoRak.BackColor = System.Drawing.Color.White;
            this.pnlInfoRak.Controls.Add(this.btnClear);
            this.pnlInfoRak.Controls.Add(this.btnDelete);
            this.pnlInfoRak.Controls.Add(this.btnUpdateRak);
            this.pnlInfoRak.Controls.Add(this.btnAddRak);
            this.pnlInfoRak.Controls.Add(this.txtDelete2);
            this.pnlInfoRak.Controls.Add(this.txtDelete1);
            this.pnlInfoRak.Location = new System.Drawing.Point(21, 393);
            this.pnlInfoRak.Name = "pnlInfoRak";
            this.pnlInfoRak.Size = new System.Drawing.Size(939, 243);
            this.pnlInfoRak.TabIndex = 4;
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
            // btnUpdateRak
            // 
            this.btnUpdateRak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnUpdateRak.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRak.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRak.Location = new System.Drawing.Point(308, 166);
            this.btnUpdateRak.Name = "btnUpdateRak";
            this.btnUpdateRak.Size = new System.Drawing.Size(120, 50);
            this.btnUpdateRak.TabIndex = 3;
            this.btnUpdateRak.Text = "UPDATE";
            this.btnUpdateRak.UseVisualStyleBackColor = false;
            this.btnUpdateRak.Click += new System.EventHandler(this.btnUpdateRak_Click);
            // 
            // btnAddRak
            // 
            this.btnAddRak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.btnAddRak.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRak.ForeColor = System.Drawing.Color.White;
            this.btnAddRak.Location = new System.Drawing.Point(113, 166);
            this.btnAddRak.Name = "btnAddRak";
            this.btnAddRak.Size = new System.Drawing.Size(120, 50);
            this.btnAddRak.TabIndex = 2;
            this.btnAddRak.Text = "ADD";
            this.btnAddRak.UseVisualStyleBackColor = false;
            this.btnAddRak.Click += new System.EventHandler(this.btnAddRak_Click);
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
            // txtDelete1
            // 
            this.txtDelete1.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDelete1.Location = new System.Drawing.Point(221, 49);
            this.txtDelete1.Multiline = true;
            this.txtDelete1.Name = "txtDelete1";
            this.txtDelete1.Size = new System.Drawing.Size(207, 32);
            this.txtDelete1.TabIndex = 0;
            // 
            // Rak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlInfoRak);
            this.Controls.Add(this.pndDSRak);
            this.Name = "Rak";
            this.Size = new System.Drawing.Size(975, 662);
            this.Load += new System.EventHandler(this.Rak_Load);
            this.pndDSRak.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRak)).EndInit();
            this.pnlRakJud.ResumeLayout(false);
            this.pnlRakJud.PerformLayout();
            this.pnlInfoRak.ResumeLayout(false);
            this.pnlInfoRak.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pndDSRak;
        private System.Windows.Forms.DataGridView dgvRak;
        private System.Windows.Forms.Panel pnlRakJud;
        private System.Windows.Forms.Label lblDataRak;
        private System.Windows.Forms.Panel pnlInfoRak;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateRak;
        private System.Windows.Forms.Button btnAddRak;
        private System.Windows.Forms.TextBox txtDelete2;
        private System.Windows.Forms.TextBox txtDelete1;
    }
}
