﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorMK
{
    public partial class Registar : Form
    {
        public Registar()
        {
            InitializeComponent();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoCliente novoCliente = new NovoCliente();

            novoCliente.ShowDialog();

        }

        
    }
}
