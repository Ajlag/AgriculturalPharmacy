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
            label2.Text = DateTime.Now.ToString("MM/dd/yyyy");
            label3.Text = DateTime.Now.ToString("H:mm:ss");
        }

    

    
      
       
      
       

     

      

        private void button2_Click(object sender, EventArgs e)
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

       
        

       
      

        



        

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            PrirodnaDjubrivaUC p = new PrirodnaDjubrivaUC();
            p.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(p);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            VestackaDjubrivaUC v = new VestackaDjubrivaUC();
            v.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(v);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            SemenaUC s = new SemenaUC();
            s.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(s);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            HemikalijeUC h = new HemikalijeUC();
            h.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(h);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            PomocniArtikliUC s = new PomocniArtikliUC();
            s.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(s);
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Racun s = new Racun();
            s.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
           panel1.Controls.Add(s);
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            ZaposleniUC s = new ZaposleniUC();
            s.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
           panel1.Controls.Add(s);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Menu.Width == 193)
            {
                Menu.Visible = false;
                Menu.Width = 50;
                panel4.Width = 80;
                AnimationMenu.Show(Menu);


                    
            


            }
            else
            {
                Menu.Visible = false;
                Menu.Width = 193;
                panel4.Width = 217;
                AnimationMenuBack.Show(Menu);
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (Menu.Width == 193)
            {
                Menu.Visible = false;
                Menu.Width = 50;
                panel4.Width = 80;
                AnimationMenu.Show(Menu);






            }
            else
            {
                Menu.Visible = false;
                Menu.Width = 193;
                panel4.Width = 217;
                AnimationMenuBack.Show(Menu);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        { 
            this.Hide();
            Artikli f = new Artikli();
            f.Show();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

  






        //private void Artikli_Load(object sender, EventArgs e)
        //{
        //    label2.Text = DateTime.Now.ToString("MM/dd/yyyy  H:mm:ss");
        //}


    }
}
