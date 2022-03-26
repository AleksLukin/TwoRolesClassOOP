
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
/*Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип).
Предусмотреть методы для доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и вывести
информацию об объекте класса на печать*/
