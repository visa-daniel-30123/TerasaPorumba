using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerasaPorumba
{
    public partial class AdaugaCantitate : Form
    {
        public AdaugaCantitate()
        {
            InitializeComponent();
        }

        private void adaugaCantiButton_Click(object sender, EventArgs e)
        {
            int id=int.Parse(idBoxCantitate.Text);
           int cantitate=int.Parse(cantidCantitate.Text);

            Boolean bol = false;
            foreach (Produs p in MenuSingleton.Meniu.produse)
            {
                if (p.id == id)
                {
                    bol= true; break;
                }
            }
            if (bol)
            {
                foreach (Produs p in MenuSingleton.Meniu.produse)
                {
                    if (p.id == id)
                    {
                        p.cantitate += cantitate;
                    }
                }
                MessageBox.Show($"am adaugat cantitatea de {cantitate} la produsul {id}");
            }
            else
                MessageBox.Show($"nu exista produsul cu id-ul {id}");

            idBoxCantitate.Text = "";
            cantidCantitate.Text = "";
        }

        private void scadeCantButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idBoxCantitate.Text);
            int cantitate = int.Parse(cantidCantitate.Text);

            Boolean bol = false;
            foreach (Produs p in MenuSingleton.Meniu.produse)
            {
                if (p.id == id)
                {
                    bol = true; break;
                }
            }
            if (bol)
            {
                foreach (Produs p in MenuSingleton.Meniu.produse)
                {
                    if (p.id == id)
                    {
                        p.cantitate -= cantitate;
                    }
                }
                MessageBox.Show($"am scazut cantitatea de {cantitate} la produsul {id}");
            }
            else
                MessageBox.Show($"nu exista produsul cu id-ul {id}");


            idBoxCantitate.Text = "";
            cantidCantitate.Text = "";
        }
    }
}
