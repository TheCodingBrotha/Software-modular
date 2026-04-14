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
    public partial class Servicos6 : Form
    {
        private Form atual;
        public Servicos6()
        {
            InitializeComponent();
        }

        private void Servicos6_Load(object sender, EventArgs e)
        {
            AbrirForm<LogoServico>();
        }

        private void bt_servicos_Click(object sender, EventArgs e)
        {
            AbrirForm<VerServicos6>();
        }

        private void bt_novo_servico_Click(object sender, EventArgs e)
        {
            AbrirForm<NovoServico6>();
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
                panel_servicos.Controls.Remove(atual);
                atual.Parent = null;
                atual.Dispose();
                atual = null;
            }

            Form novoForm = new T();

            novoForm.TopLevel = false;
            novoForm.FormBorderStyle = FormBorderStyle.None;
            novoForm.Dock = DockStyle.Fill;

            panel_servicos.Controls.Add(novoForm);

            atual = novoForm;
            novoForm.Show();
            novoForm.BringToFront();

        }
    }
}
