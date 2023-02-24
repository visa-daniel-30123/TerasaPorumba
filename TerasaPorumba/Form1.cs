namespace TerasaPorumba
{
    public partial class Form1 : Form
    {
        public Meniu meniu { get; set; }
        public Form1()
        {
            InitializeComponent();
            meniu = new Meniu();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
           
  
            string filename = @"D:\Visualstudio\TerasaPorumba\Meniu1.txt";
            string text=File.ReadAllText(filename);
            string[] lines = text.Split(Environment.NewLine);

            foreach (string line in lines)
            {
                String [] s = line.Split(' ');
                int n = Int32.Parse(s[0]);
                meniu.AdaugaProdus(new Produs(n, s[1]));
            }
            meniu.AfiseazaProdouse();
            adaugaLaCheckList();
        }

        private void adaugaLaCheckList()
        {
            checkedListBox1.Items.Clear();
            foreach(var x in meniu.produse)
            {
                checkedListBox1.Items.Add(x.Afis());
            }
        }
    }
}