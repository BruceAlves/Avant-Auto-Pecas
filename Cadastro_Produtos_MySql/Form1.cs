using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Produtos_MySql
{
    public partial class AutoPeca : Form
    {
        public AutoPeca()
        {
            InitializeComponent();
        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string preco = txtPreco.Text;
            string qtdEstoque = txtQtd_Estoque.Text;
            string codigoBarra = txtCodigoBarra.Text;

            string conexão = "Server=127.0.0.1;Database=produtosCadastrados;Uid=root;Pwd=bruce@#2022;";

            MySqlConnection conexaoMysql = new MySqlConnection(conexão);

            string comandoInsert = $@"
            insert into produtos (nome, preco, codigo_Barra, qtd_Estoque)
            values('{nome}', '{preco}', '{codigoBarra}', '{qtdEstoque}');";

            try
            {
                conexaoMysql.Open();
                MySqlCommand executorComando = new MySqlCommand(comandoInsert, conexaoMysql);
                executorComando.ExecuteNonQuery();

                MessageBox.Show($"O produto {nome} foi Inserido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Banco de Dados", $"Erro:\n{ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);                                                           
            }
            finally
            {
                conexaoMysql.Close();
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }

        private void LimparCampo()
        {
            txtCodigoBarra.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtQtd_Estoque.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conexão = "Server=127.0.0.1;Database=produtosCadastrados;Uid=root;Pwd=bruce@#2022;";

            string query = $@"select * from produtos";

            MySqlConnection conexaoMysql = new MySqlConnection(conexão);
            DataTable tabela = new DataTable();

            try
            {
                conexaoMysql.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexaoMysql);
                adapter.Fill(tabela);
                dgvProdutos.DataSource = tabela;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Banco de Dados", $"Erro:\n{ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoMysql.Close();
            }
        }
    }
}
