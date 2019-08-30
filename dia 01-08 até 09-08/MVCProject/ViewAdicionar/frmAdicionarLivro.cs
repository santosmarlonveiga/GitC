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
    public partial class frmAdicionarLivro : Form
    {
        public frmAdicionarLivro()
        {
            InitializeComponent();
        }

        public Livros livrosRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            livrosRow = new Livros
            {
                Registro = int.Parse(textBox1.Text),
                Titulo = textBox2.Text,
                Isbn = textBox3.Text,
                Genero = (int)comboBox1.SelectedValue,
                Editora = (int)comboBox2.SelectedValue,
                Sinopse = textBox4.Text,
                Observacoes = textBox5.Text
            };
            this.Close();
        }

        private void FrmAdicionarLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Genero);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editora' table. You can move, or remove it, as needed.
            this.editoraTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editora);

        }
    }
}
