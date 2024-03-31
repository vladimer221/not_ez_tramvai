using notez.Drawnings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notez.CollectionGenericObjects;

public class StorageCollection <T>
        where T : DrawningTramvaiBus
{
    
    
    private Dictionary<string, ICollectionGenericObjects<T>> _storages;


    public List<string> Keys => _storages.Keys.ToList();

    private readonly string _collectionKey = "CollectionsStorage";

    private readonly string _separatorForKeyValue = "|";


    private readonly string _separatorItems = ";";

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

    public bool SaveData(string filename)
    {  

        if (_storages.Count == 0)
        {
            return false;
        }

        if (File.Exists(filename)) 
        {
            File.Delete(filename);
        }
        
     
        StringBuilder sb = new();

        sb.Append(_collectionKey);
        foreach (KeyValuePair<string, ICollectionGenericObjects<T>> value in _storages) 
        {
            sb.Append(Environment.NewLine);
            if (value.Value.Count == 0)
            {
                continue;
            }
            
            sb.Append(value.Key);
            sb.Append(_separatorForKeyValue);
            sb.Append(value.Value.GetCollectionType);
            sb.Append(_separatorForKeyValue);
            sb.Append(value.Value.MaxCount);
            sb.Append(_separatorForKeyValue);

            foreach (T? item in value.Value.GetItems()) 
            {
                string data = item?.GetDataForSave() ?? string.Empty;
                if (string.IsNullOrEmpty(data))
                {
                    continue;
                }

                sb.Append(data);
                sb.Append(_separatorItems);
            }
        }

        using FileStream fs = new(filename, FileMode.Create);
        byte[] info = new UTF8Encoding(true).GetBytes(sb.ToString());
        fs.Write(info, 0, info.Length);
        return true;
    }

    public bool LoadData(string filename)
    {
        if (!File.Exists(filename))
        {
            return false;
        }
        string bufferTextFromFile = "";
        using (FileStream fs = new(filename, FileMode.Open))
        {
            byte[] b = new byte[fs.Length];
            UTF8Encoding temp = new(true);
            while (fs.Read(b, 0, b.Length) > 0) 
            {
                bufferTextFromFile += temp.GetString(b); 
            }
        }

        string[] strs = bufferTextFromFile.Split(new char[] { '\n', '\r', }, StringSplitOptions.RemoveEmptyEntries);
        if (strs == null  || strs.Length == 0)
        { 
            return false;
        }
        if (!strs[0].Equals(_collectionKey)) 
        
        {
            return false; 
        }

        _storages.Clear();
        foreach (string data in strs)
        {
            string[] record = data.Split(_separatorForKeyValue, StringSplitOptions.RemoveEmptyEntries);
            if (record.Length !=4)
            {
                continue;
            }

            CollectionType collectionType = (CollectionType)Enum.Parse(typeof(CollectionType), record[1]);
            ICollectionGenericObjects<T>? collection = StorageCollection<T>.CreateCollection(collectionType);
            if (collection == null) 
            {
                return false;
            }
            collection.MaxCount = Convert.ToInt32(record[2]);

            string[] set = record[3].Split(_separatorItems , StringSplitOptions.RemoveEmptyEntries);
            foreach (string elem in set) 
            { 
                if(elem?.CreateDrawningTramvaiBus() is T bus)
                {
                    if  (!collection.Insert(bus))
                    {
                        return false;
                    }

                }
            }

            _storages.Add(record[0], collection);

        }
        return true;
    }
    private static ICollectionGenericObjects<T>? CreateCollection(CollectionType collectionType)
    {
        return collectionType switch
        {
            CollectionType.Massive => new MassiveGenericObjects<T>(),
            CollectionType.LinkedList => new LinkedListGenericObject<T>(),
            _ => null,
        };
    }
}

