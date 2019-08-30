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
    public partial class fmrUsuarios : Form
    {
        public fmrUsuarios()
        {
            InitializeComponent();
        }

        private void FmrUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.SelectQuery(this.sistemaBibliotecaDBDataSet.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuarioSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.usuariosTableAdapter.DeleteQuery(usuarioSelect.Id);
                        this.usuariosTableAdapter.SelectQuery(sistemaBibliotecaDBDataSet.Usuarios);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoUsuario edicaoUsuario = new frmEdicaoUsuario()
                        {
                            usuariosRow = usuarioSelect
                        };
                        edicaoUsuario.ShowDialog();

                        this.usuariosTableAdapter.Update(edicaoUsuario.usuariosRow);
                    }break;
            }
            this.usuariosTableAdapter.SelectQuery(this.sistemaBibliotecaDBDataSet.Usuarios);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuario formAddUsuario = new frmAdicionarUsuario();
            formAddUsuario.ShowDialog();
            if (!string.IsNullOrEmpty(formAddUsuario.usuariosRow?.Nome))
                this.usuariosTableAdapter.Insert(
                formAddUsuario.usuariosRow.Nome,
                formAddUsuario.usuariosRow.Login,
                formAddUsuario.usuariosRow.Senha,
                formAddUsuario.usuariosRow.Email,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.usuariosTableAdapter.SelectQuery(this.sistemaBibliotecaDBDataSet.Usuarios);
        }
    }
}
