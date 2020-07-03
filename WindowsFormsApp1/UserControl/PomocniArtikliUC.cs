using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Migrations;

namespace WindowsFormsApp1
{
    public partial class PomocniArtikliUC : UserControl
    {
        private DBPoljoprivrednaApoteka context;
        private UnitOfWork unit;
        public PomocniArtikliUC()
        {
            InitializeComponent();
            context = new DBPoljoprivrednaApoteka();
            unit = new UnitOfWork(context);
            var proizvodjac = this.unit.Proizvodjacc.GetAllProizvodjac();//prikazati naziv proizvodjaca u combobox
            comboBox2.Items.Clear();
            foreach (var p in proizvodjac)
            {
                comboBox2.Items.Add(p.oznaka.ToString());
            }
         
            
            
            var pomocniartikli = this.unit.PomocniArtikall.GetAllPomocniArtikals();
            foreach (var a in pomocniartikli)
            {
              //  dataGridView1.DataSource = pomocniartikli;
            }
          

            dataGridView1.DataSource = (from a in pomocniartikli
                                        join b in proizvodjac on a.oznakaProzivodjacaFK equals b.oznaka
                                        where a.oznakaProzivodjacaFK == b.oznaka
                                        select new
                                        {
                                            Naziv = a.naziv,
                                            OznakaProizvodjaca = a.oznakaProzivodjacaFK,
                                            Cena = a.cena,
                                            DatumProizvodnje = a.datumProizvodnje,
                                            BarKod = a.barKod,
                                            NazivProizvodjaca = b.naziv
                                        }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || comboBox2.Text == ""  )
                {
                    MessageBox.Show("Morate popuniti sva polja");

                }
                else
                {
                    var novi = new PomocniArtikal// dodavanje artikala u bazi
                    {
                        naziv = textBox1.Text,
                        oznakaProzivodjacaFK =comboBox2.Text,
                        cena = int.Parse(textBox2.Text),
                        datumProizvodnje = dateTimePicker2.Value,


                    };
                    this.unit.PomocniArtikall.AddPomocniArtikals(novi);
                    this.unit.Complete();
                    MessageBox.Show("Dodat je novi artikal.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske, proverite unete podatke");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                string naziv = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                string datumpro = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                string proizvodjac = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                string cena = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
             

                textBox1.Text = naziv;
                dateTimePicker2.Value = DateTime.Parse(datumpro);
               
                comboBox2.Text = proizvodjac;
                textBox2.Text = cena;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            dateTimePicker2.Value = DateTime.Today;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || comboBox2.Text == "" || dateTimePicker2.Text == "")
                {
                    MessageBox.Show("Izaberite artikal koji  želite da izbrišete ili popunite prazna polja!");
                }
                else
                {

                    DialogResult Brisi;
                    Brisi = MessageBox.Show("Da li ste sigurni?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Brisi == DialogResult.Yes)
                    {
                        string barKod = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;

                        var pomocniartikli = this.unit.PomocniArtikall.GetPomocniArtikalBybarKod(int.Parse(barKod));
                        this.unit.PomocniArtikall.DeletePomocniArtikal(pomocniartikli);
                        this.unit.Complete();
                        MessageBox.Show("Izbrisali ste artikal.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske, proverite unete podatke");
            }
        }
    }
}
