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
    public partial class frmEditora : Form
    {
        public frmEditora()
        {
            InitializeComponent();
        }

        private void FrmEditora_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editora' table. You can move, or remove it, as needed.
            this.editoraTableAdapter.SelectQuery(this.sistemaBibliotecaDBDataSet.Editora);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var editoraSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.EditoraRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.editoraTableAdapter.DeleteQuery(editoraSelect.Id, editoraSelect.Nome, 1, editoraSelect.Descricao);
                        this.editoraTableAdapter.SelectQuery(sistemaBibliotecaDBDataSet.Editora);
                    }
                    break;
                case 1:
                    {
                        frmEditEditora edicaoEditora = new frmEditEditora()
                        {
                            editoraRow = editoraSelect
                        };
                        edicaoEditora.ShowDialog();

                        this.editoraTableAdapter.Update(edicaoEditora.editoraRow);
                    }
                    break;
            }
            this.editoraTableAdapter.SelectQuery(this.sistemaBibliotecaDBDataSet.Editora);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddEditora formAddEditora = new frmAddEditora();
            formAddEditora.ShowDialog();
            if (!string.IsNullOrEmpty(formAddEditora.editoraRow?.Nome))
                this.editoraTableAdapter.Insert(
                formAddEditora.editoraRow.Nome,
                formAddEditora.editoraRow.Descricao
                );
            this.editoraTableAdapter.SelectQuery(this.sistemaBibliotecaDBDataSet.Editora);
        }


    }
}
