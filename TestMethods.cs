using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal enum EValueType
        {
            Two,
            Three,
            Five,
            Seven,
            Prime
        }

        internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
        {
            Stack<int> result = new Stack<int>();
            

            List<int> l_temp = new List<int>();
            int a = sourceStack.Count - 1;
            for (int i = 0; i <= a; i++)
            {
                l_temp.Add(sourceStack.Peek());
                sourceStack.Pop();
            }
            l_temp.Reverse();

            int mayor;

            for (int i = 0; i <= l_temp.Count - 1; i++)
            {
                mayor = 0;
                for (int j = i; j <= l_temp.Count - 1; j++)
                {
                    if (mayor < l_temp[j])
                    {
                        mayor = l_temp[j];
                    }
                }
                if (l_temp[i] < mayor)
                {
                    result.Push(mayor);
                }
                else
                {
                    result.Push(-1);
                }
            }


            return result;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = null;

            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            return 0;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = null;

            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = null;

            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            return result;
        }        
    }
}