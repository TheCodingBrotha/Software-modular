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
    public partial class Inicio2 : Form
    {

        private Form? atual;

        public Inicio2()
        { InitializeComponent(); }

        private void Inicio2_Load(object sender, EventArgs e)
        {
            AbrirForm<Home3>();
        }

        private void menu_pedidos_Click(object sender, EventArgs e)
        {
            AbrirForm<Pedidos4>();
        }

        private void menu_clientes_Click(object sender, EventArgs e)
        {
            AbrirForm<Clientes5>();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
        }

        private void menu_home_Click(object sender, EventArgs e)
        {
            AbrirForm<Home3>();
        }

        private void menu_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_servicos_Click(object sender, EventArgs e)
        {
            AbrirForm<Servicos6>();
        }

        private void menu_saiba_Click(object sender, EventArgs e)
        {
            SaibaMais abrir = new SaibaMais();
            abrir.Show();

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
                panel_telas.Controls.Remove(atual);
                atual.Parent = null;
                atual.Dispose();
                atual = null;
            }

            Form novoForm = new T();

            novoForm.TopLevel = false;
            novoForm.FormBorderStyle = FormBorderStyle.None;
            novoForm.Dock = DockStyle.Fill;

            panel_telas.Controls.Add(novoForm);

            atual = novoForm;
            novoForm.Show();
            novoForm.BringToFront();

        }
    }
}

