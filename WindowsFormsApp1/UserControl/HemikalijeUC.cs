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
            //var hemikalije = this.unit.Hemikalijee.GetAllHemikalijes();
       //     foreach (var h in hemikalije)
         //   {
           //     dataGridView1.DataSource=h.ToString();
            //}

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
                    proizvodjac = textBox5.Text,
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
            string odabrana = dataGridView1.SelectedRows.ToString();
            var deli = odabrana.Split(' ');
            int cena = int.Parse(deli[1]);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var hemikalije = this.unit.Hemikalijee.GetAllHemikalijes();
            foreach (var h in hemikalije)
            {
                dataGridView1.DataSource = h.ToString();
            }
        }
    }
}
