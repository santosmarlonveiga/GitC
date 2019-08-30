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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exerciciosFinaisDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.exerciciosFinaisDataSet1.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuarioSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridView.ExerciciosFinaisDataSet1.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.usuariosTableAdapter.DeleteQuery(usuarioSelect.Id);
                        this.usuariosTableAdapter.CustomQuery(exerciciosFinaisDataSet1.Usuarios);
                    }
                    break;
                case 1:
                    {
                        fmrEdicaoUsuario editUsuarios = new fmrEdicaoUsuario()
                        {
                            usuariosRow = usuarioSelect
                        };
                        editUsuarios.ShowDialog();
                        this.usuariosTableAdapter.Update(editUsuarios.usuariosRow);
                    }
                    break;
            }
            this.usuariosTableAdapter.CustomQuery(this.exerciciosFinaisDataSet1.Usuarios);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LixeiraUsuarios lixeiraUsuarios = new LixeiraUsuarios();
            lixeiraUsuarios.ShowDialog();

            this.usuariosTableAdapter.CustomQuery(exerciciosFinaisDataSet1.Usuarios);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuario formAddUsu = new frmAdicionarUsuario();
            formAddUsu.ShowDialog();
            if (!string.IsNullOrEmpty(formAddUsu.usuarioRow?.UsuarioName))
            {
                // if(formAddUsu.usuarioRow?.UsuarioName == null)

                this.usuariosTableAdapter.Insert(
                    formAddUsu.usuarioRow.UsuarioName,
                    true,
                    1,
                    1,
                    DateTime.Now,
                    DateTime.Now
                    );
            }
            this.usuariosTableAdapter.Fill(this.exerciciosFinaisDataSet1.Usuarios);
        }
    }
}
