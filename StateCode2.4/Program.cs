using System;

namespace StateCencuse
{
    class Program
    {
        static void Main(string[] args)
        {
            StateCensusAnalyser obj = new StateCensusAnalyser();
            obj.readCSV();
        }
    }
}
