namespace SilvanoPRODUCAO2
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
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.cbxPais = new System.Windows.Forms.ComboBox();
            this.lstForn = new System.Windows.Forms.ListBox();
            this.lblIntervalo = new System.Windows.Forms.Label();
            this.lblAte = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnContarProd = new System.Windows.Forms.Button();
            this.btnPart2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(12, 25);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(121, 20);
            this.txtCidade.TabIndex = 0;
            this.txtCidade.TextChanged += new System.EventHandler(this.txtCidade_TextChanged);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(12, 9);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(50, 13);
            this.lblCidade.TabIndex = 1;
            this.lblCidade.Text = "lblCidade";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(12, 48);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(37, 13);
            this.lblPais.TabIndex = 2;
            this.lblPais.Text = "lblPais";
            // 
            // cbxPais
            // 
            this.cbxPais.FormattingEnabled = true;
            this.cbxPais.Location = new System.Drawing.Point(12, 64);
            this.cbxPais.Name = "cbxPais";
            this.cbxPais.Size = new System.Drawing.Size(121, 21);
            this.cbxPais.TabIndex = 3;
            this.cbxPais.SelectedIndexChanged += new System.EventHandler(this.cbxPais_SelectedIndexChanged);
            // 
            // lstForn
            // 
            this.lstForn.FormattingEnabled = true;
            this.lstForn.Location = new System.Drawing.Point(154, 16);
            this.lstForn.Name = "lstForn";
            this.lstForn.Size = new System.Drawing.Size(269, 69);
            this.lstForn.TabIndex = 4;
            // 
            // lblIntervalo
            // 
            this.lblIntervalo.AutoSize = true;
            this.lblIntervalo.Location = new System.Drawing.Point(127, 118);
            this.lblIntervalo.Name = "lblIntervalo";
            this.lblIntervalo.Size = new System.Drawing.Size(58, 13);
            this.lblIntervalo.TabIndex = 5;
            this.lblIntervalo.Text = "lblIntervalo";
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(159, 148);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(33, 13);
            this.lblAte.TabIndex = 6;
            this.lblAte.Text = "lblAte";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(101, 145);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(47, 20);
            this.txtMin.TabIndex = 7;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(193, 145);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(47, 20);
            this.txtMax.TabIndex = 8;
            // 
            // btnContarProd
            // 
            this.btnContarProd.Location = new System.Drawing.Point(130, 171);
            this.btnContarProd.Name = "btnContarProd";
            this.btnContarProd.Size = new System.Drawing.Size(75, 23);
            this.btnContarProd.TabIndex = 9;
            this.btnContarProd.Text = "button1";
            this.btnContarProd.UseVisualStyleBackColor = true;
            this.btnContarProd.Click += new System.EventHandler(this.btnContarProd_Click);
            // 
            // btnPart2
            // 
            this.btnPart2.Location = new System.Drawing.Point(348, 171);
            this.btnPart2.Name = "btnPart2";
            this.btnPart2.Size = new System.Drawing.Size(75, 23);
            this.btnPart2.TabIndex = 10;
            this.btnPart2.Text = "button1";
            this.btnPart2.UseVisualStyleBackColor = true;
            this.btnPart2.Click += new System.EventHandler(this.btnPart2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 199);
            this.Controls.Add(this.btnPart2);
            this.Controls.Add(this.btnContarProd);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lblAte);
            this.Controls.Add(this.lblIntervalo);
            this.Controls.Add(this.lstForn);
            this.Controls.Add(this.cbxPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtCidade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cbxPais;
        private System.Windows.Forms.ListBox lstForn;
        private System.Windows.Forms.Label lblIntervalo;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnContarProd;
        private System.Windows.Forms.Button btnPart2;
    }
}

