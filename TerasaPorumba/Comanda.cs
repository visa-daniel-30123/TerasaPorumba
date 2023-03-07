using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerasaPorumba
{
    public partial class ComandaButton : Form
    {
        public double CostTotal = 0;
        private int ct = 1;
        public List<Produs> comanda{ get; set; }
        public ComandaButton()
        {
            InitializeComponent();
            comanda=new List<Produs>();
            
            this.FormClosing += (s, args) => { MenuSingleton.Meniu.saveAsJson(); };
        }

        private void adaugalaComandaButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTextBox.Text);
            int cantitatea = int.Parse(cantiTextBox.Text);
            string s = istoricComandaLabel.Text;
  
          
    

            foreach (Produs p in MenuSingleton.Meniu.produse)
            {
            
                if (id==p.id)
                {
                    this.CostTotal += p.pret * cantitatea;
                    s += $"\n{this.ct}. {cantitatea}x{p.denumireProd} = {p.pret * cantitatea}";
                    this.ct++;
                    p.cantitate += cantitatea;
                    Produs p1= new Produs(p.id, p.denumireProd, cantitatea,p.pret);
                    AdaugaComanda(p1);
                    costTotalLabel.Text = this.CostTotal.ToString();
                    istoricComandaLabel.Text = s;
                    idTextBox.Text = string.Empty;
                    cantiTextBox.Text = string.Empty;
                }
               
            }
        }
        public void AdaugaComanda(Produs p)
        {
            ComandaData1.DataSource = null;
            comanda.Add(p);
            comanda.Sort((p, q) => p.id.CompareTo(q.id));
            ComandaData1.DataSource = comanda;
            ComandaData1.Update();
        }
       

        private void finishOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult dr=MessageBox.Show("","Doriti sa finalizati comada?",MessageBoxButtons.YesNo);
            if (dr==DialogResult.Yes)
            {
                this.Close();
                //MessageBox.Show($"Costul total este {this.CostTotal}");
            }
        }

        private void stergeButton_Click(object sender, EventArgs e)
        {
            Produs p1 = new Produs();
            int id = int.Parse(idTextBox.Text);
            int cantitatea = int.Parse(cantiTextBox.Text);
            int canti=0;
            foreach (Produs p in comanda)
            {
                if(p.id == id && p.cantitate==cantitatea)
                {
                    p1 = p;
                    canti = p.cantitate;
                    this.CostTotal = this.CostTotal - p.cantitate * p.pret;
                    break;
                }
            }
           foreach(Produs pe in MenuSingleton.Meniu.produse) {
                if(pe.id == id)
                {
                    pe.cantitate -= canti;
                }
            }
            idTextBox.Text = string.Empty;
            cantiTextBox.Text = string.Empty;
            costTotalLabel.Text =CostTotal.ToString();
            comanda.Remove(p1);
            ComandaData1.DataSource = null;
            comanda.Sort((p, q) => p.id.CompareTo(q.id));
            ComandaData1.DataSource = comanda;
            ComandaData1.Update();

        }
    }
}
