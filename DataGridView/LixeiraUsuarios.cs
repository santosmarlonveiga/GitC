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
    public partial class LixeiraUsuarios : Form
    {
        public LixeiraUsuarios()
        {
            InitializeComponent();
        }

        private void LixeiraUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exerciciosFinaisDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomInativeValues(this.exerciciosFinaisDataSet1.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var UsuAcres = ((System.Data.DataRowView)
               this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
               as DataGridView.ExerciciosFinaisDataSet1.UsuariosRow;


            this.usuariosTableAdapter.AcresQuery(UsuAcres.Id);
            this.usuariosTableAdapter.CustomInativeValues(exerciciosFinaisDataSet1.Usuarios);
        }
    }
}
