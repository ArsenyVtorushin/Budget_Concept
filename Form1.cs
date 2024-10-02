using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Concept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {            
            decimal price; // Временная переменная для конвертации суммы расхода из строки в decimal
            if (!decimal.TryParse(tbPrice.Text, out price)) // Проверяет, не ввели ли мы в tbPrice буквы
            {
                return;
            }
            BudgetProcessing.AddExpense(dtPicker.Value,tbName.Text, tbDescription.Text, price);
        }
    }
}
