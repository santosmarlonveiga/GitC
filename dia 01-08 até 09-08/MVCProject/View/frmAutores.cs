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
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.SelectQuery(this.sistemaBibliotecaDBDataSet.Autores);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var autoresSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.AutoresRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.autoresTableAdapter.DeleteQuery(autoresSelect.Id, autoresSelect.Nome,1, autoresSelect.Descricao);
                        this.autoresTableAdapter.SelectQuery(sistemaBibliotecaDBDataSet.Autores);
                    }
                    break;
                case 1:
                    {
                        frmEditAutores edicaoAutores = new frmEditAutores()
                        {
                            autoresRow = autoresSelect
                        };
                        edicaoAutores.ShowDialog();

                        this.autoresTableAdapter.Update(edicaoAutores.autoresRow);
                    }
                    break;
            }
            this.autoresTableAdapter.SelectQuery(this.sistemaBibliotecaDBDataSet.Autores);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddAutores formAddAutores = new frmAddAutores();
            formAddAutores.ShowDialog();
            if (!string.IsNullOrEmpty(formAddAutores.autorRow?.Nome))
                this.autoresTableAdapter.Insert(
                formAddAutores.autorRow.Nome,
                formAddAutores.autorRow.Descricao
                );
            this.autoresTableAdapter.SelectQuery(this.sistemaBibliotecaDBDataSet.Autores);
        }
    }
}
