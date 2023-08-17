using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser
{
    public class StateCensusAnalyser
    {
        public static int ReadStateCensusData(string filePath)
        {

            if (!File.Exists(filePath))
            {
                throw new CensusAnalyserException(CensusAnalyserException.ExceptionType.FILE_INCORRECT, "File Not Exist");
            }
            if (!Path.GetExtension(filePath).Equals(".csv"))
            {
                throw new CensusAnalyserException(CensusAnalyserException.ExceptionType.FILE_NOT_EXIST, "File Not Exist");
            }
            if (!File.ReadAllLines(filePath)[0].Equals("State,Population,AreaInSqKm,DensityPerSqKm"))
            {
                throw new CensusAnalyserException(CensusAnalyserException.ExceptionType.HEADER_INCORRECT, "Header incorrect");
            }
            using (var reader = new StreamReader(filePath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<StateCencusData>().ToList();
                    Console.WriteLine("Read Data From CSV");
                    foreach (var data in records)
                    {
                        Console.WriteLine(data.State + "---" + data.Population + "---" + data.AreaInSqKm + "---" + data.DensityPerSqKm);
                    }
                    return records.Count() - 1;
                }
            }
        }
    }
}
