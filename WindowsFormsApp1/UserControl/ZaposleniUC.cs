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
            if (textBox1.Text == "" || dateTimePicker2.Text == "" || textBox3.Text == "")
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
    }
}
