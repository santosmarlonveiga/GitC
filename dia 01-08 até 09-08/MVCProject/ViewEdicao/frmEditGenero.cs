using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.ViewEdicao
{
    public partial class frmEditGenero : Form
    {
        public frmEditGenero()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBDataSet.GeneroRow generoRow;

        private void FrmEditGenero_Load(object sender, EventArgs e)
        {
            textBox1.Text = generoRow.Tipo;
            textBox2.Text = generoRow.Descrição;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            generoRow.Tipo = textBox1.Text;
            generoRow.Descrição = textBox2.Text;

            this.Close();
        }
    }
}
