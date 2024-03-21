using notez.entities;

namespace notez.Drawnings;

public class DrawningTramvai : DrawningTramvaiBus
{
    public  DrawningTramvai(int speed, double weight, Color bodycolor, Color additionalColor, bool accordion, bool line, bool seconddoor) : base(350, 85)
    {
        ClassTramvaiBus = new ClassTramvai(speed ,weight , bodycolor ,additionalColor, accordion, line, seconddoor);
    }

    public override void DrawTransport(Graphics g)
    {
        if (ClassTramvaiBus == null || ClassTramvaiBus is not ClassTramvai tramvai || !_startPosX.HasValue || !_startPosY.HasValue)
        {
            return;
        }

        Pen pen = new(Color.Black);
        Brush additionalBrush = new SolidBrush(tramvai.AdditionalColor);

        if (tramvai.Line)
        {
            g.FillRectangle(additionalBrush, _startPosX.Value + 110, _startPosY.Value + 10, 30, 30);
            g.FillRectangle(additionalBrush, _startPosX.Value + 20, _startPosY.Value + 10, 30, 30);
            g.FillRectangle(additionalBrush, _startPosX.Value + 215, _startPosY.Value + 10, 30, 30);
            g.FillRectangle(additionalBrush, _startPosX.Value + 310, _startPosY.Value + 10, 30, 30);
        }

        if (tramvai.Accordion)
        {
            g.DrawRectangle(pen, _startPosX.Value + 150, _startPosY.Value + 10, 50, 45);
            g.FillRectangle(additionalBrush, _startPosX.Value + 150, _startPosY.Value + 10, 50, 45);
        }
        if (tramvai.SecondDoor)
        {
            g.DrawRectangle(pen, _startPosX.Value + 267, _startPosY.Value + 10, 25, 50);
            g.FillRectangle(additionalBrush, _startPosX.Value + 267, _startPosY.Value + 10, 25, 50);
        }

        base.DrawTransport(g);
    }


}