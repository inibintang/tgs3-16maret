using System;

namespace TheSuperComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor lgMonitor = new Monitor("1280x600", true, 32);
            Printer hpPrinter = new Printer("HP", "MP102",50);

            Vga nvidiaVga = new Vga("Nvidia", 2054, 2054);
            Ram samsungRam = new Ram("DDR4", 5000, 8000);
            Processor intelProcessor = new Processor();
            intelProcessor.setCache(254);
            intelProcessor.setCore(8);
            intelProcessor.setSeries("core i7 8th gen");

            Computer computer = new
                Computer.Builder(samsungRam, nvidiaVga, intelProcessor)
                .withMonitor(lgMonitor)
                .withPrinter(hpPrinter)
                .build();
            Console.WriteLine(computer.ToString());
        }
    }
}
