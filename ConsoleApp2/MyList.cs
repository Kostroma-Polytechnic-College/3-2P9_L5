using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// Мой класс
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyList<MyType>
    {
        Item head;
        class Item
        {
            public MyType Value;
            public Item Next;
        }
        /// <summary>
        /// Метод добавления
        /// </summary>
        /// <param name="value"></param>
        public void Add(MyType value)
        {
            if (head == null)
            {
                head = new Item() { Value = value };
                return;
            }
            Item current = head;
            while (current.Next != null)
                current = current.Next;
            current.Next = new Item() { Value = value };
        }

        public void Clear()
        {
            head = null;
        }

        public void RemoveFirst()
        {
            if (head == null) return;
            head = head.Next;
        }

        
    }
}
