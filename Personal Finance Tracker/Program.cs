using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Finance_Tracker
{
    internal class Program
    {
        const string bankStatement = "bankstatement.txt";
        static void Main(string[] args)
        {


            int choice;
            int balance = 0;
            int withdrawal = 0;
            int deposit = 0;
            File.Create(bankStatement).Close();

            while (true)
                
            {
                Console.WriteLine("===============Welcome to your Personal Finance Tracker==============");
                Console.WriteLine();

                Console.WriteLine("1.Check Balance: ");
                Console.WriteLine("2.Deposit money in Account: ");
                Console.WriteLine("3.Withdraw money from account:  ");
                Console.WriteLine("4.Print your statement:  ");


                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (choice == 1)
                        {
                            Console.WriteLine($"Your current balance is {balance}");
                        }
                        break;

                    case 2:
                        if (choice == 2)
                        {
                            Console.WriteLine("How much do you want to deposit? ");
                            deposit = Convert.ToInt32(Console.ReadLine());
                            balance += deposit;
                            string depositEntry = $"{DateTime.Now} | Deposit: {deposit} | Balance: {balance}";
                            File.AppendAllText(bankStatement, depositEntry + Environment.NewLine);
                        }
                        break;

                    case 3:
                        if (choice == 3)

                        {
                            Console.WriteLine("How much do you want to withdraw? ");
                            withdrawal = Convert.ToInt32(Console.ReadLine());

                            if (withdrawal <= balance)
                            {
                                balance -= withdrawal;
                            }
                            else
                            {
                                Console.WriteLine("Not enough funds");
                            }
                            string withdrawalEntry = $"{DateTime.Now} | Withdrawal: {withdrawal} | Balance: {balance}";
                            File.AppendAllText(bankStatement, withdrawalEntry + Environment.NewLine);
                        }
                        break;

                    case 4:
                        if (choice == 4)
                        {   

                            string allTransactions = File.ReadAllText(bankStatement);
                          
                        }
                        break;

                    case 5:
                       return;

                }
            }


            
        }

       

        
    }
}
