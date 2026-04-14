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
    public partial class Concluir : Form
    {
        public Concluir()
        {
            InitializeComponent();
        }

        private void tb_qtd_Leave(object sender, EventArgs e)
        {
            // VERIFICA O CAMPO CERTO (tb_idServico)
            if (string.IsNullOrWhiteSpace(tb_idp.Text))
            {
                MessageBox.Show("Digite o ID do pedido.");
                tb_idServico.Focus();
                return;
            }

            if (!int.TryParse(tb_idp.Text, out int idPedido))
            {
                MessageBox.Show("ID do pedido inválido. Digite apenas números.");
                tb_idServico.Focus();
                tb_idServico.SelectAll();  // Seleciona todo o texto para fácil correção
                return;
            }

            string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sistema1;Integrated Security=True;";
            string sql = "SELECT id_cliente, NomeCliente, id_servico,NomeServico FROM cadastro_pedido WHERE id_pedido = @id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = idPedido;
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Preenche os campos
                            tb_NomeServico.Text = reader["nome"].ToString();
                            tb_idp.Text = idPedido.ToString();  // Mostra o ID no campo tb_idp

                            // Verifica nulos
                            if (!reader.IsDBNull(reader.GetOrdinal("id_cliente")))
                                tb_idCLiente.Text = reader["id_cliente"].ToString();
                            else
                                tb_idCLiente.Text = "";

                            if (!reader.IsDBNull(reader.GetOrdinal("NomeCliente")))
                                tb_NomeCliente.Text = reader["NomeCliente"].ToString();
                            else
                                tb_NomeCliente.Text = "";
                        }
                        else
                        {
                            MessageBox.Show($"Pedido ID {idPedido} não encontrado.");

                            // Limpa os campos
                            tb_NomeServico.Clear();
                            tb_idp.Clear();
                            tb_idCLiente.Clear();
                            tb_NomeCliente.Clear();

                            tb_idServico.Focus();
                            tb_idServico.SelectAll();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }
    }
}







