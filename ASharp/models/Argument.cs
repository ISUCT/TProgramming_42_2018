namespace ASharp.Startup
{
    public class Argument
    {
        public string Short
        {
            get
            {
                return cshort;
            }
        }
        private string cshort;

        public string Full
        {
            get
            {
                return full;
            }
        }
        private string full;

        public bool HasValue
        {
            get
            {
                return hasValue;
            }
        }
        private bool hasValue;
        
        public int DefaultIndex
        {
            get
            {
                return defaultIndex;
            }
        }
        private int defaultIndex;

        public Argument(string cshort, string full, bool hasValue = false, int defaultIndex = -1)
        {
            this.cshort = cshort;
            this.full = full;
            this.hasValue = hasValue;
            this.defaultIndex = defaultIndex;
        }
    }
}