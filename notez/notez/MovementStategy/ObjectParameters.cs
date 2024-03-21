namespace notez.MovementStategy;

public class ObjectParameters
{
    private readonly int _x;

    private readonly int _y;

    private readonly int _wight;

    private readonly int _height;

    public int LeftBorder => _x;

    public int TopBorder => _y;

    public int RightBorder => _x + _wight;

    public int DownBorder => _y + _height;

    public int ObjectMiddleHorizont => _x + _wight / 2;

    public int ObjectMiddleVertical => _y + _height / 2;

    public ObjectParameters(int x, int y, int wight, int height)
    {
        _x = x;
        _y = y;
        _wight = wight;
        _height = height;
    }
}