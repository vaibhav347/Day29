using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StateCencuse
{
    public class StateCensusAnalyser
    {
        public void readCSV()
        {
            int count = 0;
            string path = @"C:\Day29\StateCencuse\Vishal2.csv";
            string path2 = @"C:\Day29\StateCencuse\Vishal.csv";
            using (var reader2 = new StreamReader(path2))
            using (var csv2 = new CsvReader(reader2, System.Globalization.CultureInfo.InvariantCulture))
            {
                var record2 = csv2.GetRecords<CSVData2>().ToList();
                using (var reader = new StreamReader(path))
                using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
                {

                    var record = csv.GetRecords<CSVData>().ToList();
                    foreach (CSVData2 data2 in record2)
                    {
                        foreach (CSVData data in record)
                        {
                            if (data2.Population==data.Population)
                            {
                                Console.WriteLine(data.State);
                                Console.WriteLine(data.Population);
                                count++;
                            }
                        }
                    }
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Matched Data : " + (count-2));


                }

            }
        }

    }
}
