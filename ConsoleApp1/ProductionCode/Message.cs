using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarStandard.ProductionCode
{
    public class Message
    {

        public string StartMessage(string name)
        {
            var simpleMessage = new SimpleMessage();
            var shoutingMessage = new ShoutingMessage();

            string res = string.Empty;
            if (name != name.ToUpper())
            {
                res = simpleMessage.GetStartMessage(name);
            }
            else
            {
                res = shoutingMessage.GetStartMessageShouting(name);
            }

            return res;
        }

        public string EndMessage(string name)
        {
            var simpleMessage = new SimpleMessage();
            var shoutingMessage = new ShoutingMessage();

            string res = string.Empty;
            if (name != name.ToUpper())
            {
                res = simpleMessage.GetEndMessage(res, name);
            }
            else
            {
                res = shoutingMessage.GetEndMessageShouting(res, name);
            }
            return res;
        }

        public string TwoNamesMessage(string name1, string name2)
        {
            var simpleMessage = new SimpleMessage();
            var shoutingMessage = new ShoutingMessage();

            string res = string.Empty;
            if (name1 != name1.ToUpper() && name2 != name2.ToUpper())
            {
                res = simpleMessage.GetTwoNamesMessage(name1, name2);
            }
            else if (name1 == name1.ToUpper() && name2 == name2.ToUpper())
            {
                res = shoutingMessage.GetTwoNamesMessageShouting(name1, name2);
            }
            else if (name1 != name1.ToUpper() && name2 == name2.ToUpper())
            {
                res = $"hello, {name1} AND {name2}!";
            }
            else
            {
                res = $"hello, {name2} AND {name1}!";
            }
            return res;
        }
    }
}
