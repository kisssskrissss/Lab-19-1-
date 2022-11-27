using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Comp> comps = new List<Comp>()
            {
                new Comp (){ Code=1, Name ="acer", Type=" 2.5 MISC-процессоры", Frequency=4 , MemoryVolume=64,  OpMem= 8,  VolumeHardD= 512, VolumeVidCard=6, Price=90, Kol=30},
                new Comp (){ Code=2, Name ="acer", Type=" 2.5 MISC-процессоры", Frequency=6, MemoryVolume=32,  OpMem= 2,  VolumeHardD= 512, VolumeVidCard=6, Price=30, Kol=3},
                new Comp (){ Code=3, Name ="acer", Type=" 2.5 MISC-процессоры", Frequency=4 , MemoryVolume=64,  OpMem= 6,  VolumeHardD= 256, VolumeVidCard=3, Price=80, Kol=30},
                new Comp (){ Code=4, Name ="", Type=" 2.5 MISC-процессоры", Frequency=6 , MemoryVolume=32,  OpMem= 4,  VolumeHardD= 512, VolumeVidCard=6, Price=40, Kol=15},
                new Comp (){ Code=5, Name ="", Type=" 2.5 MISC-процессоры", Frequency=6 , MemoryVolume=16,  OpMem= 2,  VolumeHardD= 256, VolumeVidCard=4, Price=90, Kol=20},
                new Comp (){ Code=6, Name ="lg", Type=" 2.5 MISC-процессоры", Frequency=4 , MemoryVolume=64,  OpMem= 8,  VolumeHardD= 512, VolumeVidCard=4, Price=75, Kol=10}
            };
            Console.WriteLine("Введите имя процессора ");
            string name = Console.ReadLine();
            List<Comp> comps1 = comps.Where(x => x.Name == name).ToList();
            Print(comps1);

            Console.WriteLine("Введите ОЗУ ");
            int opMem = Convert.ToInt32(Console.ReadLine());
            List<Comp> comps2 = comps.Where(x => x.OpMem == opMem).ToList();
            Print(comps2);

            List<Comp> comps3 = comps.OrderBy(x => x.Price).ToList();
            Print(comps3);

            IEnumerable<IGrouping<int, Comp>> comps4 = comps.GroupBy(x => x.Price);
            foreach (IGrouping<int, Comp> gr in comps4)

            {
                Console.WriteLine(gr.Key);
                foreach (Comp g in gr)
                {
                    Console.WriteLine($"{ g.Code },{ g.Name }, { g.Type}, { g.Frequency }, { g.MemoryVolume }, { g.OpMem}, { g.VolumeHardD}, { g.VolumeVidCard}, { g.Price}, { g.Kol}");
                }
            }
            Comp comps5 = comps.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{ comps5.Code },{ comps5.Name }, { comps5.Type}, { comps5.Frequency }, { comps5.MemoryVolume }, { comps5.OpMem}, { comps5.VolumeHardD}, { comps5.VolumeVidCard}, { comps5.Price}, { comps5.Kol}");
            Comp comps6 = comps.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{ comps6.Code },{ comps6.Name }, { comps6.Type}, { comps6.Frequency }, { comps6.MemoryVolume }, { comps6.OpMem}, { comps6.VolumeHardD}, { comps6.VolumeVidCard}, { comps6.Price}, { comps6.Kol}");

            Console.WriteLine(comps.Any(x => x.Kol >= 30));
            Console.ReadKey();
        }
        static void Print(List<Comp> comps)
        {
            foreach (Comp g in comps)
            {
                Console.WriteLine($"{ g.Code },{ g.Name }, { g.Type}, { g.Frequency }, { g.MemoryVolume }, { g.OpMem}, { g.VolumeHardD}, { g.VolumeVidCard}, { g.Price}, { g.Kol}");
                Console.WriteLine();
            }
        }
    }
}