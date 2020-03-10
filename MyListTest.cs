using System;
namespace ICollection
{
    class MyListTest
    {
        public static void Main()
        {
            MyList<int> listInteger = new MyList<int>();
            listInteger.Add(10);
            listInteger.Add(15);
            listInteger.Add(20);
            listInteger.Add(30);
            listInteger.Add(50);
            Console.WriteLine("Item 1: " + listInteger.GetData(1));
            Console.WriteLine("Item 4: " + listInteger.GetData(4));
            Console.WriteLine("Item 2: " + listInteger.GetData(2)); 
            listInteger.GetData(6);
            Console.WriteLine("Item -1: " + listInteger.GetData(-1));
        }
    }

    class MyList<T>
    {
        private int Capacity {get;set;}
        private Object[] Items;

        public MyList()
        {
            Items = new Object[10];
        }

        private void EnsureCapacity()
        {
            int newSize = Items.Length *2;
            Array.Copy(Items, Items, newSize);
        }

        public void Add(T data)
        {
            if(Capacity == Items.Length)
            {
                EnsureCapacity();
            }

            Items[Capacity++] = data;
        }

        public T GetData(int idx)
        {
            if(idx >= Capacity || idx < 0)
            {
                throw new IndexOutOfRangeException("Index: " + idx + ", Capacity: " + Capacity);
            }

            return (T)Items[idx];
        }
    }
}