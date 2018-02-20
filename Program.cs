using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tenttitehtava2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Piste> pistelista = new List<Piste>();

            Piste p1 = new Piste("Piste1",20.3,43.2);
            Piste p2 = new Piste("Piste2", 23.3, 41.2);

            pistelista.Add(p1);
            pistelista.Add(p2);

            string s = JsonConvert.SerializeObject(pistelista);
            Console.WriteLine(s);

            FileStream stream = new FileStream(@"M:\Verkko-ohjelmointi\Tenttitehtava2\bindataTentti.bin", FileMode.Open);

            BinaryReader br = new BinaryReader(stream);
        


                br.BaseStream.Seek(0, SeekOrigin.Begin);

            while (br != null && br.BaseStream.Position < br.BaseStream.Length)
            {


                string n = br.ReadString();
                double dx = br.ReadDouble();
                double dy = br.ReadDouble();

                Console.WriteLine(n);
                Console.WriteLine(dx);
                Console.WriteLine(dy);

                Piste p = new Piste(n, dx, dy);

                pistelista.Add(p);
            }
            
            string s2 = JsonConvert.SerializeObject(pistelista);
            Console.WriteLine(s2);
        }
    }
}
