using notez.entities;

namespace notez.Drawnings;

public class DrawningTramvai : DrawningTramvaiBus
{
    public  DrawningTramvai(int speed, double weight, Color bodycolor, Color additionalColor,Color additionalBodyColor, bool line, bool seconddoor) : base(350, 85)
    {
        ClassTramvaiBus = new ClassTramvai(speed , weight , bodycolor ,additionalColor, additionalBodyColor, line, seconddoor);
    }

    public override void DrawTransport(Graphics g)
    {
        if (ClassTramvaiBus == null || ClassTramvaiBus is not ClassTramvai tramvai || !_startPosX.HasValue || !_startPosY.HasValue)
        {
            return;
        }

        Pen pen = new(Color.Black);
        Brush additionalBrush = new SolidBrush(tramvai.AdditionalColor);
        Brush additionalBody = new SolidBrush(tramvai.AdditionalBodyColor);

       
        // гармошка
        g.DrawRectangle(pen, _startPosX.Value + 150, _startPosY.Value + 10, 50, 45);
            g.FillRectangle(additionalBody, _startPosX.Value + 200, _startPosY.Value, 150, 60);
            g.DrawRectangle(pen, _startPosX.Value + 200, _startPosY.Value, 150, 60);
            g.FillRectangle(additionalBrush, _startPosX.Value + 150, _startPosY.Value + 10, 50, 45);

        // вторая дверь
        if (tramvai.SecondDoor)
        {
            g.DrawRectangle(pen, _startPosX.Value + 267, _startPosY.Value + 10, 25, 50);
            g.FillRectangle(Brushes.White, _startPosX.Value + 267, _startPosY.Value + 10, 25, 50);
        }
        if (tramvai.Line)
        {
            g.FillRectangle(Brushes.White, _startPosX.Value + 215, _startPosY.Value + 10, 30, 30);
            g.DrawRectangle(pen, _startPosX.Value + 215, _startPosY.Value + 10, 30, 30);
            g.FillRectangle(Brushes.White, _startPosX.Value + 310, _startPosY.Value + 10, 30, 30);
            g.DrawRectangle(pen, _startPosX.Value + 310, _startPosY.Value + 10, 30, 30);
        }

        g.FillEllipse(Brushes.Black, _startPosX.Value + 220, _startPosY.Value + 55, 30, 30);

        g.FillEllipse(Brushes.Black, _startPosX.Value + 300, _startPosY.Value + 55, 30, 30);

        base.DrawTransport(g);
    }

}