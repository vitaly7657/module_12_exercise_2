using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace module_12_exercise_2
{
    internal class Account1 : IAccount<DepositAcc> //класс для первого счёта
    {
        public DepositAcc ReturnMethod()
        {
            return new DepositAcc(1, 1, "521534", 10000, "депозитный");
        }
    }
}
