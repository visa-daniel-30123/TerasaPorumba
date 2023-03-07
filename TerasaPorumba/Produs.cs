using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace TerasaPorumba
{
    public class Produs
    {
        public int id { get; set; }
        public String denumireProd { get; set; }
        public int cantitate { get; set; }
        public double pret { get; set; }

        public Produs()
        {
            this.id = 0;
            this.denumireProd = "";
            this.cantitate = 0;
            this.pret = 0.0;
        }
        public Produs(int x, String y)
        {
            this.id = x;
            this.denumireProd = y;
        }
        public Produs(int x, String y,int x1,double pre)
        {
            this.id = x;
            this.denumireProd = y;
            this.cantitate= x1;
            this.pret = pre;
        }
        public int getId() { return this.id; }
        public String getDen() { return this.denumireProd; }

        public String Afis()
        {
            return $"{this.id}  {this.denumireProd}  {this.pret}  {this.cantitate}";
        }

        public void ZeroStock()
        {
            foreach(Produs p1 in MenuSingleton.Meniu.produse)
            {
                p1.cantitate = 0;
            }
        }
        

    }
    
}
