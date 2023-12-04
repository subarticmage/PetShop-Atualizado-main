namespace PetShop.Views
{
    partial class Caixa
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
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.chbPagamento = new System.Windows.Forms.CheckBox();
            this.ptbCaixa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServico
            // 
            this.dgvServico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Location = new System.Drawing.Point(12, 12);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.ReadOnly = true;
            this.dgvServico.Size = new System.Drawing.Size(816, 216);
            this.dgvServico.TabIndex = 0;
            this.dgvServico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgvServico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServico_CellContentClick);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(8, 264);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 20);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor";
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.Location = new System.Drawing.Point(12, 337);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(75, 32);
            this.btnEncerrar.TabIndex = 2;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // chbPagamento
            // 
            this.chbPagamento.AutoSize = true;
            this.chbPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPagamento.Location = new System.Drawing.Point(12, 309);
            this.chbPagamento.Name = "chbPagamento";
            this.chbPagamento.Size = new System.Drawing.Size(173, 22);
            this.chbPagamento.TabIndex = 3;
            this.chbPagamento.Text = "Pagamento Realizado";
            this.chbPagamento.UseVisualStyleBackColor = true;
            this.chbPagamento.CheckedChanged += new System.EventHandler(this.chbPagamento_CheckedChanged);
            // 
            // ptbCaixa
            // 
            this.ptbCaixa.Image = global::PetShop.Properties.Resources.caixa_2;
            this.ptbCaixa.Location = new System.Drawing.Point(593, 234);
            this.ptbCaixa.Name = "ptbCaixa";
            this.ptbCaixa.Size = new System.Drawing.Size(235, 135);
            this.ptbCaixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCaixa.TabIndex = 4;
            this.ptbCaixa.TabStop = false;
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 397);
            this.Controls.Add(this.ptbCaixa);
            this.Controls.Add(this.chbPagamento);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.dgvServico);
            this.Name = "Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServico;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.CheckBox chbPagamento;
        private System.Windows.Forms.PictureBox ptbCaixa;
    }
}