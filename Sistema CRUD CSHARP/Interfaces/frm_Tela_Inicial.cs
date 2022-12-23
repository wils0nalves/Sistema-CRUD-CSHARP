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

namespace Sistema_CRUD_CSHARP
{
    public partial class frm_Tela_Inicial : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public frm_Tela_Inicial()
        {
            InitializeComponent();
        }

        private void frm_Tela_Inicial_Load(object sender, EventArgs e)
        {

        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = cliente; Uid = wilson; Pwd = @W1ls0nyur1;"); //apontando o servidor 

                strSQL = "INSERT INTO dados_clientes (nome, email, cidade, uf) VALUES (@NOME, @EMAIL, @CIDADE, @UF)"; //comando de inserir os dados

                comando = new MySqlCommand(strSQL, conexao);

                //tratando os campos dados recebidos no StrSQL para receber os dados inseridos no formulário de tela inicial
                comando.Parameters.AddWithValue("@NOME", tbx_Nome.Text);
                comando.Parameters.AddWithValue("@EMAIL", tbx_Email.Text);
                comando.Parameters.AddWithValue("@CIDADE", tbx_Cidade.Text);
                comando.Parameters.AddWithValue("@UF", tbx_Uf.Text);

                conexao.Open(); //abrindo a conexão

                comando.ExecuteNonQuery(); //aqui é retornado quantas linhas foram afetadas no banco
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = cliente; Uid = wilson; Pwd = @W1ls0nyur1;"); //apontando o servidor 

                strSQL = "UPDATE dados_clientes SET nome = @NOME, email = @EMAIL, cidade = @CIDADE, uf = @UF WHERE id = @ID"; //comando de inserir os dados

                comando = new MySqlCommand(strSQL, conexao);

                //tratando os os campos para receber os dados inseridos no formulário de tela inicial
                comando.Parameters.AddWithValue("@ID", tbx_Id.Text);
                comando.Parameters.AddWithValue("@NOME", tbx_Nome.Text);
                comando.Parameters.AddWithValue("@EMAIL", tbx_Email.Text);
                comando.Parameters.AddWithValue("@CIDADE", tbx_Cidade.Text);
                comando.Parameters.AddWithValue("@UF", tbx_Uf.Text);

                conexao.Open(); //abrindo a conexão

                comando.ExecuteNonQuery(); //aqui é retornado quantas linhas foram afetadas no banco
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = cliente; Uid = wilson; Pwd = @W1ls0nyur1;"); //apontando o servidor 

                strSQL = "DELETE FROM dados_clientes WHERE id = @ID"; //comando de inserir os dados

                comando = new MySqlCommand(strSQL, conexao);

                //tratando os os campos para receber os dados inseridos no formulário de tela inicial
                comando.Parameters.AddWithValue("@ID", tbx_Id.Text);

                conexao.Open(); //abrindo a conexão

                comando.ExecuteNonQuery(); //aqui é retornado quantas linhas foram afetadas no banco
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = cliente; Uid = wilson; Pwd = @W1ls0nyur1;"); //apontando o servidor 

                strSQL = "SELECT * FROM dados_clientes WHERE id = @ID"; //comando de inserir os dados

                comando = new MySqlCommand(strSQL, conexao);

                //tratando os os campos para receber os dados inseridos no formulário de tela inicial
                comando.Parameters.AddWithValue("@ID", tbx_Id.Text);

                conexao.Open(); //abrindo a conexão

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    tbx_Nome.Text = Convert.ToString(dr["nome"]);
                    tbx_Email.Text = Convert.ToString(dr["email"]);
                    tbx_Cidade.Text = Convert.ToString(dr["cidade"]);
                    tbx_Uf.Text = Convert.ToString(dr["uf"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); ;
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btn_Logoff_Click(object sender, EventArgs e)
        {
            this.Hide();

            frm_Login form = new frm_Login();
            form.Show();
        }

        private void btn_Exibir_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = cliente; Uid = wilson; Pwd = @W1ls0nyur1;"); //apontando o servidor 

                strSQL = "SELECT * FROM dados_clientes"; //comando de inserir os dados

                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgv_Exibir.DataSource = dt;
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
        }
    }
}
