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
    public partial class frmEdicaoLivros : Form
    {
        public frmEdicaoLivros()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBDataSet.LivrosRow livrosRow;

        private void FrmEdicaoLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editora' table. You can move, or remove it, as needed.
            this.editoraTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editora);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Genero);
            textBox1.Text = (livrosRow.Registro).ToString();
            textBox2.Text = livrosRow.Titulo;
            textBox3.Text = livrosRow.Isbn;
            comboBox1.SelectedValue = livrosRow.Genero;
            comboBox2.SelectedValue = livrosRow.Editora;
            textBox4.Text = livrosRow.Sinopse;
            textBox5.Text = livrosRow.Observacaoes;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            livrosRow.Registro = int.Parse(textBox1.Text);
            livrosRow.Titulo = textBox2.Text;
            livrosRow.Isbn = textBox3.Text;
            livrosRow.Genero = (int)comboBox1.SelectedValue;
            livrosRow.Editora = (int)comboBox2.SelectedValue;
            livrosRow.Sinopse = textBox4.Text;
            livrosRow.Observacaoes = textBox5.Text;

            this.Close();
        }
    }
}
