using MVCProject.Model;
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
    public partial class frmAddAutores : Form
    {
        public frmAddAutores()
        {
            InitializeComponent();
        }

        public Autor autorRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            autorRow = new Autor
            {
                Nome = textBox1.Text,
                Descricao = textBox2.Text
            };
            this.Close();
        }
    }
}
