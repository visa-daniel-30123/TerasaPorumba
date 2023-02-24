using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerasaPorumba
{
    public class Meniu
    {
        public List<Produs> produse { get; set; }

        public Meniu()
        {
            produse = new List<Produs>();
        }

        public void AdaugaProdus(Produs toAdd)
        {
            if (!Contains(toAdd))
                produse.Add(toAdd);
        }

        private bool Contains(Produs toAdd)
        {
            foreach(var produs in produse)
            {
                if (produs.denumireProd == toAdd.denumireProd && produs.id == toAdd.id)
                    return true;
            }
            return false;
        }

        public void AfiseazaProdouse()
        {
            foreach (var p in produse)
            {
                Debug.WriteLine(p.Afis());
            }
        }
        public String RetProdus()
        {
            return produse[1].denumireProd;
        }

    }
}
