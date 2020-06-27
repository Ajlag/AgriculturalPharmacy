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
    public partial class HemikalijeUC : UserControl
    {
        private DBPoljoprivrednaApoteka context;
        private UnitOfWork unit;

        public HemikalijeUC()
        {
            InitializeComponent();
            context = new DBPoljoprivrednaApoteka();
            unit = new UnitOfWork(context);
            var hemikalije = this.unit.Hemikalijee.GetAllHemikalijes();
         foreach (var h in hemikalije)
           {
                dataGridView1.DataSource=hemikalije;
            }

            var tipzemljista = this.unit.TipZemljistaa.GetAllTipZemljistas();
            comboBox1.Items.Clear();
            foreach (var tz in tipzemljista)
            {
                comboBox1.Items.Add(tz.naziv.ToString());
            }
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            // var naziv = textBox1.Text;
            // string godina = dataGridView1.ToString();
            try
            {
                var novi = new Hemikalije
                {
                    naziv = textBox1.Text,
                    cena = int.Parse(textBox2.Text),
                   // barKod = int.Parse(textBox3.Text), ovo je visak, barKod je autoIncrement //
                    stepenOtrovnosti = textBox4.Text,
                    datumProizvodnje = dateTimePicker2.Value,
                    proizvodjac = comboBox2.Text,
                    TipZemljista= comboBox1.Text

                };
                this.unit.Hemikalijee.AddHemikalijes(novi);
                this.unit.Complete();
                MessageBox.Show("Dodata je nova hemikalija.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Doslo je do greske, proverite unete podatke");
            }
          
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           // string odabrana = dataGridView1.SelectedRows.ToString();
            //var deli = odabrana.Split(' ');
            //int cena = int.Parse(deli[1]);
           
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                string naziv = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                string datumpro = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                string proizvodjac = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                string cena = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                string tipzemljista = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                string stepenotrovnosti = dataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
                

                textBox1.Text = naziv;
              dateTimePicker2.Value = DateTime.Parse(datumpro);
                comboBox1.Text = tipzemljista;
                comboBox2.Text = proizvodjac;
                textBox2.Text = cena;
                textBox4.Text = stepenotrovnosti;
              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
            dateTimePicker2.Value = DateTime.Today;
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
                var hemikalija = this.unit.Hemikalijee.GetHemikalijelBybarKod(int.Parse(barKod));
                this.unit.Hemikalijee.DeleteHemikalije(hemikalija);
                this.unit.Complete();
                MessageBox.Show("Izbrisali ste hemikaliju.");
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doslo je do greske, proverite unete podatke");
            }

        }

       
    }
}
