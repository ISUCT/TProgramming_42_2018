namespace ASharp.Startup
{
    public class Options
    {
        public string Mode
        {
            get
            {
                return mode;
            }
        }
        private string mode = "info";

        public string File
        {
            get
            {
                return file;
            }
        }
        private string file = "";

        public string OutputMode
        {
            get
            {
                return outputMode;
            }
        }
        private string outputMode;

        public string OutputFile
        {
            get
            {
                return outputFile;
            }
        }
        private string outputFile;
        
        public Options(string i_mode, string i_file, string o_mode, string o_file)
        {
            mode = i_mode;
            file = i_file;
            outputMode = o_mode;
            outputFile = o_file;
        }

        public override string ToString()
        {
            return $"Mode: {Mode}\nFile: {File}\nOutput mode: {OutputMode}\nOutput File: {OutputFile}";
        }
    }
}