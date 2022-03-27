
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
            BankOfAccount bankOfAccount = new();
            bankOfAccount.Account();
            bankOfAccount.Balance();
            bankOfAccount.TypeAccount();
        }
        class BankOfAccount
        {
            private int accountBank { get; set; }

            private int balanceAccount { get; set; }

            private enum typeBankAccount { current,estimated,credit }

            public void Account()
            {
                Random randomAccount = new();
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("Номер счета:{0,3}", randomAccount.Next());
                }


            }
            public void Balance()
            {
                balanceAccount = 3000000;
                Console.WriteLine("Баланс на счете: "+balanceAccount);
            }
            public void TypeAccount()
            {
                typeBankAccount type = typeBankAccount.estimated;
                Console.WriteLine("Тип банковского счета: "+type);
                
            }
        }

    }
}
/// 3.В классе банковский счет удалить методы заполнения полей. Вместо этих методов создать конструкторы. 
/// Переопределить конструктор по умолчанию, создать конструктор для заполнения поля баланс, конструктор для заполнения поля тип банковского счета, 
/// конструктор для заполнения баланса и типа банковского счета. Каждый конструктор должен вызывать метод, генерирующий номер счета.
