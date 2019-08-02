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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exerciciosFinaisDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQuery(this.exerciciosFinaisDataSet1.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marcasSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridView.ExerciciosFinaisDataSet1.MarcasRow;


            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.marcasTableAdapter.DeleteQuery(marcasSelect.Id);
                        this.marcasTableAdapter.CustomQuery(exerciciosFinaisDataSet1.Marcas);
                    }
                    break;
                case 1:
                    {
                        EdicaoMarcas edicaoMarcas = new EdicaoMarcas()
                        {
                            marcasRow = marcasSelect
                        };
                        edicaoMarcas.ShowDialog();

                        this.marcasTableAdapter.Update(edicaoMarcas.marcasRow);
                    } break;
            }
            this.marcasTableAdapter.CustomQuery(this.exerciciosFinaisDataSet1.Marcas);
        }
                

        private void Button2_Click(object sender, EventArgs e)
        {
            LixeiraMarcas lixeiraMarcas = new LixeiraMarcas();
            lixeiraMarcas.ShowDialog();

            this.marcasTableAdapter.CustomQuery(exerciciosFinaisDataSet1.Marcas);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarMarcas formAddMarcas = new frmAdicionarMarcas();
            formAddMarcas.ShowDialog();
            if (!string.IsNullOrEmpty(formAddMarcas.marcasRow?.Nome))
                this.marcasTableAdapter.Insert(
                formAddMarcas.marcasRow.Nome,
                true,
                formAddMarcas.marcasRow.UsuInc,
                1,
                DateTime.Now,
                DateTime.Now
                );

            this.marcasTableAdapter.Fill(this.exerciciosFinaisDataSet1.Marcas);
        }
    }
}
