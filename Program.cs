
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TwoRolesClassOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankOfAccount = new BankOfAccount();
            bankOfAccount.AccountBank = 8696;
            bankOfAccount.TypeBankAccount = "накопительный";
            bankOfAccount.BalanceAccount = 3000000;
            Console.WriteLine("На {0} счете  {1} баланс составил: {2}",bankOfAccount.TypeBankAccount, bankOfAccount.AccountBank,bankOfAccount.BalanceAccount);
        }
        class BankOfAccount
        {
            private int accountBank;

            public int AccountBank
            {
                get { return accountBank; }
                set { accountBank = value; }
            }
            private int balanceAccount;

            public int BalanceAccount
            {
                get { return balanceAccount; }
                set { balanceAccount = value;  }
            }
            private string typeBankAccount;

            public string TypeBankAccount
            {
                get { return typeBankAccount; }
                set { typeBankAccount = value; }
            }
        }
    }
}
/// В классе все методы для заполнения и получения значений полей заменить на свойства.Написать тестовый пример.
