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
    public partial class VerPedidos4 : Form
    {
        public VerPedidos4()
        {
            InitializeComponent();
        }

        private void VerPedidos4_Load(object sender, EventArgs e)
        {
            
            try
            {
                string connectionString = 
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sistema1;Integrated Security=True;";



                string query = @"

                SELECT 
                    p.id_pedido as [ID PEDIDO:],
                    p.id_cliente as [ID CLIENTE:],
                    p.id_servico as [ID SERVIÇO:],
                    c.nome as [Cliente:],
                    s.nome as [Serviço:],
                    p.quantidade as [Qtd:],
                    (s.valor * p.quantidade) as [Valor R$:],
                  
                    s.prazo_entrega as [Prazo de Entrega (dias):],
                    p.observacao as [Obs:]
                FROM cadastro_pedido p
                INNER JOIN cadastro_clientes c ON p.id_cliente = c.id
                INNER JOIN cadastro_servico s ON p.id_servico = s.id_servico
                ORDER BY p.id_pedido DESC;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                   da.Fill(tabela);

                    //preenche o DataGrid com as linhas da tabela
                    Grid_VerPedidos.DataSource = tabela;
                }

                MessageBox.Show("Pedidos carregados!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar pedidos: " + ex.Message);
            }
        }
    }
}
