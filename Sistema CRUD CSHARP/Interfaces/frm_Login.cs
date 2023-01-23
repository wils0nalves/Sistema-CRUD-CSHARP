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
using Sistema_CRUD_CSHARP.Models;
using Sistema_CRUD_CSHARP.Controllers;

namespace Sistema_CRUD_CSHARP
{
    public partial class frm_Login : Form
    {
        public string Login
        {
            get { return tbx_Login.Text; }
        }

        public string Senha
        {
            get { return tbx_Senha.Text; }
        }

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

        public void btn_Login_Click(object sender, EventArgs e)
        {
            Dados_Login login = new Dados_Login();

            login.Login = tbx_Login.Text;
            login.Senha = tbx_Senha.Text;

            ctl_Login controle = new ctl_Login();
            bool existe = controle.Verifica_se_existe(login);
            bool ativo = false;
            if (existe)
            {
                ativo = controle.Verifica_se_ativo(login);
            }
            else
            {
                lbl_Mensagem.Text = "Usuário não existe";
            }

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
                            this.Hide();
                        }
                    }

                connection.Close();
        }

        private void btn_Criar_Usuario_Click(object sender, EventArgs e)
        {
            //chamando outro formulário
            frm_Novo_Usuario form = new frm_Novo_Usuario();
            form.Show();
        }

        private void tbx_Login_TextChanged(object sender, EventArgs e)
        {
            lbl_Mensagem.Text = "";
        }
    }
}
