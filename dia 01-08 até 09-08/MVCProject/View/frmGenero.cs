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
    public partial class frmGenero : Form
    {
        public frmGenero()
        {
            InitializeComponent();
        }

        private void FrmGenero_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter.SelectQuery(this.sistemaBibliotecaDBDataSet.Genero);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var generoSelect = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
               as MVCProject.SistemaBibliotecaDBDataSet.GeneroRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.generoTableAdapter.DeleteQuery(generoSelect.Id, generoSelect.Tipo,1, generoSelect.Descrição);
                        this.generoTableAdapter.SelectQuery(sistemaBibliotecaDBDataSet.Genero);
                    }
                    break;
                case 1:
                    {
                        frmEditGenero edicaoGenero = new frmEditGenero()
                        {
                            generoRow = generoSelect
                        };
                        edicaoGenero.ShowDialog();

                        this.generoTableAdapter.Update(edicaoGenero.generoRow);
                    }
                    break;
            }
            this.generoTableAdapter.SelectQuery(this.sistemaBibliotecaDBDataSet.Genero);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddGenero formAddGenero = new frmAddGenero();
            formAddGenero.ShowDialog();
            if (!string.IsNullOrEmpty(formAddGenero.generosRow?.Tipo))
                this.generoTableAdapter.Insert(
                formAddGenero.generosRow.Tipo,
                formAddGenero.generosRow.Descricao
                );
            this.generoTableAdapter.SelectQuery(this.sistemaBibliotecaDBDataSet.Genero);
        }
    }
}
