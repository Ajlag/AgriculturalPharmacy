using System;
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
    public partial class Artikli : Form
    {
        private DBPoljoprivrednaApoteka context;
        public Artikli()
        {
            InitializeComponent();
        }

        private void semenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           SemenaUC s = new SemenaUC();
            s.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(s);
        }

        private void hemikalijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HemikalijeUC h = new HemikalijeUC();
            h.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(h);

        }

        private void prirodnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrirodnaDjubrivaUC p = new PrirodnaDjubrivaUC();
            p.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(p);
        }

        private void veštačkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VestackaDjubrivaUC v = new VestackaDjubrivaUC();
            v.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(v);
        }

        private void pomoćniArtikliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PomocniArtikliUC s = new PomocniArtikliUC();
            s.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Izlaz;
            Izlaz = MessageBox.Show("Da li zelite da se odjavite?", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Izlaz == DialogResult.Yes)
            {
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.ShowDialog();
            }
        }

        private void informaciojeOZaposlenimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZaposleniUC s = new ZaposleniUC();
            s.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(s);
        }

       
    }
}
