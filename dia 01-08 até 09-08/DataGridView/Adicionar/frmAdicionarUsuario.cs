﻿using DataGridView.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView.Adicionar
{
    public partial class frmAdicionarUsuario : Form
    {
        public frmAdicionarUsuario()
        {
            InitializeComponent();
        }
        public Usuario usuarioRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            usuarioRow = new Usuario
            {
                UsuarioName = textBox1.Text
            };
            this.Close();

        }
    }
}
