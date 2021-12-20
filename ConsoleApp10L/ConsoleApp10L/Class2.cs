using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Collections.Specialized;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10L
{
    class ServicesList : IOrderedDictionary
    {
        Queue<Services> servicesList = new Queue<Services>();
        public ServicesList() { }

        public ServicesList(params Services[] values)
        {
            foreach (Services item in values)
                Add(item, values);
        }

        public object this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object this[object key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICollection Keys => throw new NotImplementedException();

        public ICollection Values => throw new NotImplementedException();

        public bool IsReadOnly => false;

        public bool IsFixedSize => throw new NotImplementedException();

        public int Count => servicesList.Count;

        public object SyncRoot => false;

        public bool IsSynchronized => true;

        public void Add(object key, object value)
        {
            servicesList.Enqueue(new Services());
        }

        public void Show() 
        {
            if(servicesList.Count != 0)
                foreach (var item in servicesList)
                {
                    Console.WriteLine(item.ToString());
                }
            else
            Console.WriteLine("Пусто!");
        }

        public void AddLast(Services item) 
        {
            servicesList.Enqueue(item);
        }

        public void RemoveFirst()
        {
            servicesList.Dequeue();
        }

        public void Clear()
        {
            servicesList.Clear();
        }

        public void Contains(Services key)
        {
            servicesList.Contains(key);
        }

        public void CopyTo(Services[] array, int arrayIndex)
        {
            servicesList.CopyTo(array, arrayIndex);
        }

        public void Insert(int index, object key, object value)
        {
            servicesList.Dequeue();
        }


        bool IDictionary.Contains(object key)
        {
            return servicesList.Contains(key);
        }

        void ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return servicesList.GetEnumerator();
        }

        void IDictionary.Remove(object key)
        {
            servicesList.Dequeue();
        }

        void IOrderedDictionary.RemoveAt(int index)
        {
            servicesList.Dequeue();
            servicesList.Enqueue(new Services());
        }

        IDictionaryEnumerator IOrderedDictionary.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IDictionaryEnumerator IDictionary.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}