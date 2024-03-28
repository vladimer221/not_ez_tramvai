using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace notez.CollectionGenericObjects;

public class MassiveGenericObjects<T> : ICollectionGenericObjects<T>
    where T : class
{
    private T?[] _collection;
    
    public int Count => _collection.Length;

    public int SetMaxCount
    {
        set
        {
            if (value > 0)
            {
                if (_collection.Length > 0)
                {
                    Array.Resize(ref _collection, value);
                }
                else
                {
                    _collection = new T?[value];
                }
            }
        }
    }

    public MassiveGenericObjects()
    {
        _collection = Array.Empty<T?>();
    }

    public T? Get(int position)
    {
        if (position < 0 || position >= _collection.Length)
        {
            throw new IndexOutOfRangeException("Неправильная позиция");
        }

        return _collection[position];
    }

    public bool Insert(T obj)

    {
        for (int i = 0; i < _collection.Length; i++)
        {
            if (_collection[i] == null)
            {
                _collection[i] = obj;
                return true;
            }
        }
        return false;
    }

    public bool Insert(T obj, int position)
    {

        if (position < 0 || position >= _collection.Length)
        {
            throw new IndexOutOfRangeException("Invalid position");
        }


        if (_collection[position] == null)
        {
            _collection[position] = obj;
            return true;
        }


        for (int i = position + 1; i < _collection.Length; i++)
        {
            if (_collection[i] == null)
            {
                _collection[i] = obj;
                return true;
            }
        }

        for (int i = position - 1; i >= 0; i--)
        {
            if (_collection[i] == null)
            {
                _collection[i] = obj;
                return true;
            }
        }

        return false;
    }


    public bool Remove(int position)
    {
        if (position < 0 || position >= _collection.Length)
        {
            throw new IndexOutOfRangeException("Invalid position");
        }

        _collection[position] = null;
        return true;
    }
}
