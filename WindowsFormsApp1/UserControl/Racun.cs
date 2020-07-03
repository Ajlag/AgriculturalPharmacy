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
using System.Drawing.Printing;

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
            try
            {
                string odabrana = cmb_artikal.SelectedItem.ToString();
                var deli = odabrana.Split(' ');
                int cena = int.Parse(deli[1]);
                txt_cena.Text = cena.ToString();
                txt_ukupno1.Text = "";
                textBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske, proverite unete podatke");
            }
        }

      

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text.Length > 0)
                {
                    txt_ukupno1.Text = (Convert.ToInt16(txt_cena.Text) * Convert.ToInt16(textBox2.Text)).ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show("Morate uneti broj"); }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_artikal.Text == "") { MessageBox.Show("Izabrite artikal"); }
            else
            {
               
                    string[] arr = new string[4];
                    arr[0] = cmb_artikal.SelectedItem.ToString();
                    arr[1] = txt_cena.Text;
                    arr[2] = textBox2.Text;
                    arr[3] = txt_ukupno1.Text;


                    if (!string.IsNullOrEmpty(arr[0]) && !string.IsNullOrEmpty(arr[1]) && !string.IsNullOrEmpty(arr[2])
                           && !string.IsNullOrEmpty(arr[3]))
                    {
                        ListViewItem lv1 = new ListViewItem(arr);
                        listView1.Items.Add(lv1);
                        try { txt_ukupno.Text = (Convert.ToInt16(txt_ukupno.Text) + Convert.ToInt16(txt_ukupno1.Text)).ToString(); }
                        catch (Exception ex) { txt_ukupno.Text = ""; }
                        var novi = new Narudzbina
                        {
                            naziv = cmb_artikal.Text,
                            cena = int.Parse(txt_cena.Text),

                            kolicina = int.Parse(textBox2.Text),
                            datum = DateTime.Today


                        };
                        this.unit.Narudzbinaa.AddNarudzbinas(novi);
                        this.unit.Complete();


                    }
                    else
                    {
                        MessageBox.Show("Popunite sva polja.");
                        return;
                    }
            

            }
                       

        }

        private void txt_popust_TextChanged(object sender, EventArgs e)
        {

            try
            {
               

                if (txt_popust.Text.Length > 0)
                {

                    txt_neto.Text = (Convert.ToDouble(txt_ukupno.Text) - Convert.ToDouble(txt_ukupno.Text) * (Convert.ToDouble(txt_popust.Text) / 100)).ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show("Morate uneti broj"); }



        }

        private void txt_placeno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_placeno.Text.Length > 0)
                {
                    txt_balans.Text = (Convert.ToDouble(txt_neto.Text) - Convert.ToDouble(txt_placeno.Text)).ToString();

                }
            }
            catch (Exception ex) { MessageBox.Show("Morate uneti broj"); }
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

        private void button3_Click(object sender, EventArgs e)
        {      

            try
            {
               double ukupno = double.Parse(txt_neto.Text);
               int placeno = int.Parse(txt_placeno.Text);
                double kusur = double.Parse(txt_balans.Text);
                string r = "Račun :" ;
                string u = "Sve ukupno :"+ukupno;
                string pl = "Placeno :" + placeno;
                string k = "Kusur :" + kusur;
                string na = "Naziv artikla :" ;
                string c = "Cena";
                string kol = "Količina";
                string uk = "Ukupno";
                string nl = "\n";
                PrintDocument p = new PrintDocument();
                p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
                {
                   e1.Graphics.DrawString( "  " +u + "\n  "  + pl + "\n  " + k + nl, new Font("Arial Bold", 11), new SolidBrush(Color.Black), new RectangleF(0, 0, 0, 0));
                    e1.Graphics.DrawString(" ____________________________________________________________________", new Font("Arial Bold", 11), new SolidBrush(Color.Black), new RectangleF(0, 5, 0,10 ));

                    // e1.Graphics.DrawString(" \t" +na+ "\t" +c+"\t"+kol+"\t"+uk+"\t"+"\n"+"\n", new Font("Arial Bold", 11), new SolidBrush(Color.Black), new RectangleF(0, 0, 0,300));

                       e1.Graphics.DrawString(" "+ r +" ", new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 55,0,0));
                    e1.Graphics.DrawString("\n " + nl+nl+"\n"+"\b"+nl, new Font("Arial Bold", 11), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
                   e1.Graphics.DrawString("\t" + na + "\t \t" + c + "\t \t" + kol + "\t \t" + uk + "\t \t" +  "\n", new Font("Arial Bold", 11), new SolidBrush(Color.Black), new RectangleF(0, 55, 0, 0));

                    
                    var startX = 0;
                    var startY = 35;
                    var Offset = 0;
                   
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        int ii = 1;
                        ii++;
                        string prvi = listView1.Items[i].SubItems[0].Text;
                        string drugi = listView1.Items[i].SubItems[1].Text;
                        string treci = listView1.Items[i].SubItems[2].Text;
                        string cetvrti = listView1.Items[i].SubItems[3].Text;
                       
                      
                       
                    e1.Graphics.DrawString(" "+nl+nl+ "\t " + prvi  + "\t"+"\t" +drugi+ "\t"+"\t"+treci + "\t" +"\t"+ cetvrti+ "\n"+"\n"+nl, new Font("Arial Bold", 11), new SolidBrush(Color.Black), startX, startY + Offset);

                        Offset = Offset + 15;
                    
                    }

                //    e1.Graphics.DrawString("\n " +nl+ "\n", new Font("Arial Bold", 11), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
                    //e1.Graphics.DrawString(nl+"  " +nl+nl+ u + "\n" +nl+ nl+pl+ "\n" + " " +nl+ k+nl, new Font("Arial Bold", 11), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));

                };
                try
                {
                    p.Print();
                }
                catch (Exception ex)
                {
                    throw new Exception("Exception Occured While Printing", ex);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string prvi = listView1.Items[i].SubItems[0].Text;
                string drugi = listView1.Items[i].SubItems[1].Text;
                string treci = listView1.Items[i].SubItems[2].Text;
                string cetvrti = listView1.Items[i].SubItems[3].Text;

                var novi = new Narudzbina
                {
                    naziv = prvi,
                    cena = int.Parse(drugi),

                    kolicina = int.Parse(treci),
                    datum = DateTime.Today


                };
                this.unit.Narudzbinaa.AddNarudzbinas(novi);
                this.unit.Complete();
            }
            }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox2.Text = "";
            txt_balans.Text = "";
            txt_cena.Text = "";
            txt_neto.Text = "";
            txt_placeno.Text = "";
            txt_popust.Text = "";
            txt_ukupno.Text = "";
            txt_ukupno1.Text = "";
            cmb_artikal.Text = "";

        }

      
        }
    }

