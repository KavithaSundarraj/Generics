using System;
using System.Collections.Generic;
using System.Text;
/*Generics
 * Date : 06 NOV 2020
 * a class Box<> that can store anything. 
It should have two public methods:
•	void Add(element)
•	element Remove()
•	int Count { get; }
Adding should add on top of its contents. Remove should get the topmost element. */

namespace Generics
{
    class Box<T>
    {
        private List<T> Data = new List<T>();
        public void Add(T element)
        {
            Data.Add(element);
        }
        public int Count()
        {
            return Data.Count;
        }
        public T Remove()
        {
            return Data[Data.Count -1];
        }
    }
}
