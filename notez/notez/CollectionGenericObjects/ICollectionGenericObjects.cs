using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notez.CollectionGenericObjects;

public interface ICollectionGenericObjects<T>
    where T : class
{
    int Count { get; }

    int SetMaxCount { set; }

    bool Insert(T obj);

    bool Insert(T obj, int pozition);

    bool Remove(int pozition);

    T? Get(int position);
}
