
namespace PDI.CursoCSharp.WindowsFornsApp
{
    partial class FFormularioInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFormularioInicial));
            this.LBLNomeFornecedor = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.LBLEndereco = new System.Windows.Forms.Label();
            this.txtNomeForn = new System.Windows.Forms.TextBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLNomeFornecedor
            // 
            resources.ApplyResources(this.LBLNomeFornecedor, "LBLNomeFornecedor");
            this.LBLNomeFornecedor.Name = "LBLNomeFornecedor";
            this.LBLNomeFornecedor.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEndereco
            // 
            resources.ApplyResources(this.txtEndereco, "txtEndereco");
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LBLEndereco
            // 
            resources.ApplyResources(this.LBLEndereco, "LBLEndereco");
            this.LBLEndereco.Name = "LBLEndereco";
            this.LBLEndereco.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtNomeForn
            // 
            resources.ApplyResources(this.txtNomeForn, "txtNomeForn");
            this.txtNomeForn.Name = "txtNomeForn";
            // 
            // lblContato
            // 
            resources.ApplyResources(this.lblContato, "lblContato");
            this.lblContato.Name = "lblContato";
            // 
            // txtNomeContato
            // 
            resources.ApplyResources(this.txtNomeContato, "txtNomeContato");
            this.txtNomeContato.Name = "txtNomeContato";
            // 
            // lblTelefone
            // 
            resources.ApplyResources(this.lblTelefone, "lblTelefone");
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtTelefone
            // 
            resources.ApplyResources(this.txtTelefone, "txtTelefone");
            this.txtTelefone.Name = "txtTelefone";
            // 
            // btnSalvar
            // 
            resources.ApplyResources(this.btnSalvar, "btnSalvar");
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvFornecedores, "dgvFornecedores");
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.RowTemplate.Height = 33;
            // 
            // FFormularioInicial
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvFornecedores);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtNomeContato);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.txtNomeForn);
            this.Controls.Add(this.LBLEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.LBLNomeFornecedor);
            this.Name = "FFormularioInicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNomeFornecedor;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label LBLEndereco;
        private System.Windows.Forms.TextBox txtNomeForn;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txtNomeContato;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvFornecedores;
    }
}

