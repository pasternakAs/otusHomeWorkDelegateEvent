using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otusHomeWorkDelegateEvent
{
    public static class ConvertClass
    {
        /// <summary>
        /// Конвертор
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="a"></param>
        /// <returns></returns>
        public static float ConvertToNumber<T>(T a)
        {
            var num = (float)Convert.ChangeType(a, typeof(float), CultureInfo.InvariantCulture);
            return num;
        }
    }
}
