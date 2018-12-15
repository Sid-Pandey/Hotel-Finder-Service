using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectiveServices
{
    public class Class1
    {
        public String Transcation(String cardno, int amount)
        {
            Dictionary<String, String> accounts = new Dictionary<string, string>();
            String path = "";
            try
            {
                path = System.AppDomain.CurrentDomain.BaseDirectory;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            Console.WriteLine(path);
            String message = "";
            /*
            StreamReader reader = new StreamReader(path);
            String line;

            while ((line = reader.ReadLine()) != null)
            {
                String[] s = line.Split('\t');
                String card = s[0];
                String balance = s[1];
                accounts[card] = balance;
            }

            if (!accounts.ContainsKey(cardno))
            {
                Random rand = new Random();
                accounts[cardno] = rand.Next(90000, 100000).ToString();
            }

            int account_balance = Convert.ToInt32(accounts[cardno]);
            if (account_balance < amount)
            {
                message = "Insufficient balance! Transaction cancelled";
            }
            else
            {
                account_balance -= amount;
                accounts[cardno] = Convert.ToString(account_balance);
                message = "Transaction successful. The balance in your account is : " + account_balance;
            }


            //Iterate through all card nos and write them back to the file.
            foreach (String card in accounts.Keys)
            {
                StreamWriter writer = new StreamWriter(path);
                String l = card + "\t" + accounts[cardno];
                writer.WriteLine(l);
            }
        */
            return message;
        }

        public static void Main(string[] args)
        {
            Dictionary<String, String> checkout = new Dictionary<String, String>();
            checkout["Name"] = "Sid";
            checkout["CardNo"] = "12346";
            checkout["Address"] = "jhgjhgj";
            checkout["Amount"] = "678";
            Class1 p = new Class1();
            String response = p.Transcation(checkout["CardNo"], Convert.ToInt32(checkout["Amount"]));
            Console.WriteLine(response);
            Console.ReadLine();
        }
    }
}