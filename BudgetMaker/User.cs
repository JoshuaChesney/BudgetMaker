using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace BudgetMaker
{
    public class User
    {
        public class revenue //a revenue object is an income or expense with a label attached to it
        {
            public double amount { get; set; } // positive for income, negative for expense
            public string label { get; set; } // labels are purely for users and do not need to adhere to a standard
        }
        List<revenue> incomes = new List<revenue>();
        List<revenue> expenses = new List<revenue>();

        public void writeToFile(string fileName)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer xml = new XmlSerializer(typeof(revenue),);

                for (int count = 0; count < incomes.Count; count++)
                {
                    xml.Serialize(stream, this.incomes[count]);
                }

            }
        }

        public void addIncome(double amt, string lbl)
        {
            revenue newIncome = new revenue();
            newIncome.amount = amt;
            newIncome.label = lbl;
            incomes.Add(newIncome);
        }

        public void addExpense(double amt, string lbl)
        {
            revenue newExpense = new revenue();
            newExpense.amount = amt;
            newExpense.label = lbl;
            expenses.Add(newExpense);
        }

        public double calculateAverageIncome()
        {
            double averageIncome = 0.0;
            int count = 0;
            foreach (var income in incomes)
            {
                averageIncome += income.amount;
                count++;
            }

            return averageIncome / count;
        }

        public double calculateAverageExpenses()
        {
            double averageExpenses = 0.0;
            int count = 0;
            foreach (var expense in expenses)
            {
                averageExpenses += expense.amount;
                count++;
            }

            return averageExpenses / count;
        }

        public void print() //we don't have a console so this will need to be adapted
        {
            foreach (var income in incomes)
            {
                Console.WriteLine(income.label + ": $" + income.amount + "\n");
            }

            Console.WriteLine("$" + calculateAverageIncome() + "\n");

            foreach (var expense in expenses)
            {
                Console.WriteLine(expense.label + ": $" + expense.amount + "\n");
            }

            Console.WriteLine("$" + calculateAverageExpenses() + "\n");


        }

    }
}
