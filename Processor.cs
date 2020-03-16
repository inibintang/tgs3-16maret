using System;

namespace TheSuperComputer
{
    class Processor
    {
        private String series;
        private int core;
        private int cache;

        public Processor()
        {
            
        }

        public void setSeries(String series)
        {
            this.series = series;
        }

        public String getSeries()
        {
            return this.series;
        }

        public void setCore(int core)
        {
            this.core = core;
        }

        public void setCache(int cache)
        {
            this.cache = cache;
        }

        public int getCache()
        {
            return this.cache;
        }

        public override string ToString()
        {
            return $"processor series:{this.series}; processor core: {this.core}; processor cache:{this.cache} ";
        }
    }
}