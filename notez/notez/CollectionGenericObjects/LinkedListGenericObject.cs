using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notez.CollectionGenericObjects;

public class LinkedListGenericObject<T> : ICollectionGenericObjects<T>
    where T : class
{
    private readonly LinkedList<T> _collection;

    private int _maxCount;
    public int Count => _collection.Count;

    public int MaxCount
    {
        get
        {
            return _collection.Count;
        }

        set

        { if (value > 0)
            {
                _maxCount = value;
            } 
        
        }
    }

    public CollectionType GetCollectionType => CollectionType.LinkedList;

    public LinkedListGenericObject()
    {
        _collection = new();
    }
    public T? Get(int position)
    {
        if (position < 0 || position >= _collection.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(position), "Position is out of range");
        }
        var currentNode = _collection.First;
        for (int i = 0; i < position; i++)
        {
            currentNode = currentNode?.Next;
        }

        return currentNode?.Value;
    }

    public bool Insert(T obj)
    {
        if (_maxCount > 0 && _collection.Count >= _maxCount)
        {
            return false;
        }

        _collection.AddLast(obj);
        return true;
    }

    public bool Insert(T obj, int position)
    {
        if (_maxCount > 0 && _collection.Count >= _maxCount)
        {
            return false;
        }

        if (position < 0 || position > _collection.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(position), "Position is out of range.");
        }
        if (position == _collection.Count)
        {
            _collection.AddLast(obj);
        }
        else
        {
            var currentNode = _collection.First;
            for (int i = 0; i < position; i++)
            {
                currentNode = currentNode?.Next;
            }

            _collection.AddBefore(currentNode, obj);
        }
        return true;
    }

    public bool Remove(int position)
    {
        if (position < 0 || position >= _collection.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(position), "Position is out of range.");
        }
        var currentNode = _collection.First;
        for (int i = 0; i < position; i++)
        {
            currentNode = currentNode?.Next;
        }
        _collection.Remove(currentNode);
        return true;
    }

    public IEnumerable<T?> GetItems()
    {
        var currentNode = _collection.First;
        while (currentNode != null)
        {
            yield return currentNode.Value;
            currentNode = currentNode.Next;
        }
    }
}
