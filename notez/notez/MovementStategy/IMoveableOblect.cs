namespace notez.MovementStategy;

public interface IMoveableOblect
{
    ObjectParameters? GetObjectPosition { get; }

    int GetStep {  get; }

    bool TryMoveObject(MovementDirection direction);
}
