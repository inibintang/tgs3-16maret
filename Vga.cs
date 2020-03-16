using System;

namespace TheSuperComputer
{
    class Vga
    {
        private String brand;
        private int graphicClock;
        private int memoryClock;

        public Vga(String brand, int graphicClock, int memoryClock)
        {
            this.brand = brand;
            this.graphicClock = graphicClock;
            this.memoryClock = memoryClock;
        }

        public String getBrand()
        {
            return this.brand;
        }

        public int getGraphicClock()
        {
            return this.graphicClock;
        }

        public int getMemoryClock()
        {
            return this.memoryClock;
        }

        public override string ToString()
        {
            return $"vga brand: {this.brand}; vga clock graphic: {this.graphicClock}; vga clock memory {this.memoryClock}";
        }

    }
}
