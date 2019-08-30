using MVCProject.ViewAdicionar;
using MVCProject.ViewEdicao;
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
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.SelectQuery(this.sistemaBibliotecaDBDataSet.Livros);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livroSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.LivrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.livrosTableAdapter.DeleteQuery(livroSelect.Id);
                        this.livrosTableAdapter.SelectQuery(sistemaBibliotecaDBDataSet.Livros);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoLivros frmEditLivros = new frmEdicaoLivros()
                        {
                            livrosRow = livroSelect
                        };
                        frmEditLivros.ShowDialog();

                        this.livrosTableAdapter.Update(frmEditLivros.livrosRow);
                    }
                    break;
            }
            this.livrosTableAdapter.SelectQuery(this.sistemaBibliotecaDBDataSet.Livros);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLivro formAddLivro = new frmAdicionarLivro();
            formAddLivro.ShowDialog();
            if (!string.IsNullOrEmpty(formAddLivro.livrosRow?.Titulo))
                this.livrosTableAdapter.Insert(
                formAddLivro.livrosRow.Registro,
                formAddLivro.livrosRow.Titulo,
                formAddLivro.livrosRow.Isbn,
                formAddLivro.livrosRow.Genero,
                formAddLivro.livrosRow.Editora,
                formAddLivro.livrosRow.Sinopse,
                formAddLivro.livrosRow.Observacoes,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.livrosTableAdapter.SelectQuery(this.sistemaBibliotecaDBDataSet.Livros);
        }
    }
}

       

        
    
