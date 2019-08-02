using DataGridView.Adicionar;
using DataGridView.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exerciciosFinaisDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomQuery(this.exerciciosFinaisDataSet1.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendasSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridView.ExerciciosFinaisDataSet1.VendasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.vendasTableAdapter.DeleteQuery(vendasSelect.Id);
                        this.vendasTableAdapter.CustomQuery(exerciciosFinaisDataSet1.Vendas);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoVendas editVendas = new frmEdicaoVendas()
                        {
                            vendasRow = vendasSelect
                        };
                        editVendas.ShowDialog();

                        this.vendasTableAdapter.Update(editVendas.vendasRow);
                    }
                    break;
            }
            this.vendasTableAdapter.CustomQuery(this.exerciciosFinaisDataSet1.Vendas);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LixeiraVendas lixeiraVendas = new LixeiraVendas();
            lixeiraVendas.ShowDialog();

            this.vendasTableAdapter.CustomQuery(exerciciosFinaisDataSet1.Vendas);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarVendas formAddVendas = new frmAdicionarVendas();
            formAddVendas.ShowDialog();

            if(formAddVendas.vendasRow?.Carro > 0 && formAddVendas.vendasRow?.Valor > 0)

            this.vendasTableAdapter.Insert(
                formAddVendas.vendasRow.Carro,
                formAddVendas.vendasRow.Quantidade,
                formAddVendas.vendasRow.Valor,
                true,
                formAddVendas.vendasRow.UsuInc,
                1,
                DateTime.Now,
                DateTime.Now
                );

            this.vendasTableAdapter.Fill(this.exerciciosFinaisDataSet1.Vendas);
        }
    }
}
