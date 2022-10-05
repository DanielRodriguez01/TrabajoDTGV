using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoDTGV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtagregar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text !="" && txtgmail.Text != "")
            {
                dgvdatos.Rows.Add(txtnombre.Text , txtgmail.Text);
                txtnombre.Text = "";
                txtgmail.Text = ""; 
                MessageBox.Show("Informacion Guardada");

            }
        }

       

        private void dgvprofesor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtagregar2_Click(object sender, EventArgs e)
        {
            if (txt_nombreprofesor.Text != "" && txtMateria.Text != "")
            {
                dgvprofesor.Rows.Add(txt_nombreprofesor.Text, txtMateria.Text);
                txt_nombreprofesor.Text = "";
                txtMateria.Text = "";
                MessageBox.Show("Informacion Guardada");

            }

        }
    }
}
