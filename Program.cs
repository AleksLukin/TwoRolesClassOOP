
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
            private int AccountBank { get; set; }

            private int BalanceAccount { get; set; }

            private enum TypeBankAccount { current,estimated,credit }

            public void Account()
            {
                
                AccountBank = 8689;
                Console.WriteLine("Номер счета: " + AccountBank);
            }
            public void Balance()
            {
                BalanceAccount = 3000000;
                Console.WriteLine("Баланс на счете: "+BalanceAccount);
            }
            public void TypeAccount()
            {
                TypeBankAccount type = TypeBankAccount.estimated;
                Console.WriteLine("Тип банковского счета: "+type);
                
            }
        }

    }
}
/// 3.В классе банковский счет удалить методы заполнения полей. Вместо этих методов создать конструкторы. 
/// Переопределить конструктор по умолчанию, создать конструктор для заполнения поля баланс, конструктор для заполнения поля тип банковского счета, 
/// конструктор для заполнения баланса и типа банковского счета. Каждый конструктор должен вызывать метод, генерирующий номер счета.
