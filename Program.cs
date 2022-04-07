
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
            BankOfAccount bankOfAccount = new("estimated",3000000);
            
        }
        class BankOfAccount
        {
            private int _AccountBank { get; set; }
            private int _BalanceAccount { get; set; }
            private string _TypeBankAccount { get; set; }
            public void GenerateAccount()
            {
                int accountBank = _AccountBank;
                Random randomAccount = new();
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("Номер счета:{0,3}", randomAccount.Next());
                }
            }
            /// <summary>
            /// конструктор для заполнения поля баланс
            /// </summary>
            /// <param name=""></param>
            public BankOfAccount(int _BalanceAccount)
            {
                int balanceAccount = _BalanceAccount;
                GenerateAccount();                
            }
            /// <summary>
            /// конструктор для заполнения банковского счета
            /// </summary>
            public BankOfAccount(string _TypeBankAccount)
            {
                string typeBankAccount = _TypeBankAccount;
                GenerateAccount();                
            }
            public BankOfAccount(string _TypeBankAccount, int _BalanceAccount)
            {
                int balanceAccount = _BalanceAccount;
                string typeBankAccount = _TypeBankAccount;
                Console.WriteLine("На счете {0} баланс составил: {1}",typeBankAccount,balanceAccount);
            }
        } 
    }
}
////В классе банковский счет, удалить методы заполнения полей. Вместо этих
//методов создать конструкторы. Переопределить конструктор по умолчанию,
//создать конструктор для заполнения поля баланс, конструктор для заполнения
//поля тип банковского счета, конструктор для заполнения баланса и типа
//банковского счета. Каждый конструктор должен вызывать метод, генерирующий
//номер счета.
