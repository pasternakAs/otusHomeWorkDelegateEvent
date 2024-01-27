using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otusHomeWorkDelegateEvent
{
    public static class ExtensionMethodGetMax
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="convertToNumber"></param>
        /// <returns></returns>
        public static T GetMax<T>(this IEnumerable collection, Func<T, float> convertToNumber) where T : class
        {
            ArgumentNullException.ThrowIfNull(collection);

            T? maxObj = default;
            var firstIteration = true;

            foreach (T item in collection)
            {
                if (firstIteration)
                {
                    maxObj = item;
                    firstIteration = false;
                }
                else
                {                   
                    maxObj = convertToNumber(item) > convertToNumber(maxObj)
                        ? item
                        : maxObj;
                }
            }

            return maxObj;
        }
    }
}