using System.Collections.Generic;
using System.Security.Principal;
using System.Windows.Annotations;

namespace module_12_exercise_2
{
    internal class Storage
    {
        public List<Client> ClientsDB { get; set; } //база клиентов
        public List<Account<int, int, object, object, string>> AccountsDB { get; set; } //база счетов с параметризация типов данных

        private Storage()

        {
            ClientsDB = new List<Client>(); //создание новой базы клиентов
            AccountsDB = new List<Account<int, int, object, object, string>>(); //создание новой базы счетов

            ClientsDB.Add(new Client(1, "Петров", "Дмитрий", "Иванович"));

            IAccount<DepositAcc> conDep = new Account1(); //конкретный тип
            IAccount<Account<int, int, object, object, string>> acc = conDep; //приведение общего типа к конкретному через КОВАРИАНТНОСТЬ
            Account<int, int, object, object, string> accFirst = acc.ReturnMethod(); //через метод извлекаем данные для первого счёта

            AccountsDB.Add(accFirst);

            AccountsDB.Add(new Account<int, int, object, object, string>(2, 1, "826493", 50, "депозитный"));
            AccountsDB.Add(new Account<int, int, object, object, string>(3, 1, "906562", 9000, "недепозитный"));



            ClientsDB.Add(new Client(2, "Васильев", "Пётр", "Дмитриевич"));
            AccountsDB.Add(new Account<int, int, object, object, string>(4, 2, "165934", 12000, "депозитный"));
            AccountsDB.Add(new Account<int, int, object, object, string>(5, 2, "381950", 185000, "депозитный"));
            AccountsDB.Add(new Account<int, int, object, object, string>(6, 2, "194735", 300, "недепозитный"));
        }

        public static Storage CreateStorage() //создание репозитория с базами
        {
            return new Storage();
        }

        public void AccountAdd(int id, int clientID, object accountNumber, object accountSumm, string isDeposit) //метод добавления нового клиента в базу
        {
            AccountsDB.Add(new Account<int, int, object, object, string>(id, clientID, accountNumber, accountSumm, isDeposit));
        }
    }


}
