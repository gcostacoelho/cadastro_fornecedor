using PDI.CursoCSharp.WindowsFornsApp.src.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDI.CursoCSharp.WindowsFornsApp
{
    public partial class FFormularioInicial : Form
    {
        public FFormularioInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var fornecedor = new Fornecedor();

            List<Fornecedor> fornecedores = new List<Fornecedor>();

            fornecedores.Add(RetornarFornecedor(fornecedor));

            dgvFornecedores.DataSource = fornecedores;
        }

        private Fornecedor RetornarFornecedor(Fornecedor fornecedor)
        {
            if (txtNomeForn.Text != string.Empty)
            {
                fornecedor.NomeFornecedor = txtNomeForn.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome do fornecedor.");
            }

            if (txtEndereco.Text != string.Empty)
            {
                fornecedor.Endereco = txtEndereco.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o endereço.");
            }

            if (txtNomeContato.Text != string.Empty)
            {
                fornecedor.NomeContato = txtNomeContato.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome do contato.");
            }

            if (txtTelefone.Text != string.Empty)
            {
                fornecedor.Telefone = txtTelefone.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o telefone.");
            }

            return fornecedor;
        }
    }


}
