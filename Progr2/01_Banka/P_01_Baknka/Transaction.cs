using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_01_Baknka
{
    internal class Transaction
    {
        public DateTime Date {  get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }


        public Transaction(decimal amount, string description)
        {
            Date = DateTime.Now;
            Amount = amount;
            Description = description;
        }
        public override string ToString()
        {
            return $"{Date},  {Description},  {Amount}  kč" ;
        }
    }
}
