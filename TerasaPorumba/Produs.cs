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
        public Produs()
        {
            this.id = 0;
            this.denumireProd = "";
        }
        public Produs(int x, String y)
        {
            this.id = x;
            this.denumireProd = y;
        }
        public int getId() { return this.id; }
        public String getDen() { return this.denumireProd; }

        public String Afis()
        {
            return this.id + this.denumireProd;
        }
        

    }
    
}
