using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sistema_CRUD_CSHARP.Interfaces;

namespace Sistema_CRUD_CSHARP
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            tbx_Senha.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //conectando com o banco, dados dentro da string "Conexão"
            string Conexao = "Server = localhost; Database = cliente; Uid = wilson; Pwd = @W1ls0nyur1;";

            var connection = new MySqlConnection(Conexao);

            //criando um novo comando para o botão realizar no banco
            var comand = connection.CreateCommand();

            //neste select abaixo, se os dados estiverem incorretos o select não retornará nada, se os dados estiverem corretos o banco retorna o valor 1
            MySqlCommand query = new MySqlCommand("SELECT COUNT(*) FROM dados_login WHERE login = '" + tbx_Login.Text + "' and senha = '" + tbx_Senha.Text + "'", connection);

            connection.Open();

            //trazendo os resultados da consulta SQL para um data table
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query);
            da.Fill(dataTable);

            foreach (DataRow list in dataTable.Rows)
            {
                //se o valor do banco for correto o select count retornará 1 e se o valor for maior do que 0, a tela de login libera o acesso
                if (Convert.ToInt32(list.ItemArray[0]) > 0)
                {
                    this.Hide();

                    frm_Tela_Inicial form = new frm_Tela_Inicial();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Usuário Inválido", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            connection.Close();
        }

        private void btn_Criar_Usuario_Click(object sender, EventArgs e)
        {
            frm_Novo_Usuario form = new frm_Novo_Usuario();
            form.Show();

        }
    }
}
