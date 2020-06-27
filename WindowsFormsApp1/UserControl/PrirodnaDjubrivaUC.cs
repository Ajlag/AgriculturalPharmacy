using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp1
{
    public partial class PrirodnaDjubrivaUC : UserControl
    {
        private DBPoljoprivrednaApoteka context;
        private UnitOfWork unit;


        public PrirodnaDjubrivaUC()
        {
            InitializeComponent();
            context = new DBPoljoprivrednaApoteka();
            unit = new UnitOfWork(context);
            var proizvodjac = this.unit.Proizvodjacc.GetAllProizvodjac();//prikazati naziv proizvodjaca u combobox
            comboBox2.Items.Clear();
            foreach (var p in proizvodjac)
            {
                comboBox2.Items.Add(p.naziv.ToString());
            }

            var tipzemljista = this.unit.TipZemljistaa.GetAllTipZemljistas();//prikazati naziv zeljista u combobox
            comboBox1.Items.Clear();
            foreach (var tz in tipzemljista)
            {
                comboBox1.Items.Add(tz.naziv.ToString());
            }

            var prirodnadju = this.unit.PrirodnaDjubrivaa.GetAllPrirodnaDjubrivas();
            foreach (var pdj in prirodnadju)
            {
                dataGridView1.DataSource = prirodnadju;
            }
            dataGridView1.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || dateTimePicker2.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja!");
            }
            else
            {
                try
                {
                    try
                    {
                        var novi = new PrirodnaDjubriva
                        {
                            naziv = textBox1.Text,
                            cena = int.Parse(textBox2.Text),
                            // barKod = int.Parse(textBox3.Text), ovo je visak, barKod je autoIncrement //

                            datumProizvodnje = dateTimePicker2.Value,
                            proizvodjac = comboBox2.Text,
                            TipZemljista = comboBox1.Text

                        };
                        this.unit.PrirodnaDjubrivaa.AddPrirodnaDjubrivas(novi);
                        this.unit.Complete();
                        MessageBox.Show("Dodali ste nova djubriva.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Doslo je do greske, proverite unete podatke");
                    }
                }
                catch
                {
                    MessageBox.Show("Greska");
                }
            }
            dataGridView1.Update();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                string naziv = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                string datumpro = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                string proizvodjac = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                string cena = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                string tipzemljista = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;

                textBox1.Text = naziv;
                dateTimePicker2.Value = DateTime.Parse(datumpro);
                comboBox1.Text = tipzemljista;
                comboBox2.Text = proizvodjac;
                textBox2.Text = cena;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {



                DialogResult Brisi;
                Brisi = MessageBox.Show("Da li ste sigurni?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Brisi == DialogResult.Yes)
                {
                    string barKod = dataGridView1.SelectedRows[0].Cells[6].Value + string.Empty;
                    var prirodnadjubriva = this.unit.PrirodnaDjubrivaa.GetPrirodnaDjubrivaBybarKod(int.Parse(barKod));
                    this.unit.PrirodnaDjubrivaa.DeletePrirodnaDjubriva(prirodnadjubriva);
                    this.unit.Complete();
                    MessageBox.Show("Izbrisali ste hemikaliju.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske, proverite unete podatke");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
            dateTimePicker2.Value = DateTime.Today;
        }
    }
}
