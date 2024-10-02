using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Concept
{
    internal class BudgetProcessing // Методы для взаимодействия с бюджетом
    {
        // Метод добавления расхода
        public static void AddExpense(DateTime dt, string name, string discription, decimal price) 
        {
            /*using (BudgetContext context = new BudgetContext()) // Вместо методов open() и close()
            {
                Budget Expense = new Budget(); // Создаём новый расход
                Expense.dt = dt;
                Expense.Name = name;
                Expense.Description = discription;
                Expense.Price = price;
            }*/
            BudgetContext context = new BudgetContext();
            Budget Expense = new Budget(); // Создаём новый расход
            Expense.dt = dt;
            Expense.Name = name;
            Expense.Description = discription;
            Expense.Price = price;
            context.SaveChanges(); // Сохраняем траты
        }        
    }
}
