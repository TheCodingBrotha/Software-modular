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

    public partial class Pedidos4 : Form
    {
        private Form atual;
        public Pedidos4()
        {
            InitializeComponent();
        }

        private void Pedidos4_Load(object sender, EventArgs e)
        {
            AbrirForm<LogoPedido>();
        }

        private void bt_pedidos_Click(object sender, EventArgs e)
        {
            //VerPedidos4 Abrir = new VerPedidos4();
            //Abrir.Show();
            AbrirForm<VerPedidos4>();
        }

        private void bt_novo_pedido_Click(object sender, EventArgs e)
        {
            AbrirForm<NovoPedido4>();
        }

        private void panel_pedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_historico_Click(object sender, EventArgs e)
        {
            AbrirForm<Historico>();
        }

        private void bt_concluir_Click(object sender, EventArgs e)
        {
            AbrirForm<Concluir>();
        }

        private void AbrirForm<T>() where T : Form, new()
        {
            if (atual != null && atual.GetType() == typeof(T))
            {
                atual.BringToFront();
                return;
            }

            if (atual != null)
            {
                panel_pedidos.Controls.Remove(atual);
                atual.Parent = null;
                atual.Dispose();
                atual = null;
            }

            Form novoForm = new T();

            novoForm.TopLevel = false;
            novoForm.FormBorderStyle = FormBorderStyle.None;
            novoForm.Dock = DockStyle.Fill;

            panel_pedidos.Controls.Add(novoForm);

            atual = novoForm;
            novoForm.Show();
            novoForm.BringToFront();

        }
    }
}
