using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class List<T> : IEnumerable
    {
        T[] finalArray;
        T[] tempArray;
        public int count;
        public int capacity;
        public int Capacity { get { return capacity; } set { capacity = value; } }
        public int Count { get { return count; } set { count = value; } }
        public T this[int i] { get { return finalArray[i]; } set { finalArray[i] = value;  } }
        public List()
        {
            count = 0;
            capacity = 10;
            finalArray = new T[capacity];
            tempArray = new T[0];
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return finalArray[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public void Add(T item)
        {
            if (count >= capacity)
            {
                DoubleArray();
            }
            finalArray[count] = item;
            count++;
        }
        public void DoubleArray()
        {
            T[] temporaryArray = new T[capacity * 2];
            for (int i = 0; i < count; i++)
            {
                temporaryArray[i] = finalArray[i];
            }
            capacity = capacity * 2;
            finalArray = temporaryArray;
        }
        public bool Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (finalArray[i].Equals(item))
                {
                    finalArray[i] = finalArray[i + 1];
                    count--;
                    return true;
                }
            }
            return false;
        }    
        public override string ToString()
        {
            string toString = ("");
            for (int i = 0; i < Count; i++)
            {
                toString = toString + "" + finalArray[i];
            }
            return toString;
        }
        public int ArrayCount()
        {
            int index = 0;
            for (int i = 0; i < (finalArray.Length); i++)
            {
                index++;
            }
            return index;
        }       
        public static List<T> operator +(List<T> listOne, List<T> listTwo)
        {
            List<T> joinedLists = new List<T>();
            foreach (T item in listOne.finalArray)
            {
                joinedLists.Add(item);
            }
            foreach (T item in listTwo.finalArray)
            {
                joinedLists.Add(item);
            }
            return joinedLists;
        }
        public static List<T> operator -(List<T> listOne, List<T> listTwo)
        {
            for (int i = 0; i < listOne.count; i++)
            {
                for (int j = 0; j < listTwo.count; j++)
                {
                    if (listOne.finalArray[i].Equals(listTwo.finalArray[j]))
                    {
                        listOne.Remove(listTwo.finalArray[j]);
                    }
                }
            }
            return listOne;
        }
        public List<T> Zip(List<T> listOne, List<T>listTwo)
        {
            List<T> zippedList = new List<T>();
            for (int i = 0; i < (listOne.count + listTwo.count / 2); i++)
            {
                zippedList.Add(listOne[i]);
                zippedList.Add(listTwo[i]);
                i++;
            }
            
            return zippedList;
        }

    }
}
