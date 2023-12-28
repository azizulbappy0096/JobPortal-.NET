using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JobPortal.utils
{
    internal class HelperF
    {
        public bool IsEmailValid(string email)
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        public string GenerateUniqueHexValue()
        {

            long timestampTicks = DateTime.UtcNow.Ticks;

            string timestampHex = timestampTicks.ToString("X");

            Random random = new Random();
            string randomHex = random.Next(0x1000, 0xFFFF).ToString("X");

            string uniqueHexValue = timestampHex + randomHex;

            return uniqueHexValue;
        }
    }
}
