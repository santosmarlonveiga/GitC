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
    public partial class frmEditEditora : Form
    {
        public frmEditEditora()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBDataSet.EditoraRow editoraRow;

        private void FrmEditEditora_Load(object sender, EventArgs e)
        {
            textBox1.Text = editoraRow.Nome;
            textBox2.Text = editoraRow.Descricao;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            editoraRow.Nome = textBox1.Text;
            editoraRow.Descricao = textBox2.Text;

            this.Close();
        }
    }
}
