namespace ASharp.Runtime
{
    public class Variable
    {
        public string Name
        {
            get
            {
                return name;
            }
        }
        private string name;
        public int Value
        {
            get
            {
                return value;
            }
        }
        private int value;

        public Variable(string name)
        {
            this.name = name;
        }
        public Variable(string name, int value)
        {
            this.name = name;
            this.value = value;
        }
        public void SetValue(int value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"{name}: {value}";
        }
    }
}