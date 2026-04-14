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
    public partial class VerClientes5 : Form
    {
        public VerClientes5()
        {
            InitializeComponent();
        }

        private void VerClientes5_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString =
               @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sistema1;Integrated Security=True;";


                string query = @"
            SELECT 
                id as [ID CLIENTE:],
                nome as [Cliente:],
                cpf_cnpj as [CPF ou CNPJ:],
                tel as [Tel:],
                email as [E-mail:]
            FROM cadastro_clientes";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    da.Fill(tabela);

                    //preenche o DataGrid com as linhas da tabela
                    Grid_VerClientes.DataSource = tabela;
                }

                MessageBox.Show("Clientes carregados!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }
    }
}
