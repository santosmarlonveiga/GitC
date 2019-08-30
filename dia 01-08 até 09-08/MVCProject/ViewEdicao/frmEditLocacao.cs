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
    public partial class frmEditLocacao : Form
    {
        public frmEditLocacao()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow locacaoRow;

        private void FrmEditLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);


            comboBox1.SelectedValue = locacaoRow.Livro;
            comboBox2.SelectedValue = locacaoRow.Usuario;
            textBox1.Text = (locacaoRow.Tipo).ToString();
            dateTimePicker1.Value = locacaoRow.Devolucao;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            locacaoRow.Livro = (int)comboBox1.SelectedValue;
            locacaoRow.Usuario = (int)comboBox2.SelectedValue;
            locacaoRow.Tipo = int.Parse(textBox1.Text);
            locacaoRow.Devolucao = dateTimePicker1.Value;
            this.Close();
            
        }
    }
}
