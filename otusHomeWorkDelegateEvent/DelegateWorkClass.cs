using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static otusHomeWorkDelegateEvent.DelegateWorkClass;

namespace otusHomeWorkDelegateEvent
{
    public class DelegateWorkClass
    {
        //    Написать обобщённую функцию расширения, находящую и возвращающую максимальный элемент коллекции.
        //    Функция должна принимать на вход делегат, преобразующий входной тип в число для возможности поиска максимального значения.
        //    public static T GetMax(this IEnumerable collection, Func<T, float> convertToNumber) where T : class;
 
        public DelegateWorkClass()
        {
            Func<string, float> convertMethod = ConvertClass.ConvertToNumber;

            var test = new TestClass<string>();
            test.list.Add("1");
            test.list.Add("17");
            test.list.Add("7");
            test.list.Add("77");

            var result = test.list.GetMax<string>(convertMethod);

            Console.WriteLine("Максимальное число: " + result);
        }
    }
}
