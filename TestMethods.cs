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
            for (int i= 0; i <= l_temp.Count - 1; i++)
            {
                sourceStack.Push(l_temp[i]);
            }

            return result;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();
            for(int i = 0; i <= sourceArr.Length-1; i++)
            {
                if (sourceArr[i] % 2 == 0)//el numero es par
                {
                    result.Add(sourceArr[i], EValueType.Two);
                }
                else if (sourceArr[i] % 3 == 0)
                {
                    result.Add(sourceArr[i], EValueType.Three);
                }
                else if (sourceArr[i] % 5 == 0)
                {
                    result.Add(sourceArr[i], EValueType.Five);
                }
                else if (sourceArr[i] % 7 == 0)
                {
                    result.Add(sourceArr[i], EValueType.Seven);
                }
                else if (sourceArr[i] % 5 == 0)
                {
                    result.Add(sourceArr[i], EValueType.Five);
                }
                else if (SourceArrAnalysis(sourceArr[i]))
                {
                    result.Add(sourceArr[i], EValueType.Prime);
                }
            }
            

            return result;
        }
        internal static bool SourceArrAnalysis(int valor)//para saber si es primo
        {
            bool resultado = false;
            int count = 0;
            for(int i =1; i<= valor; i++)
            {
                if (valor % i == 0)
                {
                    count = count + 1;
                }
            }
            if (count <= 2)
            {
                resultado = true;
            }
            return resultado;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {

            int retorno = 0;
            foreach(var value in sourceDict.Values)
            {
                if(value == type)
                {
                    retorno = retorno + 1;
                }
            }


            return retorno;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();

            List<int> l_keys = new List<int>();
            

            foreach (var key in sourceDict.Keys)
            {
                l_keys.Add(key);
            }
            l_keys.Sort();
            l_keys.Reverse();

            int[] A_keys = l_keys.ToArray();

            result = FillDictionaryFromSource(A_keys);

            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = new Queue<Ticket>[3];
            result[0] = new Queue<Ticket>();
            result[1] = new Queue<Ticket>();
            result[2] = new Queue<Ticket>();
            List<Ticket> l_ordenada = new List<Ticket>();
            List<int> l_turnos = new List<int>();
            for(int i = 0; i <= sourceList.Count-1; i++)
            {
                l_turnos.Add(sourceList[i].Turn);
            }
            l_turnos.Sort();
            int a = l_turnos.Count - 1;

            int cont1 = 0;

            for (int i = 0; i <= a; i++)
            {
                if (cont1 != l_turnos[i])
                {
                    for (int j = 0; j <= a; j++)
                    {
                        if (l_turnos[i] == sourceList[j].Turn)
                        {
                            l_ordenada.Add(sourceList[j]);
                        }
                    }
                    cont1 = l_turnos[i];
                }

                
            }

            

            for (int i = 0; i<= l_ordenada.Count - 1; i++)
            {
                if (l_ordenada[i].RequestType == Ticket.ERequestType.Payment)
                {
                    result[0].Enqueue(l_ordenada[i]);
                }
                else if (l_ordenada[i].RequestType == Ticket.ERequestType.Subscription)
                {
                    result[1].Enqueue(l_ordenada[i]);
                }
                else if (l_ordenada[i].RequestType == Ticket.ERequestType.Cancellation)
                {
                    result[2].Enqueue(l_ordenada[i]);
                }
            }


            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            if (targetQueue.Peek().RequestType == ticket.RequestType)
            {
                if (ticket.Turn > 0 && ticket.Turn < 100)
                {
                    targetQueue.Enqueue(ticket);
                    result = true;
                }
                
            }

            return result;
        }        
    }
}