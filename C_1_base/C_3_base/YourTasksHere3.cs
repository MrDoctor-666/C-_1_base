using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMath;

namespace C_3_base
{
    public class YourTasksHere3
    {
        // На вход подается массив математических полей, необходимо вывести их сумму, ответ представить в самом оптимальном типе (в самом низком)
        void Sum(Math_Field[] fields)
        {
            Math_Field sum = new N();
            foreach (Math_Field elem in fields)
            {
                sum.ADD(elem);
            }

            while (sum.isDown) {
                sum.Dawn();
            }

            Console.WriteLine(sum);
        }

        // Необходимо по массиву строк построить массив соотвествующих математических объкетов
        Math_Field[] Reg(string[] fields)
        {
            Math_Field[] math_Fields = new Math_Field[fields.Length];
            //да я че знаю что ли как эти конструкторы работают
            for (int i = 0; i < fields.Length; i++)
            {
                List<string> first = new List<string>();
                List<string> second = new List<string>();
                if (fields[i].Contains("i"))
                {
                    //пусть С короче выглядит так потому что хз как оно там выглядит "1231+1231i"
                    first[0] = fields[i].Substring(0, fields[i].IndexOf("+"));
                    first[1] = fields[i].Substring(fields[i].IndexOf("+") + 1, fields[i].IndexOf("i"));
                    Q q1, q2;

                    if (first[0].Contains("/"))
                    {
                        first[0] = first[0].Substring(0, first[0].IndexOf("/"));
                        second[0] = first[0].Substring(first[0].IndexOf("/") + 1);
                        q1 = new Q(first, second);
                    }
                    else q1 = new Q(first, new Z(1));

                    first[0] = first[1];
                    if (first[1].Contains("/"))
                    {
                        first[0] = first[1].Substring(0, first[1].IndexOf("/"));
                        second[0] = first[1].Substring(first[1].IndexOf("/") + 1);
                        q2 = new Q(first, second);
                    }
                    else q2 = new Q(first, new Z(1));


                    math_Fields[i] = new C(q1, q2);
                }
                else if (fields[i].Contains("/"))
                {
                    //пусть "12321/123213"
                    first[0] = first[1].Substring(0, first[1].IndexOf("/"));
                    second[0] = first[1].Substring(first[1].IndexOf("/") + 1);
                    math_Fields[i] = new Q(first, second);
                }
                else if (fields[i].Contains("-")) {
                    first[0] = fields[i];
                    math_Fields[i] = new Z(first);
                }
                else math_Fields[i] = new N(UInt32.Parse(fields[i]));
            }

            return math_Fields;
        }
    }
}
