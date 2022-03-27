
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
            BankOfAccount bankOfAccount1 = new(3000000);
            BankOfAccount bankOfAccount2 = new("estimated");
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
                balanceAccount = 3000000;
                Console.WriteLine("На счете баланс составил :{0}",balanceAccount);
            }
            /// <summary>
            /// конструктор для заполнения банковского счета
            /// </summary>
            public BankOfAccount(string _TypeBankAccount)
            {
                string typeBankAccount = _TypeBankAccount;
                GenerateAccount();
                typeBankAccount = "estimated";
                Console.WriteLine("Тип банковского счета: " + typeBankAccount);
            }

        }

    }
}
/// 3.В классе банковский счет удалить методы заполнения полей. Вместо этих методов создать конструкторы. 
/// Переопределить конструктор по умолчанию, создать конструктор для заполнения поля баланс, конструктор для заполнения поля тип банковского счета, 
/// конструктор для заполнения баланса и типа банковского счета. Каждый конструктор должен вызывать метод, генерирующий номер счета.
