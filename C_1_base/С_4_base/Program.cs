using System;
using System.Reflection;

namespace С_4_base
{
    class YourTaskHere
    {
        // Используя средства рефлексии и консольного вывода, вывидете все имена (идентификаторы) типов данных из сборки C_2_base
        static void Main(string[] args)
        {
            Assembly assembly;
            assembly = Assembly.LoadFrom("C_2_base.dll");
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
                Console.WriteLine(type.Name);
            Console.ReadLine();
        }
    }
}