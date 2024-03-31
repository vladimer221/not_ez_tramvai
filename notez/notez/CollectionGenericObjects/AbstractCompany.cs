using notez.Drawnings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notez.CollectionGenericObjects;

public abstract class AbstractCompany
{
    protected readonly int _placeSizeWidth = 445;

    protected readonly int _placeSizeHeight = 120;

    protected readonly int _pictureWight;

    protected readonly int _pictureHeight;

    protected ICollectionGenericObjects<DrawningTramvaiBus>? _collection = null;
    
    private int GetMaxCount => _pictureWight * _pictureHeight / (_placeSizeWidth * _placeSizeHeight);
    
    public AbstractCompany(int picWight, int picHeight, ICollectionGenericObjects<DrawningTramvaiBus> collection) 
    {
        _pictureWight = picWight;
        _pictureHeight = picHeight;
        _collection = collection;
        _collection.MaxCount = GetMaxCount;
    }

    public static bool operator +(AbstractCompany company, DrawningTramvaiBus bus)
    {
        return company._collection?.Insert(bus) ?? false;
    }

    public static bool operator -(AbstractCompany company, int position)
    {
        return company._collection?.Remove(position) ?? false;
    }

    public DrawningTramvaiBus? GetRandomObject()
    {
        Random rnd = new ();
        return _collection?.Get(rnd.Next(GetMaxCount));
    }

    public Bitmap? Show()
    {
        Bitmap bitmap = new(_pictureWight, _pictureHeight);
        Graphics graphics = Graphics.FromImage(bitmap);
        DrawBackgound(graphics);

        SetObjectsPosition();
        for (int i = 0; i < (_collection?.Count ?? 0); ++i)
        {
          DrawningTramvaiBus? obj =_collection?.Get(i); 
            obj?.DrawTransport(graphics);
        }
        return bitmap;
    }
    protected abstract void DrawBackgound(Graphics g);

    protected abstract void SetObjectsPosition(); 
}
