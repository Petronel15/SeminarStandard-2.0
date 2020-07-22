using SeminarStandard.ProductionCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ProductionCode
{
	internal class MessageFactory
	{
		public IFormatedMessage GetMessageByName(string name)
		{
			if (!string.IsNullOrEmpty(name))
			{
				if (name == name.ToUpper())
				{
					return new ShoutingMessage();
				}
				else if (name != name.ToUpper())
				{
					if (name.Contains("King") || name.Contains("Queen"))
					{
						return new RoyalMessage();
					}
					return new SimpleMessage();
				}
			}
			return null;
		}
	}
}
