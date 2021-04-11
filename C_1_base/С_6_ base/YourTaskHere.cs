using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_6__base
{
    class YourTaskHere
    {
        //1 - Реализуйте метод LINQer, который на основе входной последовательности формирует LINQ-запрос, возвращающий элементы последовательности, котороые больше среднего значения входной последовательности 
        IEnumerator<T> LINQer<T>(T[] array)
        {
            var mid = array.Average();

            IEnumerator < T > newArr = from elem in array
                                       where elem > mid
                                       select elem;
            return newArr;
        
        }

        //2 - Реализуйте метод, который будет асинхронно искать и выводить в консоль факториал чисел от N до 1
        //3 - в проекте "Test" создайте класс для тестирования обоих задач
    }
}
