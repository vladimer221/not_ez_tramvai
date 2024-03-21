using notez.Drawnings;

namespace notez.MovementStategy;

public class MoveableBus : IMoveableOblect
{
    public readonly DrawningTramvaiBus? _bus = null;

    public MoveableBus(DrawningTramvaiBus bus)
    {
        _bus = bus;
        
    }
    public ObjectParameters? GetObjectPosition
    {
        get
        {
            if (_bus == null || _bus.ClassTramvaiBus == null || !_bus.GetPosX.HasValue || !_bus.GetPosY.HasValue)
            {
                return null;
            }
            return new ObjectParameters(_bus.GetPosX.Value, _bus.GetPosY.Value, _bus.GetWight, _bus.GetHeight);
        }
    }
    public int GetStep => (int)(_bus?.ClassTramvaiBus?.Step ?? 0);

    public bool TryMoveObject(MovementDirection direction)
    {
        if (_bus == null || _bus.ClassTramvaiBus == null)
        {
            return false;
        }
        return _bus.MoveTransport(GetDirectionType(direction));
    }
    private static DirectionType GetDirectionType(MovementDirection direction) 
    {
        return direction switch
        {
            MovementDirection.Left => DirectionType.Left,
            MovementDirection.Right => DirectionType.Right,
            MovementDirection.Up => DirectionType.Up,
            MovementDirection.Down => DirectionType.Down,
            _ => DirectionType.Unknow,
        };
    }
}
