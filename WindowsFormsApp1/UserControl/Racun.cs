using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace WindowsFormsApp1
{
    public partial class Racun : UserControl
    {
        private DBPoljoprivrednaApoteka context;
        private UnitOfWork unit;
        public Racun()
        {
            InitializeComponent();
            context = new DBPoljoprivrednaApoteka();
            unit = new UnitOfWork(context);
        }
       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            radioButton3.ForeColor = System.Drawing.Color.Red;
            radioButton4.ForeColor = System.Drawing.Color.Red;
            radioButton5.ForeColor = System.Drawing.Color.Red;
            var prirodnadj = this.unit.PrirodnaDjubrivaa.GetAllPrirodnaDjubrivas();
            cmb_artikal.Items.Clear();
            foreach (var pdj in prirodnadj)
            {
                cmb_artikal.Items.Add(pdj.ToString());
            }
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Green;
            radioButton3.ForeColor = System.Drawing.Color.Red;
            radioButton4.ForeColor = System.Drawing.Color.Red;
            radioButton5.ForeColor = System.Drawing.Color.Red;
            var semena = this.unit.Semenaa.GetAllSemena();
            cmb_artikal.Items.Clear();
            foreach (var s in semena)
            {
                cmb_artikal.Items.Add(s.ToString());
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            radioButton3.ForeColor = System.Drawing.Color.Green;
            radioButton4.ForeColor = System.Drawing.Color.Red;
            radioButton5.ForeColor = System.Drawing.Color.Red;
            var hemikalije = this.unit.Hemikalijee.GetAllHemikalijes();
            cmb_artikal.Items.Clear();
            foreach(var h in hemikalije)
            {
                cmb_artikal.Items.Add(h.ToString());
            }
          
        }

        private void cmb_artikal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string odabrana = cmb_artikal.SelectedItem.ToString();
            var deli = odabrana.Split(' ');
            int cena = int.Parse(deli[1]);
            txt_cena.Text = cena.ToString();
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
            if(!string.IsNullOrEmpty(arr[0]) && !string.IsNullOrEmpty(arr[1]) && !string.IsNullOrEmpty(arr[2])
               && !string.IsNullOrEmpty(arr[3])) {
                ListViewItem lv1 = new ListViewItem(arr);
                listView1.Items.Add(lv1);
                try { txt_ukupno.Text = (Convert.ToInt16(txt_ukupno.Text) + Convert.ToInt16(txt_ukupno1.Text)).ToString(); }
                catch (Exception ex) { txt_ukupno.Text = ""; }
            }
            else
            {
                MessageBox.Show("Popunite sva polja.");
                return;
            }
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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            radioButton3.ForeColor = System.Drawing.Color.Red;
            radioButton4.ForeColor = System.Drawing.Color.Green;
            radioButton5.ForeColor = System.Drawing.Color.Red;
            var pomocniartik = this.unit.PomocniArtikall.GetAllPomocniArtikals();
            cmb_artikal.Items.Clear();
            foreach (var poma in pomocniartik)
            {
                cmb_artikal.Items.Add(poma.ToString());
            }
        }

        private void textBox2_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            radioButton3.ForeColor = System.Drawing.Color.Red;
            radioButton4.ForeColor = System.Drawing.Color.Red;
            radioButton5.ForeColor = System.Drawing.Color.Green;
            var vestackadjubriva = this.unit.VestackaDjubrivaa.GetAllVestackaDjubrivas();
            cmb_artikal.Items.Clear();
            foreach (var vdj in vestackadjubriva)
            {
                cmb_artikal.Items.Add(vdj.ToString());
            }
        }
    }
}
