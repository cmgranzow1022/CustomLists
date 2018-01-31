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
        public int count;
        public int capacity;
        public T[] Array;
        public T[] TempArray;

        //ctor
        public CustomList()
        {
            count = 0;
            capacity = count + 1;
            Array = new T[capacity];
            TempArray = new T[0];
        }

        //member methods&properties

        public void Add(T value)
        { 
               MakeTempArray();
               Array[Count] = value;
               count++;     
        }

        public void MakeTempArray()
        {
            capacity = capacity + 1;
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

        public static CustomList<T>ZipList(CustomList<T>ONE, CustomList<T>TWO)
        {
            CustomList<T> zippedList = new CustomList<T>();

            return zippedList;
        }


        public void MakeIterable()
        {

        }



        public string OverrideToString()
        {
            string result = "";
       
            return result;
        }

        public void OverLoadAdditionOperator()
        {

        
        }

        public void OverLoadSubtractionOperator()
        {

        }
        public IEnumerator GetEnumerator()
        {
            for(int i = 0 ; i < Array.Length; i++)
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
