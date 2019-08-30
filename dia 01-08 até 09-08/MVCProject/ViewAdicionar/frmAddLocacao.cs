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
    public partial class frmAddLocacao : Form
    {
        public frmAddLocacao()
        {
            InitializeComponent();
        }

        public Locacao locacaoRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            locacaoRow = new Locacao
            {
                Livro = (int)comboBox1.SelectedValue,
                Usuario = (int)comboBox2.SelectedValue,
                Tipo = int.Parse(textBox1.Text),
                Devolucao = dateTimePicker1.Value
            };

            this.Close();
        }

        private void FrmAddLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

        }
    }
}
