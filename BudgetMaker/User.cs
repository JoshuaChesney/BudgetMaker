using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace BudgetMaker
{
    public class User
    {
        public User()
        {
            
        }

        public class revenue //a revenue object is an income or expense with a label attached to it
        {
            public revenue() { }

            public double amount { get; set; } 
            public string label { get; set; } // labels are purely for users and do not need to adhere to a standard
        }

        public string username { get; set; }
        List<revenue> incomes = new List<revenue>();
        List<revenue> expenses = new List<revenue>();

        public void writeToFile() //going to have to account for conflicting usernames later
        {
            Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\" + username + "INCOMES.xml");
            XmlSerializer xml = new XmlSerializer(typeof(List<revenue>));
            xml.Serialize(stream, incomes);
            stream.Close();

            Stream stream2 = File.OpenWrite(Environment.CurrentDirectory + "\\" + username + "EXPENSES.xml");
            XmlSerializer xml2 = new XmlSerializer(typeof(List<revenue>));
            xml2.Serialize(stream2, expenses);
            stream2.Close();
        }

        public void openFile()
        {
            Stream stream = File.OpenRead(Environment.CurrentDirectory + "\\" + username + "INCOMES.xml");
            XmlSerializer xml = new XmlSerializer(typeof(List<revenue>));
            incomes = (List<revenue>)xml.Deserialize(stream);
            stream.Close();

            Stream stream2 = File.OpenRead(Environment.CurrentDirectory + "\\" + username + "EXPENSES.xml");
            XmlSerializer xml2 = new XmlSerializer(typeof(List<revenue>));
            expenses = (List<revenue>)xml2.Deserialize(stream2);
            stream2.Close();
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

        public string buildUserReport()
        {
            string userReport = "";
            foreach (var income in incomes)
            {
                userReport += (income.label + ": $" + income.amount + "\n");
            }

            userReport += ("$" + calculateAverageIncome() + "\n");

            foreach (var expense in expenses)
            {
                userReport += (expense.label + ": $" + expense.amount + "\n");
            }

            userReport += ("$" + calculateAverageExpenses() + "\n");

            return userReport;
        }

    }
}
