using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueEmailAddresses
{
    class Solution
    {

        static public int NumUniqueEmails(string[] emails)
        {
            string[] returnEmails = new string[emails.Length];
            int numEmails = 0;
            foreach (string email in emails)
            {
                string[] splitEmail = email.Split('@');
                splitEmail[0] = splitEmail[0].Replace(".", string.Empty);
                if (splitEmail[0].Contains("+"))
                    splitEmail[0] = splitEmail[0].Substring(0, splitEmail[0].IndexOf("+"));
                string compareString = splitEmail[0] + "@" + splitEmail[1];
                if (!returnEmails.Contains(compareString))
                {
                    returnEmails[numEmails] = compareString;
                    numEmails++;
                }

            }
            return numEmails;
        }

        static void Main(string[] args)
        {
            string[] emails = new string[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };
            Console.WriteLine(NumUniqueEmails(emails).ToString());
            string[] email2 = new string[] { "a@leetcode.com", "b@leetcode.com", "c@leetcode.com" };
            Console.WriteLine(NumUniqueEmails(email2).ToString());

        }
    }
}