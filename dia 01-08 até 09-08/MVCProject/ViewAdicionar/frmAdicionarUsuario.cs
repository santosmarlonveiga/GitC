using MVCProject.Model;
using MVCProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.ViewAdicionar
{
    public partial class frmAdicionarUsuario : Form
    {
        public frmAdicionarUsuario()
        {
            InitializeComponent();
        }

        public Usuarios usuariosRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            usuariosRow = new Usuarios
            {
                Nome = textBox1.Text,
                Login = textBox2.Text,
                Senha = textBox3.Text,
                Email = textBox4.Text
            };
            this.Close();
        }
    }
}
