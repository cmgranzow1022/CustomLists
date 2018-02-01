using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLists
{
   public class CustomList<T> : IEnumerable
    {
        //member variables
        public T value;
        public int count;
        public int capacity;
        public T[] Array;
        public T[] TempArray;

        //ctor
        public CustomList()
        {
            count = 0;
            capacity = 5;
            Array = new T[capacity];
            TempArray = new T[0];
        }

        //member methods&properties

        public void Add(T value)
        {
            if (count == capacity / 2)
            {
               MakeTempArray();
            }
               Array[Count] = value;
               count++;     
        }

        public void MakeTempArray()
        {
            capacity = capacity * 2;
            T[] TempArray = new T[capacity];
                 
            for (int i = 0; i < count; i++)
            {
                 TempArray[i] = Array[i];
            }  
      
            Array = TempArray;
        }

       public int Count 
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public bool Remove(T value)
        {

            for (int i = 0; i < count; i++)
                if (Array[i].Equals(value))
                {
                    while ( i  < count)
                    {
                    Array[i] = Array[i + 1];
                    i++;
                    }
                    count--;
                    return true;
                }                    
            return false;  
        }

        public static CustomList<T> Zip(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> zippedList = new CustomList<T>();
            zippedList.Array = new T[listOne.Count + listTwo.Count];
            int z = 0;
            for (int i = 0; i < listOne.Count; i++)
            {
                zippedList.Array[z] = listOne.Array[i];
                z++;
                zippedList.Array[z] = listTwo.Array[i];
                z++;
            }
            return zippedList;
        }


        public override string ToString()
        {
            string answer = "";
            foreach (T value in this)
            {
                answer += value;
            }
            return answer;
        }

        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> resultList = new CustomList<T>();
            resultList.Array = new T[listOne.Count + listTwo.Count];
            int j = 0;
            for (int i = 0; i < listOne.Count; i++)
            {
                resultList.Array[j] = listOne.Array[i];
                j++;
            }
            for (int i = 0; i < listTwo.Count; i++)
            {
                resultList.Array[j] = listTwo.Array[i];
                j++;
            }
            return resultList;


        }

        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            bool result = true;
            CustomList<T> resultList = new CustomList<T>();

            for (int i = 0; i < listOne.count; i++)
            {
                result = true;
                for (int j = 0; j < listTwo.count; j++)
                {

                    if (listOne.Array[i].Equals(listTwo.Array[j]))
                    {
                        result = false;
                        break;
                    }
                }

                if (result == true)
                {
                    resultList.Add(listOne.Array[i]);
                }
            }
           return  resultList;
        }

        public IEnumerator GetEnumerator()
        {
            for(int i = 0 ; i < Array.Length - (capacity - count); i++)
            {
                yield return Array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}


