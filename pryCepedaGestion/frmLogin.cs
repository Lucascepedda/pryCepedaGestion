using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryInicioSesionLogs;
using System.Data.OleDb;


namespace pryCepedaGestion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        clsUsuario login = new clsUsuario();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            login.Usuario();
            login.ValidarUsuario(txtUsuario.Text, txtContraseña.Text);
            if (login.estadoConexion == "Usuario EXISTE")
            {
                MessageBox.Show("Bienvenido");
                frmMenu frm = new frmMenu();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
        }

        
    }
}
