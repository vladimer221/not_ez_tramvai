using notez.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notez.Drawnings;

public class DrawningTramvaiBus
{
    /// <summary>
    /// Класс-сущности
    /// </summary>
    public ClassTramvaiBus? ClassTramvaiBus { get; protected set; }

    /// <summary>
    /// Ширина окна
    /// </summary>
    private int? _pictureWight;

    /// <summary>
    /// Высота окна
    /// </summary>
    private int? _pictureHeight;

    /// <summary>
    /// Левая координата прорисовка автобуса
    /// </summary>
    protected int? _startPosX;

    /// <summary>
    /// верхняя координата прорисовки автобуса
    /// </summary>
    protected int? _startPosY;

    /// <summary>
    /// Ширина прорисовка автобуса
    /// </summary>
    private readonly int _drawningBusWight = 180;

    /// <summary>
    /// Высота прорисовки автобуса
    /// </summary>
    private readonly int _drawingBusHeight = 85;

    public int? GetPosX => _startPosX;

    public int? GetPosY => _startPosY;

    public int GetWight => _drawningBusWight;

    public int GetHeight => _drawingBusHeight;

    private DrawningTramvaiBus()
    {
        _pictureWight = null;
        _pictureHeight = null;
        _startPosX = null;
        _startPosY = null;
    }

    public DrawningTramvaiBus(int speed, double weight, Color bodycolor) : this()
    {
        ClassTramvaiBus = new ClassTramvaiBus(speed, weight, bodycolor);
    }

    protected DrawningTramvaiBus(int drawningBusWight, int drawningBusHeight ) : this()
    {
        _drawningBusWight = drawningBusWight;
        _pictureHeight = drawningBusHeight;

    }

    public bool SetPictureSize(int width, int height)
    {
        _pictureWight = width;
        _pictureHeight = height;
        if (_pictureWight > _drawningBusWight && _pictureHeight > _drawingBusHeight)
        {
            return true;
        }
        else 
        { 
            return false;
        }

    }

    public void SetPosition(int x, int y)
    {
        if (!_pictureHeight.HasValue || !_pictureWight.HasValue)
        {
            return;
        }
        if (x > _pictureHeight.Value)
        {
            x = _pictureWight.Value;
        }
        if (y > _pictureHeight.Value)
        {
            y = _pictureHeight.Value;
        }
        _startPosX = x;
        _startPosY = y;
    }

    public bool MoveTransport(DirectionType direction)
    {
        if (ClassTramvaiBus == null || !_startPosX.HasValue || !_startPosY.HasValue)
        {
            return false;
        }
        switch (direction)
        {
            case DirectionType.Left:
                if (_startPosX.Value - ClassTramvaiBus.Step > 0)
                {
                    _startPosX -= (int)ClassTramvaiBus.Step;
                }
                return true;

            case DirectionType.Up:
                if (_startPosY.Value - ClassTramvaiBus.Step > 0)
                {
                    _startPosY -= (int)ClassTramvaiBus.Step;
                }
                return true;

            case DirectionType.Right:
                if (_startPosX.Value + ClassTramvaiBus.Step + _drawningBusWight < _pictureWight)
                {
                    _startPosX += (int)ClassTramvaiBus.Step;
                }
                return true;
            case DirectionType.Down:
                if (_startPosY.Value + ClassTramvaiBus.Step + _drawingBusHeight < _pictureHeight)
                {
                    _startPosY += (int)ClassTramvaiBus.Step;
                }
                return true;

            default:
                return false;
        }
    }

    public virtual void DrawTransport(Graphics g)
    {
        if (ClassTramvaiBus == null || !_startPosX.HasValue || !_startPosY.HasValue)
        {
            return;
        }


        Pen pen = new(Color.Black);
        Brush brB = new SolidBrush(ClassTramvaiBus.BodyColor);

        // g.DrawRectangle(pen, _startPosX.Value, _startPosY.Value, _drawningBusWight, _drawingBusHeight);
        // g.DrawRectangle(pen, _startPosX.Value + (int)_drawningBusWight, _startPosY.Value + (int)_drawingBusHeight, (int)ClassTramvaiBus.Step, 1);
        // g.DrawRectangle(pen, _startPosX.Value + (int)_drawningBusWight, _startPosY.Value + (int)_drawingBusHeight, 1, (int)ClassTramvaiBus.Step);
        // g.DrawRectangle(pen, 1, 1, (float)_pictureWight - 2, (float)_pictureHeight - 2);

        // g.DrawRectangle(pen, (int)_pictureWight / 2, 0, 1, (int)_pictureHeight);
        // g.DrawRectangle(pen, 0, (int)_pictureHeight / 2, (int)_pictureWight, 1);

        // Рисуем кузов автобуса
        g.FillRectangle(brB, _startPosX.Value, _startPosY.Value, 150, 60);
        g.DrawRectangle(pen, _startPosX.Value, _startPosY.Value, 150, 60);

        // Рисуем дверь
        g.FillRectangle(Brushes.White, _startPosX.Value + 67, _startPosY.Value + 10, 25, 50);
        g.DrawRectangle(pen, _startPosX.Value + 67, _startPosY.Value + 10, 25, 50);

        // Рисуем 
        //g.FillRectangle()
        g.FillRectangle(Brushes.White, _startPosX.Value + 110, _startPosY.Value + 10, 30, 30);
        g.DrawRectangle(pen, _startPosX.Value + 110, _startPosY.Value + 10, 30, 30);
        g.FillRectangle(Brushes.White, _startPosX.Value + 20, _startPosY.Value + 10, 30, 30);
        g.DrawRectangle(pen, _startPosX.Value + 20, _startPosY.Value + 10, 30, 30);

        // Рисуем колеса
        g.FillEllipse(Brushes.Black, _startPosX.Value + 20, _startPosY.Value + 55, 30, 30);
        g.FillEllipse(Brushes.Black, _startPosX.Value + 110, _startPosY.Value + 55, 30, 30);

    }
}
