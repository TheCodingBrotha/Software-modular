using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Modular
{
    public partial class NovoCliente5 : Form
    {
        public NovoCliente5()
        {
            InitializeComponent();
        }
        private void bt_CadastrarCliente_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string documento = tb_doc.Text;
            string telefone = tb_tel.Text;
            string email = tb_email.Text;


            string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sistema1;Integrated Security=True;";
            string consulta = $"insert into cadastro_clientes (nome,cpf_cnpj,tel,email)" +
            $"values('{nome}','{documento}','{telefone}','{email}')";
            SqlConnection conn = null; //conexão vazia
            try //tentando executar alguma instrução
            {
                conn = new SqlConnection(connection); //conexão com o banco local - fazer conexão
                SqlCommand cmd = new SqlCommand(consulta, conn); //esta classe tem o papel de executar os comandos do banco de dados 
                conn.Open(); //abrindo a conexão
                cmd.ExecuteNonQuery(); //executando o comando
                MessageBox.Show("Cadastro efetuado com sucesso!");
                tb_nome.Clear();
                tb_doc.Clear();
                tb_tel.Clear();
                tb_email.Clear();

            }
            catch (Exception ex) //pegando erros caso na tentativa aconteça de surgir qualquer um
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close(); //fechando a conexão
                }

            }
        }

        private void NovoCliente5_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
