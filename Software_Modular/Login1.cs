using Microsoft.Data.SqlClient;
using System.Data;

namespace Software_Modular
{
    public partial class Login1 : Form

    {
        private const char _hideChar = '\u25CF';
        bool check = false;

        public Login1()
        {
            InitializeComponent();
            tb_senha.PasswordChar = _hideChar;

            rb_mostrar.AutoCheck = false;
        }


        private void Login1_Load(object sender, EventArgs e)
        {

        }

        private void bt_saiba_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaibaMais abrir = new SaibaMais();
            abrir.Show();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            Inicio2 mostrar = new Inicio2();

            mostrar.Show();

        }


        private void bt_login_Click_1(object sender, EventArgs e)
        {
            {
                string usuario = tb_user.Text.Trim();
                string senha = tb_senha.Text.Trim();

                if (usuario == "" || senha == "")
                {
                    MessageBox.Show("Preencha usuário e senha!");
                    return;
                }

                string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sistema1;Integrated Security=True;";
                string sql = @"SELECT id_adm 
                   FROM login_adm 
                   WHERE usuario = @usuario AND senha = @senha";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connection))
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                        cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;

                        conn.Open();

                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null)
                        {
                            MessageBox.Show("Login realizado com sucesso!");

                            Inicio2 tela = new Inicio2();
                            tela.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void rb_mostrar_Click(object sender, EventArgs e)
        {
            rb_mostrar.Checked = !rb_mostrar.Checked;
        }

        private void rb_mostrar_CheckedChanged(object sender, EventArgs e)
        {
            tb_senha.PasswordChar = rb_mostrar.Checked ? '\0' : _hideChar;


            if (rb_mostrar.Checked)
            {
                rb_mostrar.Text = "Esconder";
            }
            else
            {
                rb_mostrar.Text = "Mostrar";
            }

        }
    }

}
