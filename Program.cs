using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            Country country1 = new Country() { Code = "AUS", Name = "AUSTRALIA", Capital = "Canberra" };
            Country country2 = new Country() { Code = "IND", Name = "INDIA", Capital = "New Delhi" };
            Country country3 = new Country() { Code = "USA", Name = "UNITED STATES", Capital = "Washington D.C." };
            Country country4 = new Country() { Code = "GBR", Name = "UNITED KINGDOM", Capital = "London" };
            Country country5 = new Country() { Code = "CAN", Name = "CANADA", Capital = "Ottawa" };

            Dictionary<string,Country> dictionaryCountries = new Dictionary<string,Country>();
            dictionaryCountries.Add(country1.Code, country1);
            dictionaryCountries.Add(country2.Code, country2);
            dictionaryCountries.Add(country3.Code, country3);
            dictionaryCountries.Add(country4.Code, country4);
            dictionaryCountries.Add(country5.Code, country5);

            string strUserChoice = string.Empty;

            do {
                Console.WriteLine("Please enter country code");
                string strCountryCode = Console.ReadLine().ToUpper();

                Country resultCountry = dictionaryCountries.ContainsKey(strCountryCode) ? dictionaryCountries[strCountryCode] : null;

                if (resultCountry == null)
                {
                    Console.WriteLine("Country code is not valid");
                }
                else
                {
                    Console.WriteLine($"Name = {resultCountry.Name}, Capital = {resultCountry.Capital}");
                }
                do
                {
                    Console.WriteLine("Do you want to continue - YES or NO?");
                    strUserChoice = Console.ReadLine().ToUpper();
                } while (strUserChoice != "YES" && strUserChoice != "NO");
            }
            while (strUserChoice == "YES");


        }
    }

    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
    }
}