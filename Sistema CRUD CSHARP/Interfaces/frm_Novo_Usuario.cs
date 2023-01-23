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

namespace Sistema_CRUD_CSHARP.Interfaces
{
    public partial class frm_Novo_Usuario : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;

        public frm_Novo_Usuario()
        {
            InitializeComponent();

            tbx_Nova_Senha.PasswordChar = '*';
        }

        private void frm_Novo_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_Criar_Usuario_Click(object sender, EventArgs e)
        {
            Verifica_Usuario_duplicado();

            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = cliente; Uid = wilson; Pwd = @W1ls0nyur1;");

                strSQL = "INSERT INTO dados_login (login, senha) VALUES (@LOGIN, @SENHA)";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@LOGIN", tbx_Novo_Usuario.Text);
                comando.Parameters.AddWithValue("@SENHA", tbx_Nova_Senha.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
            this.Hide();
        }

        private void Verifica_Usuario_duplicado() //método para verificar se existe usuário duplicado no banco
        {
            MySqlConnection conexao;
            MySqlCommand comando;
            string strSQL;

            conexao = new MySqlConnection ("Server = localhost; Database = cliente; Uid = wilson; Pwd = @W1ls0nyur1;");

            strSQL = ("SELECT COUNT(*) FROM dados_login WHERE login = @criarusuario");

            comando = new MySqlCommand(strSQL, conexao);

            comando.Parameters.AddWithValue("@criarusuario", btn_Criar_Usuario.Text);

            conexao.Open();

            int count = Convert.ToInt32(comando.ExecuteScalar());

            // MessageBox.Show(count.Text);
                
                if (count >= 1)
                {
                    MessageBox.Show("Usuário já existe na base de dados.");
                    conexao.Close();
                    Application.Exit(); 
                }
                else
                {
                MessageBox.Show("Usuário será criado");
                }
            
        }
    }
}