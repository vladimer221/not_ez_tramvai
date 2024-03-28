using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notez.CollectionGenericObjects;

public class StorageCollection <T>
        where T : class
{
    private Dictionary<string, ICollectionGenericObjects<T>> _storages;
    public List<string> Keys => _storages.Keys.ToList();

    public StorageCollection()
    {
        _storages = new Dictionary<string, ICollectionGenericObjects<T>>();
    }

    public void AddCollection(string name, CollectionType collectionType)
    {
        if (string.IsNullOrEmpty(name) || _storages.ContainsKey(name))
        {
            return;
        }

        switch (collectionType)
        {
            case CollectionType.LinkedList:
                _storages[name] = new LinkedListGenericObject<T>();
                break;
            case CollectionType.Massive:
                _storages[name] = new MassiveGenericObjects<T>();
                break;
            default:
                return;
        }
    }

    public void DelCollection(string name)
    {
        if (_storages.ContainsKey(name))
        {
            _storages.Remove(name);
        }
        else
        {
            return;
        }
    }

    public ICollectionGenericObjects<T>? this[string name]
    {
        get
        {
            if (_storages.ContainsKey(name))
            {
                return _storages[name];
            }
            else
            {
                return null;
            }
        }
    }

}

