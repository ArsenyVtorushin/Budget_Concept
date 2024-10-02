using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // Добавляем библиотеку

namespace Budget_Concept
{
    // Кдасс для связи с БД
    internal class BudgetContext : DbContext
    {
        public BudgetContext(): base("DBConnection") 
        { }
        public DbSet<Budget> Expenses { get; set; } 
    }
}
