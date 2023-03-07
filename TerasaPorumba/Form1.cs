using System.Diagnostics.Tracing;

namespace TerasaPorumba
{
    public partial class Form1 : Form
    {
        private int ct = 0;
        public Form1()
        {
            InitializeComponent();
            MenuSingleton.Meniu.loadFromJson();
            MenuSingleton.Meniu.AfiseazaProdouse();
          
            MenuSingleton.Meniu.produse.Sort((p, q) => p.id.CompareTo(q.id));
            dataGridView1.DataSource = MenuSingleton.Meniu.produse;
            this.FormClosing += (s, args) => {
                MenuSingleton.Meniu.saveAsJson();
            };

           
        }

        private void readButton_Click(object sender, EventArgs e)
        {


            //string filename = @"D:\Visualstudio\TerasaPorumba\Meniu1.txt";
            //string text=File.ReadAllText(filename);
            //string[] lines = text.Split(Environment.NewLine);

            //foreach (string line in lines)
            //{
            //    String [] s = line.Split(' ');
            //    int n = Int32.Parse(s[0]);
            //    meniu.AdaugaProdus(new Produs(n, s[1]));
            //}


            ComandaButton comanda=new ComandaButton();
            comanda.Show();
            comanda.Closed += (s, args) => { refreshDataGrid(); };

        }


        private void button1_Click(object sender, EventArgs e)
        {
           foreach(Produs p in MenuSingleton.Meniu.produse)
            {
                p.cantitate = 0;
               
            }
            refreshDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refreshDataGrid();
        }

        private void refreshDataGrid()
        {
            dataGridView1.DataSource = null;
            MenuSingleton.Meniu.produse.Sort((p, q) => p.id.CompareTo(q.id));
            dataGridView1.DataSource = MenuSingleton.Meniu.produse;
            dataGridView1.Update();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AdaugaProdus adauga = new AdaugaProdus();
            adauga.Show();
            adauga.Closed += (s, args) => { refreshDataGrid(); };
        }

        private void button4_Click(object sender, EventArgs e)
        {
           /* StergeProdus StergeProd = new StergeProdus();
            StergeProd.Show();
            StergeProd.Closed += (s, args) => { refreshDataGrid(); };*/
           ProduseButoane Pd=new ProduseButoane();
            Pd.Show();
        }

        private void adaugamargaButton_Click(object sender, EventArgs e)
        {
            ct++;
            AdaugaCantitate AC = new AdaugaCantitate();
            AC.Text= $"Comanda numarul {ct}";
            AC.Update();
            AC.Show();
            AC.Closed += (s, args) => { refreshDataGrid(); };
            Label l=new Label();
            l.Text = "comanda";
            l.Location = new Point(10, 10);
            l.Visible= true;
            AC.Controls.Add(l);

        }
    }
}