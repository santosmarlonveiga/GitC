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
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private void FrmLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.SelectQuery(this.sistemaBibliotecaDBDataSet.Locacao);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var locacaoSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.locacaoTableAdapter.DeleteQuery(locacaoSelect.Id);
                        this.locacaoTableAdapter.SelectQuery(sistemaBibliotecaDBDataSet.Locacao);
                    }
                    break;
                case 1:
                    {
                        frmEditLocacao edicaoLocacao = new frmEditLocacao()
                        {
                            locacaoRow = locacaoSelect
                        };
                        edicaoLocacao.ShowDialog();

                        this.locacaoTableAdapter.Update(edicaoLocacao.locacaoRow);
                    }
                    break;
            }
            this.locacaoTableAdapter.SelectQuery(this.sistemaBibliotecaDBDataSet.Locacao);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddLocacao formAddLocacao = new frmAddLocacao();
            formAddLocacao.ShowDialog();
            if (formAddLocacao.locacaoRow?.Livro > 0 && formAddLocacao.locacaoRow?.Usuario > 0)
                this.locacaoTableAdapter.Insert(
                formAddLocacao.locacaoRow.Livro,
                formAddLocacao.locacaoRow.Usuario,
                formAddLocacao.locacaoRow.Tipo,
                formAddLocacao.locacaoRow.Devolucao,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.locacaoTableAdapter.SelectQuery(this.sistemaBibliotecaDBDataSet.Locacao);
        }
    }
}
