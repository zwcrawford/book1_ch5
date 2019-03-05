using System;
using System.Collections.Generic;

namespace dictionaries
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> stocks = new Dictionary<string, string>();

			stocks.Add("TOYO", "Toyota");
			stocks.Add("VAN", "Vans");
			stocks.Add("ADI", "Adidas");

			string TOYO = stocks["TOYO"];
			string VAN = stocks["VAN"];
			string ADI = stocks["ADI"];

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
			Dictionary<string, int> stockReport = new Dictionary<string, int>();
			// Iterate over the purchases and record the valuation for each stock.
		}
	}
}
