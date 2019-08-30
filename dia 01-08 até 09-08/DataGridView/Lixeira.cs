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
    public partial class Lixeira : Form
    {
        public Lixeira()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exerciciosFinaisDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.CustomInativeValues(this.exerciciosFinaisDataSet1.Carros);

        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carAcres = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
               as DataGridView.ExerciciosFinaisDataSet1.CarrosRow;

           
            this.carrosTableAdapter.AcrescentarQuery(carAcres.Id);
            this.carrosTableAdapter.CustomInativeValues(exerciciosFinaisDataSet1.Carros);
        }
    }
}
