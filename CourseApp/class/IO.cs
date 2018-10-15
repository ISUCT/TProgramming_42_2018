using System.Collections.Generic;
using System;

class IO {
    public static Dictionary<string, double> read() {
        Dictionary<string, double> data = new Dictionary<string, double>();
        data.Add("a", 2.0);
        data.Add("b", 3.0);
        data.Add("xH", 0.11);
        data.Add("xK", 0.36);
        data.Add("dX", 0.05);
        return data;
    }
    public static void write(Dictionary<string, double> data) {
        foreach (KeyValuePair<string, double> kvp in data) {
            Console.WriteLine("For x = {0} y = {1}", kvp.Key, kvp.Value);
        }
    }
}