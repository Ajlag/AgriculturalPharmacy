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
    public partial class ZaposleniUC : UserControl
    {
        private DBPoljoprivrednaApoteka context;
        private UnitOfWork unit;
        public ZaposleniUC() 
        {
            InitializeComponent();
            context = new DBPoljoprivrednaApoteka();
            unit = new UnitOfWork(context);
            var zaposleni = this.unit.Zaposlenii.GetAllZaposlenis();
            foreach (var z in zaposleni)
            {
                dataGridView1.DataSource = zaposleni;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || dateTimePicker2.Text == "" || textBox3.Text == "" || textBox2.Text=="" || textBox4.Text=="" )
            {
                MessageBox.Show("Morate popuniti sva polja!");
            }
            else
            {
                try
                {
                    try
                    {
                        var novi = new Zaposleni

                        {
                            ime = textBox1.Text,
                            prezime = textBox3.Text,
                            // barKod = int.Parse(textBox3.Text), ovo je visak, barKod je autoIncrement //

                            datumRodjenja = dateTimePicker2.Value,
                            KorisnickoIme=textBox2.Text,
                            lozinka=textBox4.Text

                        };
                        this.unit.Zaposlenii.AddZaposleni(novi);
                        this.unit.Complete();
                        MessageBox.Show("Dodali ste novog zaposlenog.");
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
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Value != null) {

                e.Value = new string('*', e.Value.ToString().Length);
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            dateTimePicker2.Value = DateTime.Today;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || dateTimePicker2.Text == "" || textBox3.Text == "" || textBox2.Text == "" )
                {
                    MessageBox.Show("Izaberite osobu koju želite da izbrišete ili unesite podatke!");
                }

                else
                {
                    DialogResult Brisi;
                    Brisi = MessageBox.Show("Da li ste sigurni?", "Izbriši", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Brisi == DialogResult.Yes)
                    {
                        string korisnickoime = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                        var zaposleni = this.unit.Zaposlenii.GetZaposleniByKorisnickoIme(korisnickoime);
                        this.unit.Zaposlenii.DeleteZaposleni(zaposleni);
                        this.unit.Complete();
                        MessageBox.Show("Izbrisali ste odabranu osobu.");
                    }
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

                string ime = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                string datumro = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                string prezime = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                string korisnickoime = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
            

                textBox1.Text = ime;
                dateTimePicker2.Value = DateTime.Parse(datumro);
                
                textBox2.Text = korisnickoime;
                textBox3.Text = prezime;

            }
        }
    }
}
