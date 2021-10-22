using System;

namespace StateCencuse
{
    class Program
    {
        static void Main(string[] args)
        {
            StateCensusAnalyser obj = new StateCensusAnalyser();
            try
            {
                obj.readCSV();
            }
            catch(RecordNotMatchException e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
