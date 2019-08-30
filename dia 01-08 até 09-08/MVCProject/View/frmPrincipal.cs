using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrUsuarios usuarios = new fmrUsuarios();
            usuarios.ShowDialog();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivros livros = new frmLivros();
            livros.ShowDialog();
        }

        private void EditorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditora editora = new frmEditora();
            editora.ShowDialog();
        }

        private void GeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenero genero = new frmGenero();
            genero.ShowDialog();
        }

        private void AutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutores autores = new frmAutores();
            autores.ShowDialog();
        }

        private void LocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocacao locacao = new frmLocacao();
            locacao.ShowDialog();
        }
    }
}
