namespace PetShop.Views
{
    partial class ListarServicos
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
            this.dgvListaServico = new System.Windows.Forms.DataGridView();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txbVendas = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaServico
            // 
            this.dgvListaServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaServico.Location = new System.Drawing.Point(12, 12);
            this.dgvListaServico.Name = "dgvListaServico";
            this.dgvListaServico.Size = new System.Drawing.Size(776, 270);
            this.dgvListaServico.TabIndex = 0;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(9, 322);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(149, 16);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "Quantidade de Vendas:";
            // 
            // txbVendas
            // 
            this.txbVendas.Enabled = false;
            this.txbVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVendas.Location = new System.Drawing.Point(164, 319);
            this.txbVendas.Name = "txbVendas";
            this.txbVendas.Size = new System.Drawing.Size(55, 22);
            this.txbVendas.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PetShop.Properties.Resources._4459443;
            this.pictureBox1.Location = new System.Drawing.Point(473, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ListarServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbVendas);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.dgvListaServico);
            this.Name = "ListarServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarServicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaServico;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txbVendas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}