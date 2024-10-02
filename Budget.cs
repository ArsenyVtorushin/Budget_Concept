using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Concept
{
    internal class Budget
    {
        public int Id { get; set; }
        public DateTime dt { get; set; } // Время транзакции
        public string Name { get; set; } // Название транзакции
        public string Description { get; set; } // Описание транзакции (категория)                                                // )
        public decimal Price { get; set; } // Цена транзакции
    }
}
