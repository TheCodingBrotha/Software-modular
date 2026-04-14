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
    public partial class NovoPedido4 : Form
    {
        public NovoPedido4()
        {
            InitializeComponent();
        }

        private void bt_CadastrarPedido_Click(object sender, EventArgs e)
        {

            // Validações
            if (string.IsNullOrWhiteSpace(tb_idCLiente.Text) ||
                string.IsNullOrWhiteSpace(tb_NomeCliente.Text) ||
                string.IsNullOrWhiteSpace(tb_idServico.Text) ||
                string.IsNullOrWhiteSpace(tb_NomeServico.Text) ||
                string.IsNullOrWhiteSpace(tb_qtd.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            if (!int.TryParse(tb_idCLiente.Text, out int id_cliente))
            {
                MessageBox.Show("ID do cliente inválido.");
                return;
            }

            if (!int.TryParse(tb_idServico.Text, out int id_servico))
            {
                MessageBox.Show("ID do serviço inválido.");
                return;
            }

            if (!int.TryParse(tb_qtd.Text, out int quantidade))
            {
                MessageBox.Show("Quantidade inválida.");
                return;
            }
          


            string nomeCliente = tb_NomeCliente.Text;
            string nomeServico = tb_NomeServico.Text;
            string observacao = tb_obs.Text;
           

            string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sistema1;Integrated Security=True;";

            string consulta = @"INSERT INTO cadastro_pedido
        (id_cliente, NomeCliente, id_servico, NomeServico, quantidade, observacao)
        VALUES
        (@id_cliente, @NomeCliente, @id_servico, @NomeServico, @quantidade, @observacao)";

            using (SqlConnection conn = new SqlConnection(connection))
            using (SqlCommand cmd = new SqlCommand(consulta, conn))
            {
                cmd.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;
                cmd.Parameters.Add("@NomeCliente", SqlDbType.VarChar).Value = nomeCliente;
                cmd.Parameters.Add("@id_servico", SqlDbType.Int).Value = id_servico;
                cmd.Parameters.Add("@NomeServico", SqlDbType.VarChar).Value = nomeServico;
                cmd.Parameters.Add("@quantidade", SqlDbType.Int).Value = quantidade;
                cmd.Parameters.Add("@observacao", SqlDbType.VarChar).Value = observacao;
                
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pedido cadastrado com sucesso!");

                    tb_idCLiente.Clear();
                    tb_NomeCliente.Clear();
                    tb_idServico.Clear();
                    tb_NomeServico.Clear();
                    tb_qtd.Clear();
                    tb_obs.Clear();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void tb_idCLiente_Leave(object sender, EventArgs e)
        {

            {
                if (string.IsNullOrWhiteSpace(tb_idCLiente.Text))
                    return;

                if (!int.TryParse(tb_idCLiente.Text, out int idCliente))
                {
                    MessageBox.Show("ID do cliente inválido.");
                    tb_idCLiente.Focus();
                    return;
                }

                string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sistema1;Integrated Security=True;";
                string sql = "SELECT nome FROM cadastro_clientes WHERE id = @id";

                using (SqlConnection conn = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = idCliente;
                    conn.Open();

                    object resultado = cmd.ExecuteScalar();

                    if (resultado == null)
                    {
                        MessageBox.Show("Cliente não encontrado.");
                        tb_NomeCliente.Clear();
                        tb_idCLiente.Focus();
                    }
                    else
                    {
                        tb_NomeCliente.Text = resultado.ToString();
                    }
                }
            }
        }

        private void tb_idServico_Leave(object sender, EventArgs e)
        {
        
        
            if (string.IsNullOrWhiteSpace(tb_idServico.Text))
                return;

            if (!int.TryParse(tb_idServico.Text, out int idServico))
            {
                MessageBox.Show("ID do serviço inválido.");
                tb_idServico.Focus();
                return;
            }

            string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sistema1;Integrated Security=True;";
            string sql = "SELECT nome FROM cadastro_servico WHERE id_servico = @id";

            using (SqlConnection conn = new SqlConnection(connection))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = idServico;
                conn.Open();

                object resultado = cmd.ExecuteScalar();

                if (resultado == null)
                {
                    MessageBox.Show("Serviço não encontrado.");
                    tb_NomeServico.Clear();
                    tb_idServico.Focus();
                }
                else
                {
                    tb_NomeServico.Text = resultado.ToString();
                }
            }
        }

    }    } 