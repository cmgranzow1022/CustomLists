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
            capacity = 5;
            Array = new T[capacity];
        }

        //member methods&properties



        public void Add(T value)
        {
           if( count > capacity / 2)
            {
                MakeTempArray();
            }         
            else
            {
                Array[count] = value;
                count++;
            }              
            
        }


        public void MakeTempArray()
        {
            T[] TempArray = new T[capacity * 2];
                 
            for (int i = 0; i < count; i++)
            {
                 TempArray[i] = Array[i];
            }  
       
            capacity *= capacity;
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
            set
            {
                capacity = value;
            }
        }


        public void RemoveFromList(T value)
        {

        }

        public void MakeIterable()
        {

        }

        public void OverrideToString()
        {

        }

        public void OverLoadAdditionOperator()
        {

        
        }

        public void OverLoadSubtractionOperator()
        {

        }


        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }



    }
}
