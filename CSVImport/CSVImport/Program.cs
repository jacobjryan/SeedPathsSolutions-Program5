using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSVImport
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RealEstateSale> RealEstateData = new List<RealEstateSale>();
            bool skipFirstLine = true;
            using (StreamReader reader = new StreamReader("realestatedata.csv"))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    if (skipFirstLine)
                    {
                        skipFirstLine = false;
                    } else {
                        RealEstateData.Add(new RealEstateSale(line));
                    }
                    
                   
                    
                }
            }

            //Display the average square footage of a Condo sold in the city of Sacramento
            Console.WriteLine(RealEstateData.Where(x=> x.City.ToLower() == "sacramento" && x.EstateType == EstateType.MultiFamily).Average(x=> x.SquareFootage));
            //Display the total sales of all residential homes in Elk Grove
            Console.WriteLine(RealEstateData.Where(x => x.City.ToLower() == "elk grove" && x.EstateType == EstateType.Residential).Sum(x => x.SalePrice).ToString("C"));
            //Display the total number of residential homes sold in the following zip codes: 95842, 95825, 95815
            Console.WriteLine(RealEstateData.Where(x => "95842 95825 95815".Contains(x.Zip) && x.EstateType == EstateType.Residential).Count());
            //Display the average sale price of a lot in sacramento
            Console.WriteLine(RealEstateData.Where(x => x.City.ToLower() == "sacramento" && x.EstateType == EstateType.RawLand).Average(x => x.SalePrice).ToString("C"));
            //Display the average price per square foot for a condo in Sacramento
            Console.WriteLine(Math.Round(RealEstateData.Where(x => x.City.ToLower() == "sacramento" && x.EstateType == EstateType.Condo).Average(x =>  x.SalePrice / x.SquareFootage),2));
            //Display the number of all sales that were completed on a wednesday
            Console.WriteLine(RealEstateData.Count(x => x.SaleDate.DayOfWeek == DayOfWeek.Wednesday));
            //Display the average number of bedrooms for a residential home in sacramento when the price is greater than 300000
            Console.WriteLine(Math.Round(RealEstateData.Where(x => x.City.ToLower() == "sacramento" && x.EstateType == EstateType.Residential && x.SalePrice > 300000).Average(x => x.Beds), 2));

            //Extra Credit:
            //Display top 5  cities and the number of homes sold (using the GroupBy extension)
            Console.WriteLine(string.Join("\n", RealEstateData.GroupBy(x => x.City).OrderByDescending(x=> x.Count()).Take(5).Select(x => (x.Key + " " + x.Count()).ToString())));
            Console.ReadKey();
        }


    }
   public enum EstateType
        {
            RawLand, Residential, Condo, MultiFamily
        }
    class RealEstateSale
    {
     
        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }
        public int Beds { get; set; }
        public int Baths { get; set; }
        public int SquareFootage { get; set; }
        public EstateType EstateType { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal SalePrice { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public RealEstateSale() { }
        public RealEstateSale(string commaSeperatedValues)
        {
            string[] splitValues = commaSeperatedValues.Split(',');
            this.Street = splitValues[0];
            this.City = splitValues[1];
            this.Zip = splitValues[2];
            this.State = splitValues[3];
            this.Beds = int.Parse(splitValues[4]);
            this.Baths = int.Parse(splitValues[5]);
            this.SquareFootage = int.Parse(splitValues[6]);

            if (this.SquareFootage == 0)
            {
                this.EstateType = EstateType.RawLand;
            }
            else if (splitValues[7] == "Residential") { this.EstateType = CSVImport.EstateType.Residential; }
            else if (splitValues[7] == "Condo") { this.EstateType = CSVImport.EstateType.Condo; }
            else if (splitValues[7] == "Multi-Family") { this.EstateType = CSVImport.EstateType.MultiFamily; }

            this.SaleDate = DateTime.Parse(splitValues[8]);
            this.SalePrice = decimal.Parse(splitValues[9]);
            this.Latitude = float.Parse(splitValues[10]);
            this.Longitude = float.Parse(splitValues[11]);
            
        }
    }
}
