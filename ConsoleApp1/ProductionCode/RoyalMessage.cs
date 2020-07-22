using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ProductionCode
{
	public class RoyalMessage : IFormatedMessage
	{
		const string hello = "Your Majesty";
		const string helloMultiple = "Their Majesties";
		const string and = "&";


		public string[] Names { get; set; }

		public string GetStartMessage(string name)
		{
			return $"{helloMultiple}, {name}";
		}

		public string GetEndMessage(string res, string name)
		{
			return $"{res} {and} {name}!";
		}

		public string GetTwoNamesMessage(string name1, string name2)
		{
			return $"{helloMultiple}, {name1} {and} {name2}!";
		}

		public void SetFilteredNames(string[] names)
		{
			//Royalitycheck
			Names = names.Where(name => name.Contains("King") || name.Contains("Queen")).ToArray();
		}

		public string GetSingleNameMessage(string name)
		{
			return $"{hello}, {name}!";
		}
	}
}
