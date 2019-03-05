using System;
using System.Collections.Generic;

namespace dictionaries
{
	class Program
	{
		static void PrintDictionary(Dictionary<string, string> dict)
		{
			foreach (KeyValuePair<string, string> kvp in dict)
			{
					Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
			}
		}
		static void Main(string[] args)
		{
			// Define the stocks Dictionary that holds the ticker symbols as the key and the company names as the value. Both are strings.
			Dictionary<string, string> stocks = new Dictionary<string, string>();

			// Add to stocks Dictionary.
			stocks.Add("TOYO", "Toyota");
			stocks.Add("VAN", "Vans");
			stocks.Add("ADI", "Adidas");

			// Store the keys as variables.
			string TOYO = stocks["TOYO"];
			string VAN = stocks["VAN"];
			string ADI = stocks["ADI"];

			// Define the purchases Dictionary that holds the ticker symbols as the key and the purchase amount as the value. The ticker symbols are strings while the amount is a Double data type.
			List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();

			purchases.Add (new Dictionary<string, double>(){ {"TOYO", 230.21} });
			purchases.Add (new Dictionary<string, double>(){ {"TOYO", 580.98} });
			purchases.Add (new Dictionary<string, double>(){ {"TOYO", 406.34} });

			purchases.Add (new Dictionary<string, double>(){ {"VAN", 363.80} });
			purchases.Add (new Dictionary<string, double>(){ {"VAN", 491.22} });
			purchases.Add (new Dictionary<string, double>(){ {"VAN", 607.49} });

			purchases.Add (new Dictionary<string, double>(){ {"ADI", 181.39} });
			purchases.Add (new Dictionary<string, double>(){ {"ADI", 267.11} });
			purchases.Add (new Dictionary<string, double>(){ {"ADI", 238.93} });

			/*
			Define a new Dictionary to hold the aggregated purchase information.
			- The key should be a string that is the full company name.
			- The value will be the total valuation of each stock

			From the three purchases above, one of the entries in this new dictionary will be:
			- {"Toyota", 1217.53}
			*/
			Dictionary<string, double> stockReport = new Dictionary<string, double>();
			// Iterate over the purchases and record the valuation for each stock.

			foreach (Dictionary<string, double> purchase in purchases)
			{
				foreach (KeyValuePair<string, double> stock in purchase)
				{
					// Declare a variable to hold the key from the stocks Dictionary.
					string key = $"{stock.Key}";
					// Declare a variable to hold the company name from the stocks Dictionary.
					string coName = stocks[stock.Key];
					// If it does, update the total valuation
					if(stockReport.ContainsKey(coName)) {
						stockReport[coName] += stock.Value;
						// If not, add the new key and set its value.
				} else {
					stockReport.Add($"{coName}", stock.Value);
				}
        // You have the value of "TOYO", so how can you look the value of "TOYO" in the `stocks` dictionary to get the value of "Toyota"?
    		}
			}
			foreach(KeyValuePair<string, double> stock in stockReport)
			{
				Console.WriteLine($"Your position on {stock.Key} is worth ${stock.Value} total.");
			}
		}
	}
}
