using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TerasaPorumba
{
    public class Meniu
    {
        public static string filename = @"D:\Visualstudio\TerasaPorumba\TerasaPorumba\menu.json";
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
                {
                    Debug.WriteLine($"S-a incercat sa se adauge: produs - {toAdd.denumireProd} id: {toAdd.id} ");
                    return true;
                }
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
        public string RetProdus()
        {
            return produse[1].denumireProd;
        }

        public void saveAsJson()
        {
            if (!File.Exists(filename))
            {
                using FileStream stream = File.Create(filename);
                JsonSerializer.Serialize(stream, produse);
            }
            else
            {
                File.WriteAllText(filename,JsonSerializer.Serialize(produse));
            }
           // MessageBox.Show("A fost salvat in fisier cu succes!");
        }

        public void loadFromJson()
        {
            string jsonString = File.ReadAllText(filename);
            JsonSerializer.Deserialize<List<Produs>>(jsonString).ForEach(AdaugaProdus);
        }

      
    }
}
