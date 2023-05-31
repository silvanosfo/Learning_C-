namespace ProjCredDeb
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
            this.dgvMov = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lstNomes = new System.Windows.Forms.ListBox();
            this.lblAddMov = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cbxCredDeb = new System.Windows.Forms.ComboBox();
            this.txtCredDeb = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOVIMENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEntreDatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTAGENSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCLienteEntreDatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClienteMêsCorrenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balancetesváriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impressõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClientePeloNúmeroDeMêsEAnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balancetePorMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balancetePorIntervaloDeDatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTotCred = new System.Windows.Forms.TextBox();
            this.txtTotDeb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMov)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMov
            // 
            this.dgvMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMov.Location = new System.Drawing.Point(138, 27);
            this.dgvMov.Name = "dgvMov";
            this.dgvMov.Size = new System.Drawing.Size(816, 147);
            this.dgvMov.TabIndex = 0;
            this.dgvMov.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMov_KeyDown);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(120, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lstNomes
            // 
            this.lstNomes.FormattingEnabled = true;
            this.lstNomes.Location = new System.Drawing.Point(12, 51);
            this.lstNomes.Name = "lstNomes";
            this.lstNomes.Size = new System.Drawing.Size(120, 121);
            this.lstNomes.TabIndex = 2;
            this.lstNomes.SelectedIndexChanged += new System.EventHandler(this.lstNomes_SelectedIndexChanged);
            // 
            // lblAddMov
            // 
            this.lblAddMov.AutoSize = true;
            this.lblAddMov.Location = new System.Drawing.Point(12, 226);
            this.lblAddMov.Name = "lblAddMov";
            this.lblAddMov.Size = new System.Drawing.Size(35, 13);
            this.lblAddMov.TabIndex = 4;
            this.lblAddMov.Text = "label1";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(97, 247);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 13);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "label1";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(239, 247);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(35, 13);
            this.lblDesc.TabIndex = 6;
            this.lblDesc.Text = "label2";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(224, 269);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 7;
            // 
            // cbxCredDeb
            // 
            this.cbxCredDeb.FormattingEnabled = true;
            this.cbxCredDeb.Location = new System.Drawing.Point(330, 244);
            this.cbxCredDeb.Name = "cbxCredDeb";
            this.cbxCredDeb.Size = new System.Drawing.Size(100, 21);
            this.cbxCredDeb.TabIndex = 8;
            // 
            // txtCredDeb
            // 
            this.txtCredDeb.Location = new System.Drawing.Point(330, 269);
            this.txtCredDeb.Name = "txtCredDeb";
            this.txtCredDeb.Size = new System.Drawing.Size(100, 20);
            this.txtCredDeb.TabIndex = 9;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(436, 269);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "button1";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(12, 269);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(206, 20);
            this.dtpData.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cientesToolStripMenuItem,
            this.mOVIMENTOSToolStripMenuItem,
            this.lISTAGENSToolStripMenuItem,
            this.impressõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cientesToolStripMenuItem
            // 
            this.cientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.cientesToolStripMenuItem.Name = "cientesToolStripMenuItem";
            this.cientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cientesToolStripMenuItem.Text = "CLIENTES";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.inserirToolStripMenuItem.Text = "Inserir";
            this.inserirToolStripMenuItem.Click += new System.EventHandler(this.inserirToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // mOVIMENTOSToolStripMenuItem
            // 
            this.mOVIMENTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem1,
            this.listarToolStripMenuItem1,
            this.alterarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1,
            this.eliminarEntreDatasToolStripMenuItem});
            this.mOVIMENTOSToolStripMenuItem.Name = "mOVIMENTOSToolStripMenuItem";
            this.mOVIMENTOSToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.mOVIMENTOSToolStripMenuItem.Text = "MOVIMENTOS";
            // 
            // inserirToolStripMenuItem1
            // 
            this.inserirToolStripMenuItem1.Name = "inserirToolStripMenuItem1";
            this.inserirToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.inserirToolStripMenuItem1.Text = "Inserir";
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            // 
            // alterarToolStripMenuItem1
            // 
            this.alterarToolStripMenuItem1.Name = "alterarToolStripMenuItem1";
            this.alterarToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.alterarToolStripMenuItem1.Text = "Alterar";
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            // 
            // eliminarEntreDatasToolStripMenuItem
            // 
            this.eliminarEntreDatasToolStripMenuItem.Name = "eliminarEntreDatasToolStripMenuItem";
            this.eliminarEntreDatasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.eliminarEntreDatasToolStripMenuItem.Text = "Eliminar entre datas";
            // 
            // lISTAGENSToolStripMenuItem
            // 
            this.lISTAGENSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porClienteToolStripMenuItem,
            this.porCLienteEntreDatasToolStripMenuItem,
            this.porClienteMêsCorrenteToolStripMenuItem,
            this.balancetesváriosToolStripMenuItem});
            this.lISTAGENSToolStripMenuItem.Name = "lISTAGENSToolStripMenuItem";
            this.lISTAGENSToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.lISTAGENSToolStripMenuItem.Text = "LISTAGENS";
            // 
            // porClienteToolStripMenuItem
            // 
            this.porClienteToolStripMenuItem.Name = "porClienteToolStripMenuItem";
            this.porClienteToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.porClienteToolStripMenuItem.Text = "Por Cliente";
            // 
            // porCLienteEntreDatasToolStripMenuItem
            // 
            this.porCLienteEntreDatasToolStripMenuItem.Name = "porCLienteEntreDatasToolStripMenuItem";
            this.porCLienteEntreDatasToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.porCLienteEntreDatasToolStripMenuItem.Text = "Por Cliente entre datas";
            // 
            // porClienteMêsCorrenteToolStripMenuItem
            // 
            this.porClienteMêsCorrenteToolStripMenuItem.Name = "porClienteMêsCorrenteToolStripMenuItem";
            this.porClienteMêsCorrenteToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.porClienteMêsCorrenteToolStripMenuItem.Text = "Por Cliente, mês corrente";
            // 
            // balancetesváriosToolStripMenuItem
            // 
            this.balancetesváriosToolStripMenuItem.Name = "balancetesváriosToolStripMenuItem";
            this.balancetesváriosToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.balancetesváriosToolStripMenuItem.Text = "Balancetes (vários)";
            // 
            // impressõesToolStripMenuItem
            // 
            this.impressõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porClientePeloNúmeroDeMêsEAnoToolStripMenuItem,
            this.balancetePorMêsToolStripMenuItem,
            this.balancetePorIntervaloDeDatasToolStripMenuItem});
            this.impressõesToolStripMenuItem.Name = "impressõesToolStripMenuItem";
            this.impressõesToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.impressõesToolStripMenuItem.Text = "IMPRESSÕES";
            // 
            // porClientePeloNúmeroDeMêsEAnoToolStripMenuItem
            // 
            this.porClientePeloNúmeroDeMêsEAnoToolStripMenuItem.Name = "porClientePeloNúmeroDeMêsEAnoToolStripMenuItem";
            this.porClientePeloNúmeroDeMêsEAnoToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.porClientePeloNúmeroDeMêsEAnoToolStripMenuItem.Text = "Por Cliente, pelo número de mês e ano";
            // 
            // balancetePorMêsToolStripMenuItem
            // 
            this.balancetePorMêsToolStripMenuItem.Name = "balancetePorMêsToolStripMenuItem";
            this.balancetePorMêsToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.balancetePorMêsToolStripMenuItem.Text = "Balancete por mês";
            // 
            // balancetePorIntervaloDeDatasToolStripMenuItem
            // 
            this.balancetePorIntervaloDeDatasToolStripMenuItem.Name = "balancetePorIntervaloDeDatasToolStripMenuItem";
            this.balancetePorIntervaloDeDatasToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.balancetePorIntervaloDeDatasToolStripMenuItem.Text = "Balancete por intervalo de datas";
            // 
            // txtTotCred
            // 
            this.txtTotCred.Location = new System.Drawing.Point(519, 180);
            this.txtTotCred.Name = "txtTotCred";
            this.txtTotCred.Size = new System.Drawing.Size(80, 20);
            this.txtTotCred.TabIndex = 13;
            // 
            // txtTotDeb
            // 
            this.txtTotDeb.Location = new System.Drawing.Point(605, 180);
            this.txtTotDeb.Name = "txtTotDeb";
            this.txtTotDeb.Size = new System.Drawing.Size(75, 20);
            this.txtTotDeb.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 408);
            this.Controls.Add(this.txtTotDeb);
            this.Controls.Add(this.txtTotCred);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtCredDeb);
            this.Controls.Add(this.cbxCredDeb);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblAddMov);
            this.Controls.Add(this.lstNomes);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvMov);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMov)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMov;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListBox lstNomes;
        private System.Windows.Forms.Label lblAddMov;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.ComboBox cbxCredDeb;
        private System.Windows.Forms.TextBox txtCredDeb;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOVIMENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarEntreDatasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTAGENSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCLienteEntreDatasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porClienteMêsCorrenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balancetesváriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impressõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porClientePeloNúmeroDeMêsEAnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balancetePorMêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balancetePorIntervaloDeDatasToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTotCred;
        private System.Windows.Forms.TextBox txtTotDeb;
    }
}

