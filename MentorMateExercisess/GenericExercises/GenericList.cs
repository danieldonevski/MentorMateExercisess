using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExercises
{
    class GenericList<T> : IEnumerable 
    {
        private const int CAPACITY = 16;

        private T[] arr;
        private int size;
        private int capacity;

        public GenericList(int capacity = CAPACITY)
        {
            this.size = 0;
            this.capacity = capacity;
            this.arr = new T[this.capacity];
            List<int> dr = new List<int>();
        }
        public int Size { get { return size; } }

        public T this[int index] 
        { 
            get
            {
                if (index >= this.Size || index < 0)
                {
                    throw new IndexOutOfRangeException("The required index is invalid!");
                }
                return this.arr[index];
            }
            set
            {
                if (index >= this.Size || index < 0)
                {
                    throw new IndexOutOfRangeException("The required index is invalid!");
                }

                this.arr[index] = value;
            } 
        }

        public void Add(T element)
        {
            if (size == capacity)
            {
                capacity += CAPACITY;
                T[] newArr = new T[this.capacity];
                Array.Copy(arr,newArr,size);
                arr = newArr;
            }
            this.arr[this.size] = element;
            this.size++;
        }
        public void RemoveAt(int index)
        {
            this.arr[index] = default(T);
            T[] newArr = new T[arr.Length];
            for (int i = 0; i < index; i++)
            {
                newArr[i] = arr[i];
            }
            for (int i = index + 1; i < arr.Length; i++)
            {
                
                    newArr[i -1 ] = arr[i];
            }
            arr = newArr;
            size--;
            if (capacity % 16 >= 5 && size < capacity)
            {
                capacity -= CAPACITY;
                T[] newWArr = new T[this.capacity];
                Array.Copy(arr, newWArr, size);
                arr = newWArr;
            }
        }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
