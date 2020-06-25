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
                comboBox2.Items.Add(p.naziv.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var novi = new PomocniArtikal// dodavanje artikala u bazi
                {
                    naziv = textBox1.Text,
                    proizvodjac = comboBox2.Text,
                    cena = int.Parse(textBox2.Text),
                    datumProizvodnje = dateTimePicker2.Value,
                  

                };
                this.unit.PomocniArtikall.AddPomocniArtikals(novi);
                this.unit.Complete();
                MessageBox.Show("Dodat je novi artikal.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske, proverite unete podatke");
            }
        }
    }
}
