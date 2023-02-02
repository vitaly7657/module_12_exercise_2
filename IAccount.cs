using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_12_exercise_2
{
    internal interface IAccount<out T> //инерфейс
    where T : Account<int, int, object, object, string>
    {
        T ReturnMethod();
    }
}
