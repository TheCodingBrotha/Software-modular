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
using static System.Reflection.Metadata.BlobBuilder;

namespace Software_Modular
{
    public partial class NovoServico6 : Form
    {
        public NovoServico6()
        {
            InitializeComponent();
        }

        private void NovoServico6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void bt_CadastrarServico_Click(object sender, EventArgs e)
        {
            // 1️⃣ Captura dos dados da tela
            string nome = tb_servico.Text;
            string tipo = tb_tipo.Text;

            if (!decimal.TryParse(tb_valor.Text, out decimal valor))
            {
                MessageBox.Show("Valor inválido.");
                return;
            }

            if (!int.TryParse(tb_prazo.Text, out int prazo))
            {
                MessageBox.Show("Prazo inválido.");
                return;
            }

            // 2️⃣ String de conexão
            string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sistema1;Integrated Security=True;";

            // 3️⃣ Comando SQL (com parâmetros)
            string consulta = @"INSERT INTO cadastro_servico
                        (nome, tipo, valor, prazo_entrega)
                        VALUES (@nome, @tipo, @valor, @prazo)";

            // 4️⃣ Execução segura
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    // 🔹 Parâmetros (ESSENCIAL)
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar, 64).Value = nome;
                    cmd.Parameters.Add("@tipo", SqlDbType.VarChar, 100).Value = tipo;
                    cmd.Parameters.Add("@valor", SqlDbType.Decimal).Value = valor;
                    cmd.Parameters.Add("@prazo", SqlDbType.Int).Value = prazo;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Serviço cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar serviço:\n" + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
