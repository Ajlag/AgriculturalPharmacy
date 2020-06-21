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

        public PrirodnaDjubrivaUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || dateTimePicker2.Text == "")
            {
                MessageBox.Show("Morate popuniti sva polja!");
            }
            else
            {
                try
                { UnitOfWork unit = new UnitOfWork(context);
 //unit.PrirodnaDjubrivaa.AddPrirodnaDjubrivas(PrirodnaDjubriva(textBox1.Text,comboBox2.ToString(),int.Parse(textBox2.Text),comboBox1.ToString(), dateTimePicker2.Value.ToString("dd/MM/yyyy"), int.Parse(textBox3.Text)));
                  
                }
                catch
                {
                    MessageBox.Show("Član već postoji!");
                }
            }
        }

        
    }
}
