using System.Collections;
using System.Collections.ObjectModel;
using static System.Console;

namespace Test
{
    public class TestArray
    {
        public void Awake()
        {
            ArrayList arrayList = new ArrayList();

            WriteLine(arrayList.Add(10));

            PrintArrayList(arrayList);
            arrayList.Insert(1,100);

            PrintArrayList(arrayList);

            Collection<int> data = new Collection<int>();
            data.Add(1);
            data.Add(3);
            data.Add(2);
            arrayList.AddRange(data);

            PrintArrayList(arrayList);
            arrayList.Sort();
            PrintArrayList(arrayList);

            arrayList.Remove(10);
            PrintArrayList(arrayList);
            arrayList.RemoveAt(0);
            PrintArrayList(arrayList);
            arrayList.RemoveRange(0,2);
            PrintArrayList(arrayList);
            arrayList.Clear();
            WriteLine(arrayList.Count);
        }

        public void PrintArrayList(ArrayList list)
        {
            WriteLine("====================");
            for (int i = 0; i < list.Count; i++)
            {
                WriteLine(list[i]);
            }
        }
    }

    public class TestQueue
    {
        public void Awake()
        {
            Queue queue = new Queue();
            for( int i = 0; i < 5; i++)
            {
                queue.Enqueue(i);
            }
            WriteLine("Queue Count: "+queue.Count);

            WriteLine("현재 0번째 요소 "+queue.Peek());
            WriteLine("Queue Count: "+queue.Count);

            object data = queue.Dequeue();
            WriteLine("큐에서 빠져나온 요소 "+data);

            WriteLine("Queue Count: "+queue.Count);

            queue.Clear();
            WriteLine("Queue Count: "+queue.Count);
        }
    }

    public class TestStack
    {
        public void Awake()
        {
            Stack stack = new Stack();
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
            }
            WriteLine("스택 Count: "+stack.Count);

            WriteLine("마지막에 추가된 요소 "+stack.Peek());
            WriteLine("스택 Count: "+stack.Count);

            object data = stack.Pop();
            WriteLine("스택에서 빠져나온 요소 "+data);

            WriteLine("스택 Count: "+stack.Count);

            stack.Clear();
            WriteLine("스택 Count: "+stack.Count);
        }
    }
    public class TestHashTable
    {
        public void Awake()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "정수");
            hashtable.Add(1.2f, "실수");
            hashtable.Add("가나다", "문자열");
            hashtable.Add("D", 9);
            hashtable.Add("E", 7);


            foreach (object key in hashtable.Keys)
            {
                WriteLine("hash[{0}] = {1}", key, hashtable[key]);
            }
            if (hashtable.ContainsKey(1))
            {
                WriteLine("ContainsKey(1) = " + hashtable[1]);
            }

            WriteLine("Hashtable Count: "+hashtable.Count);
            hashtable.Remove("가나다");
            WriteLine("Hashtable Count: "+hashtable.Count);

            hashtable.Clear();
            WriteLine("Hashtable Count: "+hashtable.Count);
        }
    }
}