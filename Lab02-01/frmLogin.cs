using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        int intento = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            String[] Usuario = { "alvaro", "pepe", "pedro", "kunno" };
            String[] Clave = { "7777", "7774", "7775", "7776" };
            
            if(Usuario.Contains(txtUsuario.Text) && Clave.Contains(txtPassword.Text) && Array.IndexOf(Usuario, txtUsuario.Text) == Array.IndexOf(Clave, txtPassword.Text))
            {
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
                txtUsuario.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                txtUsuario.Clear();
                txtPassword.Text = "";
                txtUsuario.Focus();
                intento += 1;

                if (intento == 3)
                {
                    Application.Exit();
                }
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
