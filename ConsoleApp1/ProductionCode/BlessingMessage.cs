using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ProductionCode
{
	public class BlessingMessage : IFormatedMessage
	{
		const string hello = "May you be blessed";
		const string and = "&";

		public string[] Names { get; set; }

		public string GetStartMessage(string name)
		{
			return $"{hello} {name}";
		}

		public string GetEndMessage(string res, string name)
		{
			return $"{res}, {and} {name}.";
		}

		public string GetTwoNamesMessage(string name1, string name2)
		{
			return $"{hello} {name1} {and} {name2}.";
		}

		public void SetFilteredNames(string[] names)
		{
			Names = names.Where(name => name != name.ToUpper()).ToArray();
		}

		public string GetSingleNameMessage(string name)
		{
			return $"{hello}, {name}.";
		}
	}
}
