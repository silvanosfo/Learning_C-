namespace SilvanoPRODUCAO2
{
    partial class FormParte2
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
            this.dgvProb3 = new System.Windows.Forms.DataGridView();
            this.chkIncDesc = new System.Windows.Forms.CheckBox();
            this.chkExistZero = new System.Windows.Forms.CheckBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.dgvProb4 = new System.Windows.Forms.DataGridView();
            this.lblProd = new System.Windows.Forms.Label();
            this.txtProdNotFound = new System.Windows.Forms.TextBox();
            this.btnProdProcurar = new System.Windows.Forms.Button();
            this.lstForn = new System.Windows.Forms.ListBox();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProb4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProb3
            // 
            this.dgvProb3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProb3.Location = new System.Drawing.Point(12, 35);
            this.dgvProb3.Name = "dgvProb3";
            this.dgvProb3.Size = new System.Drawing.Size(1042, 185);
            this.dgvProb3.TabIndex = 0;
            // 
            // chkIncDesc
            // 
            this.chkIncDesc.AutoSize = true;
            this.chkIncDesc.Location = new System.Drawing.Point(12, 12);
            this.chkIncDesc.Name = "chkIncDesc";
            this.chkIncDesc.Size = new System.Drawing.Size(80, 17);
            this.chkIncDesc.TabIndex = 1;
            this.chkIncDesc.Text = "checkBox1";
            this.chkIncDesc.UseVisualStyleBackColor = true;
            this.chkIncDesc.CheckedChanged += new System.EventHandler(this.chkIncDesc_CheckedChanged);
            // 
            // chkExistZero
            // 
            this.chkExistZero.AutoSize = true;
            this.chkExistZero.Location = new System.Drawing.Point(219, 12);
            this.chkExistZero.Name = "chkExistZero";
            this.chkExistZero.Size = new System.Drawing.Size(80, 17);
            this.chkExistZero.TabIndex = 2;
            this.chkExistZero.Text = "checkBox2";
            this.chkExistZero.UseVisualStyleBackColor = true;
            this.chkExistZero.CheckedChanged += new System.EventHandler(this.chkExistZero_CheckedChanged);
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(173, 231);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(118, 20);
            this.txtNomeProd.TabIndex = 3;
            // 
            // dgvProb4
            // 
            this.dgvProb4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProb4.Location = new System.Drawing.Point(12, 257);
            this.dgvProb4.Name = "dgvProb4";
            this.dgvProb4.Size = new System.Drawing.Size(1042, 181);
            this.dgvProb4.TabIndex = 4;
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Location = new System.Drawing.Point(12, 234);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(35, 13);
            this.lblProd.TabIndex = 5;
            this.lblProd.Text = "label1";
            // 
            // txtProdNotFound
            // 
            this.txtProdNotFound.Location = new System.Drawing.Point(491, 231);
            this.txtProdNotFound.Name = "txtProdNotFound";
            this.txtProdNotFound.Size = new System.Drawing.Size(178, 20);
            this.txtProdNotFound.TabIndex = 6;
            // 
            // btnProdProcurar
            // 
            this.btnProdProcurar.Location = new System.Drawing.Point(297, 229);
            this.btnProdProcurar.Name = "btnProdProcurar";
            this.btnProdProcurar.Size = new System.Drawing.Size(90, 23);
            this.btnProdProcurar.TabIndex = 7;
            this.btnProdProcurar.Text = "btnProdProcurar";
            this.btnProdProcurar.UseVisualStyleBackColor = true;
            this.btnProdProcurar.Click += new System.EventHandler(this.btnProdProcurar_Click);
            // 
            // lstForn
            // 
            this.lstForn.FormattingEnabled = true;
            this.lstForn.Location = new System.Drawing.Point(12, 454);
            this.lstForn.Name = "lstForn";
            this.lstForn.Size = new System.Drawing.Size(210, 238);
            this.lstForn.TabIndex = 8;
            this.lstForn.SelectedIndexChanged += new System.EventHandler(this.lstForn_SelectedIndexChanged);
            // 
            // lstProdutos
            // 
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.Location = new System.Drawing.Point(228, 454);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(238, 238);
            this.lstProdutos.TabIndex = 9;
            // 
            // FormParte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 713);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.lstForn);
            this.Controls.Add(this.btnProdProcurar);
            this.Controls.Add(this.txtProdNotFound);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.dgvProb4);
            this.Controls.Add(this.txtNomeProd);
            this.Controls.Add(this.chkExistZero);
            this.Controls.Add(this.chkIncDesc);
            this.Controls.Add(this.dgvProb3);
            this.Name = "FormParte2";
            this.Text = "FormParte2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProb4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProb3;
        private System.Windows.Forms.CheckBox chkIncDesc;
        private System.Windows.Forms.CheckBox chkExistZero;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.DataGridView dgvProb4;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.TextBox txtProdNotFound;
        private System.Windows.Forms.Button btnProdProcurar;
        private System.Windows.Forms.ListBox lstForn;
        private System.Windows.Forms.ListBox lstProdutos;
    }
}