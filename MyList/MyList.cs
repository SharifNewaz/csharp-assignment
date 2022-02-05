using System;

namespace Generics
{
    public class MyList<T>
    {
        List<T> _list;

        public MyList()
        {
            _list = new List<T>();
        }

        public void Add(T element)
        {
            _list.Add(element);
        }

        public T Remove(int index)
        {
            if (index < 0 || index > _list.Count || _list.Count <= 0)
                throw new IndexOutOfRangeException();
                T deletedVal = _list[_list.Count-1];
                _list.RemoveAt(index);
            return deletedVal;
        }

        public bool Contains(T element)
        {
            return _list.Contains(element);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public void InsertAt(T element, int index)
        {
            _list.Insert(index, element);
        }

        public void DeleteAt(int index)
        {
            _list.RemoveAt(index);
        }

        public T Find(int index)
        {
            return _list[index];
            
        }
    }
}

