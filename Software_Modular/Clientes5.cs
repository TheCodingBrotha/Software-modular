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
    public partial class Clientes5 : Form
    {
        private Form atual;
        public Clientes5()
        {
            InitializeComponent();
        }

        private void Clientes5_Load(object sender, EventArgs e)
        {
            AbrirForm<LogoClientes>();
        }

        private void bt_clientes_Click(object sender, EventArgs e)
        {
            AbrirForm<VerClientes5>();
        }

        private void bt_novo_cliente_Click(object sender, EventArgs e)
        {
               AbrirForm<NovoCliente5>();
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
                panel_clientes.Controls.Remove(atual);
                atual.Parent = null;
                atual.Dispose();
                atual = null;
            }

            Form novoForm = new T();

            novoForm.TopLevel = false;
            novoForm.FormBorderStyle = FormBorderStyle.None;
            novoForm.Dock = DockStyle.Fill;

            panel_clientes.Controls.Add(novoForm);

            atual = novoForm;
            novoForm.Show();
            novoForm.BringToFront();

        }
    }
}
