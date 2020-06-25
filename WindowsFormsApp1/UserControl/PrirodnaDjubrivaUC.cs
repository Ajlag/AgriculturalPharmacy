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
        }

        
    }
}
