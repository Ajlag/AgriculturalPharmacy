﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private DBPoljoprivrednaApoteka context;

        public Form1()
        {
            InitializeComponent();
        }

      

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UnitOfWork unit = new UnitOfWork(context);
            var korisnicko = textBox1.Text;
            var lozinka = textBox2.Text;
            string allowedchar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            try {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Morate popuniti sva polja");

                }


                else if (!textBox2.Text.All(allowedchar.Contains))
                {
                    MessageBox.Show("Proverite lozinku");
                }
                else if (unit.Zaposlenii.CombinationExists(korisnicko, lozinka) == true)
                {
                    this.Hide();
                    Artikli f = new Artikli();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Korisnik ne postoji");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Artikli f = new Artikli();
            f.Show();
        }
    }
}
