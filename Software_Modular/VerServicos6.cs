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
    public partial class VerServicos6 : Form
    {
        public VerServicos6()
        {
            InitializeComponent();
        }

        private void VerServicos6_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString =
               @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sistema1;Integrated Security=True;";


                string query = @"
            SELECT 
                id_servico as [ID SERVIÇO],
                nome [Serviço:],
                tipo [Tipo:],
                valor [Valor:],
                prazo_entrega [Prazo (dias):]
                FROM cadastro_servico";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    da.Fill(tabela);

                    //preenche o DataGrid com as linhas da tabela
                    Grid_VerServicos.DataSource = tabela;
                }

                MessageBox.Show("Serviços carregados!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar serviços: " + ex.Message);
            }
        }
    }
}
