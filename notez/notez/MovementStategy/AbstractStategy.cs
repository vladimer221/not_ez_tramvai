using System.Reflection.Metadata.Ecma335;

namespace notez.MovementStategy;

public abstract class AbstractStategy
{
    private IMoveableOblect? _moveableObject;

    private StrategyStatus _state = StrategyStatus.NotInit;

    protected int FieldWight { get; private set; }

    protected int FieldHight { get; private set; }

    public StrategyStatus GetStatus() { return _state; }

    public void SetData(IMoveableOblect moveableOblect, int wight, int height)
    {
        if (moveableOblect == null)
        {
            _state = StrategyStatus.NotInit;
            return;
        }

        _state = StrategyStatus.NotInit;
        _moveableObject = moveableOblect;
        FieldHight = wight;
        FieldWight = height;
    }

    public void MakeStep()
    {
        if (_state == StrategyStatus.InProgress)
        {
            return;
        }

        if (IsTargetDestinaion())
        {
            _state = StrategyStatus.Finish;
            return;
        }

        MoveToTarget();
    }

        protected bool MoveLeft() => MoveTo(MovementDirection.Left);

        protected bool MoveRight() => MoveTo(MovementDirection.Right);

        protected bool MoveUp() => MoveTo(MovementDirection.Up);

        protected bool MoveDown() => MoveTo(MovementDirection.Down);

        protected ObjectParameters? GetObjectParameters => _moveableObject?.GetObjectPosition;

        protected int? GetStep()
        {
            if (_state  != StrategyStatus.InProgress)
            {
                return null;            
            }   
            return _moveableObject?.GetStep;

         
        }
        protected abstract void MoveToTarget();

        protected abstract bool IsTargetDestinaion();
        
        private bool MoveTo(MovementDirection movementDirection)
        {
            if (_state != StrategyStatus.InProgress)
            {
                return false;
            }   

            return _moveableObject?.TryMoveObject(movementDirection) ?? false;
        }
}
