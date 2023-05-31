namespace _20210130_minipauta
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
            this.dgvPauta = new System.Windows.Forms.DataGridView();
            this.btnRaparigas = new System.Windows.Forms.Button();
            this.btnRapazes = new System.Windows.Forms.Button();
            this.btnMaiorSexo = new System.Windows.Forms.Button();
            this.btnMaisVelho = new System.Windows.Forms.Button();
            this.btnReprov12 = new System.Windows.Forms.Button();
            this.btn3Melhores = new System.Windows.Forms.Button();
            this.btnApelRep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPauta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPauta
            // 
            this.dgvPauta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPauta.Location = new System.Drawing.Point(12, 12);
            this.dgvPauta.Name = "dgvPauta";
            this.dgvPauta.Size = new System.Drawing.Size(1095, 487);
            this.dgvPauta.TabIndex = 0;
            // 
            // btnRaparigas
            // 
            this.btnRaparigas.Location = new System.Drawing.Point(12, 505);
            this.btnRaparigas.Name = "btnRaparigas";
            this.btnRaparigas.Size = new System.Drawing.Size(140, 23);
            this.btnRaparigas.TabIndex = 1;
            this.btnRaparigas.Text = "button1";
            this.btnRaparigas.UseVisualStyleBackColor = true;
            this.btnRaparigas.Click += new System.EventHandler(this.btnRaparigas_Click);
            // 
            // btnRapazes
            // 
            this.btnRapazes.Location = new System.Drawing.Point(158, 505);
            this.btnRapazes.Name = "btnRapazes";
            this.btnRapazes.Size = new System.Drawing.Size(117, 23);
            this.btnRapazes.TabIndex = 2;
            this.btnRapazes.Text = "button2";
            this.btnRapazes.UseVisualStyleBackColor = true;
            this.btnRapazes.Click += new System.EventHandler(this.btnRapazes_Click);
            // 
            // btnMaiorSexo
            // 
            this.btnMaiorSexo.Location = new System.Drawing.Point(282, 504);
            this.btnMaiorSexo.Name = "btnMaiorSexo";
            this.btnMaiorSexo.Size = new System.Drawing.Size(210, 23);
            this.btnMaiorSexo.TabIndex = 3;
            this.btnMaiorSexo.Text = "button1";
            this.btnMaiorSexo.UseVisualStyleBackColor = true;
            this.btnMaiorSexo.Click += new System.EventHandler(this.btnMaiorSexo_Click);
            // 
            // btnMaisVelho
            // 
            this.btnMaisVelho.Location = new System.Drawing.Point(498, 504);
            this.btnMaisVelho.Name = "btnMaisVelho";
            this.btnMaisVelho.Size = new System.Drawing.Size(193, 23);
            this.btnMaisVelho.TabIndex = 4;
            this.btnMaisVelho.Text = "button1";
            this.btnMaisVelho.UseVisualStyleBackColor = true;
            this.btnMaisVelho.Click += new System.EventHandler(this.btnMaisVelho_Click);
            // 
            // btnReprov12
            // 
            this.btnReprov12.Location = new System.Drawing.Point(697, 505);
            this.btnReprov12.Name = "btnReprov12";
            this.btnReprov12.Size = new System.Drawing.Size(170, 23);
            this.btnReprov12.TabIndex = 5;
            this.btnReprov12.Text = "button1";
            this.btnReprov12.UseVisualStyleBackColor = true;
            this.btnReprov12.Click += new System.EventHandler(this.btnReprov12_Click);
            // 
            // btn3Melhores
            // 
            this.btn3Melhores.Location = new System.Drawing.Point(12, 535);
            this.btn3Melhores.Name = "btn3Melhores";
            this.btn3Melhores.Size = new System.Drawing.Size(140, 23);
            this.btn3Melhores.TabIndex = 6;
            this.btn3Melhores.Text = "button1";
            this.btn3Melhores.UseVisualStyleBackColor = true;
            this.btn3Melhores.Click += new System.EventHandler(this.btn3Melhores_Click);
            // 
            // btnApelRep
            // 
            this.btnApelRep.Location = new System.Drawing.Point(158, 534);
            this.btnApelRep.Name = "btnApelRep";
            this.btnApelRep.Size = new System.Drawing.Size(172, 23);
            this.btnApelRep.TabIndex = 7;
            this.btnApelRep.Text = "button1";
            this.btnApelRep.UseVisualStyleBackColor = true;
            this.btnApelRep.Click += new System.EventHandler(this.btnApelRep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 608);
            this.Controls.Add(this.btnApelRep);
            this.Controls.Add(this.btn3Melhores);
            this.Controls.Add(this.btnReprov12);
            this.Controls.Add(this.btnMaisVelho);
            this.Controls.Add(this.btnMaiorSexo);
            this.Controls.Add(this.btnRapazes);
            this.Controls.Add(this.btnRaparigas);
            this.Controls.Add(this.dgvPauta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPauta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPauta;
        private System.Windows.Forms.Button btnRaparigas;
        private System.Windows.Forms.Button btnRapazes;
        private System.Windows.Forms.Button btnMaiorSexo;
        private System.Windows.Forms.Button btnMaisVelho;
        private System.Windows.Forms.Button btnReprov12;
        private System.Windows.Forms.Button btn3Melhores;
        private System.Windows.Forms.Button btnApelRep;
    }
}

