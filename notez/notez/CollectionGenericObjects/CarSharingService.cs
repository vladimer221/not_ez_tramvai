using notez.Drawnings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notez.CollectionGenericObjects;

public class CarSharingService : AbstractCompany
{
    private int _picWidth;
    private int _picHeight;

    private int _placeWidth = 445;
    private int _placeHeight = 120;

    public CarSharingService(int picWight, int picHeight, ICollectionGenericObjects<DrawningTramvaiBus> collection) : base(picWight, picHeight, collection)
    {
        _picWidth = picWight;
        _picHeight = picHeight;
        _collection = collection;
    }

    protected override void DrawBackgound(Graphics g)
    {
        Pen linePen = new Pen(Color.Black, 5);
        int VertLines = _picWidth / _placeWidth;
        int HorizLines = _picHeight / _placeHeight;

        for (int i = 0; i < VertLines; i++)
        {
            for (int j = 0; j < HorizLines + 1; j++)
            {
                int yPos = j * _placeHeight;
                g.DrawLine(linePen, i * 350 + (i * 95), yPos, (i + 1) * _placeWidth - 60, yPos);            }
        }
        for (int i = 0; i < VertLines; i++)
        {
            int xPos = i * _placeWidth;
            int yPos = HorizLines * _placeHeight;
            g.DrawLine(linePen, xPos, 0, xPos, yPos);

        }
    }

    protected override void SetObjectsPosition()
    {
        int x = 0;
        int y = 0;
        int maxX = _picWidth / _placeWidth;
        int maxY = _picHeight / _placeHeight;
        
        for(int i = 0; i<(_collection?.Count ?? 0); i++) 
        {
            DrawningTramvaiBus? obj = _collection?.Get(i);
            if (obj == null)
            {
                return;
            }
            obj.SetPictureSize(_picWidth, _picHeight);
            obj.SetPosition(x * _placeWidth + 10, y * _placeHeight + 5);

            if (y < maxY)
            {
                y++;
            }

            if (y == maxY)
            {
                x++;
                y = 0;
            }
        }
    }
}
