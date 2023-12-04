namespace PetShop
{
    partial class Servicos
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
            this.dgvPorte = new System.Windows.Forms.DataGridView();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.btnFiinalizar = new System.Windows.Forms.Button();
            this.lblValoor = new System.Windows.Forms.Label();
            this.txbNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPorte
            // 
            this.dgvPorte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPorte.Location = new System.Drawing.Point(12, 37);
            this.dgvPorte.Name = "dgvPorte";
            this.dgvPorte.Size = new System.Drawing.Size(481, 92);
            this.dgvPorte.TabIndex = 0;
            this.dgvPorte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPorte_CellClick);
            // 
            // dgvServico
            // 
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Location = new System.Drawing.Point(12, 169);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.Size = new System.Drawing.Size(481, 92);
            this.dgvServico.TabIndex = 1;
            this.dgvServico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServico_CellClick);
            // 
            // btnFiinalizar
            // 
            this.btnFiinalizar.Location = new System.Drawing.Point(12, 325);
            this.btnFiinalizar.Name = "btnFiinalizar";
            this.btnFiinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFiinalizar.TabIndex = 2;
            this.btnFiinalizar.Text = "Finalizar";
            this.btnFiinalizar.UseVisualStyleBackColor = true;
            this.btnFiinalizar.Click += new System.EventHandler(this.btnFiinalizar_Click);
            // 
            // lblValoor
            // 
            this.lblValoor.AutoSize = true;
            this.lblValoor.Location = new System.Drawing.Point(13, 287);
            this.lblValoor.Name = "lblValoor";
            this.lblValoor.Size = new System.Drawing.Size(0, 13);
            this.lblValoor.TabIndex = 3;
            // 
            // txbNomeCliente
            // 
            this.txbNomeCliente.Location = new System.Drawing.Point(142, 8);
            this.txbNomeCliente.Name = "txbNomeCliente";
            this.txbNomeCliente.Size = new System.Drawing.Size(100, 20);
            this.txbNomeCliente.TabIndex = 4;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(12, 11);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(124, 13);
            this.lblNomeCliente.TabIndex = 5;
            this.lblNomeCliente.Text = "Digite o nome do cliente:";
            // 
            // Servicos
            // 
            this.ClientSize = new System.Drawing.Size(505, 385);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.txbNomeCliente);
            this.Controls.Add(this.lblValoor);
            this.Controls.Add(this.btnFiinalizar);
            this.Controls.Add(this.dgvServico);
            this.Controls.Add(this.dgvPorte);
            this.Name = "Servicos";
            this.Text = "Servico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPorte;
        private System.Windows.Forms.RadioButton rdbGrande;
        private System.Windows.Forms.RadioButton rdbMedio;
        private System.Windows.Forms.RadioButton rdbPequeno;
        private System.Windows.Forms.GroupBox grbServico;
        private System.Windows.Forms.RadioButton rdbCombo;
        private System.Windows.Forms.RadioButton rdbTosa;
        private System.Windows.Forms.RadioButton rdbBanho;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridView dgvPorte;
        private System.Windows.Forms.DataGridView dgvServico;
        private System.Windows.Forms.Button btnFiinalizar;
        private System.Windows.Forms.Label lblValoor;
        private System.Windows.Forms.TextBox txbNomeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
    }
}