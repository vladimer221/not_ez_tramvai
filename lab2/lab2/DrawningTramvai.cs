using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2


/// <summary>
/// 
/// </summary>
public class DrawningTramvai
{
    /// <summary>
    /// Класс-сущности
    /// </summary>
    public ClassTramvai? ClassTramvai { get; private set; }

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
    private int? _startPosX;

    /// <summary>
    /// верхняя координата прорисовки автобуса
    /// </summary>
    private int? _startPosY;

    /// <summary>
    /// Ширина прорисовка автобуса
    /// </summary>
    private readonly int _drawningBusWight = 350;

    /// <summary>
    /// Высота прорисовки автобуса
    /// </summary>
    private readonly int _drawingBusHeight = 85;

    public void Init(int speed, double weight, Color bodycolor, Color additionalColor, bool accordion, bool line, bool seconddoor)
    {
        ClassTramvai = new ClassTramvai();
        ClassTramvai.Init(speed, weight, additionalColor, bodycolor, accordion, line, seconddoor);
        _pictureWight = null;
        _pictureHeight = null;
        _startPosX = null;
        _startPosY = null;
    }

    public bool SetPictureSize(int width, int height)
    {
        _pictureWight = width;
        _pictureHeight = height;
        if (_pictureWight > _drawningBusWight && _pictureHeight > _drawingBusHeight)
        {
            return true;
        }
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
        _startPosX = x;
        _startPosY = y;
    }

    public bool MoveTransport(DirectionType direction)
    {
        if (ClassTramvai == null || !_startPosX.HasValue || !_startPosY.HasValue)
        {
            return false;
        }
        switch (direction)
        {
            case DirectionType.Left:
                if (_startPosX.Value - ClassTramvai.Step > 0)
                {
                    _startPosX -= (int)ClassTramvai.Step;
                }
                return true;

            case DirectionType.Up:
                if (_startPosY.Value - ClassTramvai.Step > 0)
                {
                    _startPosY -= (int)ClassTramvai.Step;
                }
                return true;

            case DirectionType.Right:
                if (_startPosX.Value + ClassTramvai.Step + _drawningBusWight < _pictureWight)
                {
                    _startPosX += (int)ClassTramvai.Step;
                }
                return true;
            case DirectionType.Down:
                if (_startPosY.Value + ClassTramvai.Step + _drawingBusHeight < _pictureHeight)
                {
                    _startPosY += (int)ClassTramvai.Step;
                }
                return true;

            default:
                return false;
        }
    }

    public void DrawTransport(Graphics g)
    {
        if (ClassTramvai == null || !_startPosX.HasValue || !_startPosY.HasValue)
        {
            return;
        }

        Pen pen = new(Color.Black);
        Brush additionalBrush = new SolidBrush(ClassTramvai.AdditionalColor);

        ///g.DrawRectangle(pen, _startPosX.Value, _startPosY.Value, _drawningBusWight, _drawingBusHeight);

        // Рисуем кузов автобуса
        g.FillRectangle(Brushes.Yellow, _startPosX.Value, _startPosY.Value, 150, 60);
        g.DrawRectangle(pen, _startPosX.Value, _startPosY.Value, 150, 60);
        g.FillRectangle(Brushes.Bisque, _startPosX.Value + 200, _startPosY.Value, 150, 60);
        g.DrawRectangle(pen, _startPosX.Value + 200, _startPosY.Value, 150, 60);
        // Рисуем дверь
        g.FillRectangle(Brushes.White, _startPosX.Value + 67, _startPosY.Value + 10, 25, 50);
        g.DrawRectangle(pen, _startPosX.Value + 67, _startPosY.Value + 10, 25, 50);

        // Рисуем 

        if (ClassTramvai.Line)
        {
            g.FillRectangle(additionalBrush, _startPosX.Value + 110, _startPosY.Value + 10, 30, 30);
            g.FillRectangle(additionalBrush, _startPosX.Value + 20, _startPosY.Value + 10, 30, 30);
            g.FillRectangle(additionalBrush, _startPosX.Value + 215, _startPosY.Value + 10, 30, 30);
            g.FillRectangle(additionalBrush, _startPosX.Value + 310, _startPosY.Value + 10, 30, 30);
        }
        if (ClassTramvai.Accordion)
        {
            g.DrawRectangle(pen, _startPosX.Value + 150, _startPosY.Value + 10, 50, 45);
            g.FillRectangle(additionalBrush, _startPosX.Value + 150, _startPosY.Value + 10, 50, 45);
        }
        if (ClassTramvai.SecondDoor)
        {
            g.DrawRectangle(pen, _startPosX.Value + 267, _startPosY.Value + 10, 25, 50);
            g.FillRectangle(additionalBrush, _startPosX.Value + 267, _startPosY.Value + 10, 25, 50);
        }

        g.DrawRectangle(pen, _startPosX.Value + 110, _startPosY.Value + 10, 30, 30);
        g.DrawRectangle(pen, _startPosX.Value + 20, _startPosY.Value + 10, 30, 30);


        // Рисуем колеса
        g.FillEllipse(Brushes.Black, _startPosX.Value + 20, _startPosY.Value + 55, 30, 30);
        g.FillEllipse(Brushes.Black, _startPosX.Value + 110, _startPosY.Value + 55, 30, 30);



        g.DrawRectangle(pen, _startPosX.Value + 150, _startPosY.Value + 10, 50, 45);



        g.FillEllipse(Brushes.Black, _startPosX.Value + 220, _startPosY.Value + 55, 30, 30);
        g.FillEllipse(Brushes.Black, _startPosX.Value + 300, _startPosY.Value + 55, 30, 30);



        g.DrawRectangle(pen, _startPosX.Value + 215, _startPosY.Value + 10, 30, 30);
        g.DrawRectangle(pen, _startPosX.Value + 310, _startPosY.Value + 10, 30, 30);



    }
}
