using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Racun : UserControl
    {
        public Racun()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            radioButton3.ForeColor = System.Drawing.Color.Red;

            cmb_artikal.Items.Clear();
            cmb_artikal.Items.Add("Prirodno");
            cmb_artikal.Items.Add("Vestacko");
            cmb_artikal.Items.Add("Domace");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Green;
            radioButton3.ForeColor = System.Drawing.Color.Red;

            cmb_artikal.Items.Clear();
            cmb_artikal.Items.Add("B1");
            cmb_artikal.Items.Add("B2");
            cmb_artikal.Items.Add("B3");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            radioButton3.ForeColor = System.Drawing.Color.Green;
            cmb_artikal.Items.Clear();
            cmb_artikal.Items.Add("C1");
            cmb_artikal.Items.Add("C2");
            cmb_artikal.Items.Add("C3");
        }

        private void cmb_artikal_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_artikal.SelectedItem.ToString() == "Prirodno")
            {
                txt_cena.Text = "50";
            }
            else if (cmb_artikal.SelectedItem.ToString() == "Vestacko")
            {
                txt_cena.Text = "100";
            }
            else { txt_cena.Text = "0"; }
            txt_ukupno1.Text = "";
            textBox2.Text = "";
        }

      

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                txt_ukupno1.Text = (Convert.ToInt16(txt_cena.Text) * Convert.ToInt16(textBox2.Text)).ToString();
            } }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = cmb_artikal.SelectedItem.ToString();
            arr[1] = txt_cena.Text;
            arr[2] = textBox2.Text;
            arr[3] = txt_ukupno1.Text;

            ListViewItem lv1 = new ListViewItem(arr);
            listView1.Items.Add(lv1);

            txt_ukupno.Text = (Convert.ToInt16(txt_ukupno.Text) + Convert.ToInt16(txt_ukupno1.Text)).ToString();


        }

        private void txt_popust_TextChanged(object sender, EventArgs e)
        {
            if (txt_popust.Text.Length > 0)
            { 
            txt_neto.Text = (Convert.ToInt16(txt_ukupno.Text) - Convert.ToInt16(txt_popust.Text)).ToString();

            }
        }

        private void txt_placeno_TextChanged(object sender, EventArgs e)
        {
            if (txt_placeno.Text.Length > 0)
            {
                txt_balans.Text = (Convert.ToInt16(txt_neto.Text) - Convert.ToInt16(txt_placeno.Text)).ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) {

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        txt_ukupno.Text = (Convert.ToInt16(txt_ukupno.Text) - Convert.ToInt16(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();
                    }
                }
            }
        }
    }
}
