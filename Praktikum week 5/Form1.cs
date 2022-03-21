using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_week_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int JumlahListBox = listBoxKoleksi.Items.Count;
            int ngecek = 0;
            if (listBoxKoleksi.Items.Count == 0)
            {
                listBoxKoleksi.Items.Add(txtBoxInputData.Text);
            }
            else

            if (listBoxKoleksi.Items.Contains(txtBoxInputData.Text))
                
            {
                MessageBox.Show("Input kembar");
            }
            else
            {
                listBoxKoleksi.Items.Add(txtBoxInputData.Text);
            }
        }

        private void checkBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked==true)
            {
                if (radioButtonMerah.Checked==true)
                {
                    labelHasilOutput.ForeColor = Color.Red;
                }
                
                else if (radioButtonBiru.Checked==true)
                {
                    labelHasilOutput.ForeColor = Color.Blue;
                }
               
             
            }
            else
            {
                labelHasilOutput.ForeColor = Color.Black;
            }
        }

        private void listBoxKoleksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelHasilOutput.Text = listBoxKoleksi.SelectedItem.ToString();
        }

        private void radioButtonMerah_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked==true)
            {
                if (radioButtonMerah.Checked==true)
                {
                    labelHasilOutput.ForeColor = Color.Red;
                }
            }
        }

        private void radioButtonBiru_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true)
            {
                if (radioButtonBiru.Checked == true)
                {
                    labelHasilOutput.ForeColor = Color.Blue;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxKoleksi.Items.Clear();
            labelHasilOutput.Text = "";
            checkBoxAktif.Checked = false;
            radioButtonMerah.Checked = true;
            txtBoxInputData.Text = "";
        }
    }
}
