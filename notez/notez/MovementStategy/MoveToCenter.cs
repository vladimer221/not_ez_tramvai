namespace notez.MovementStategy;

public class MoveToCenter : AbstractStategy
{
    protected override bool IsTargetDestinaion()
    {
        ObjectParameters? objParams = GetObjectParameters;
        if (objParams == null)
        {
            return false;
        }
        return objParams.ObjectMiddleHorizont - GetStep() <= FieldWight / 2 && objParams.ObjectMiddleHorizont + GetStep() >= FieldWight / 2 &&
            objParams.ObjectMiddleVertical - GetStep() <= FieldHight / 2 && objParams.ObjectMiddleVertical + GetStep() >= FieldHight / 2;
    }

    protected override void MoveToTarget()
    {
        ObjectParameters? objParams = GetObjectParameters;
        if (objParams == null)
        {
            return;
        }
        int diffX = objParams.ObjectMiddleHorizont - FieldWight / 2;
        if (Math.Abs(diffX) > GetStep())
        {
            if (diffX > 0)
            {
                MoveLeft();
            }
            else
            {
                MoveRight();
            }
        }
        int diffY = objParams.ObjectMiddleVertical - FieldHight / 2;
        if (Math.Abs(diffY) > GetStep())
        {
            if (diffY > 0)
            {
                MoveUp();
            }
            else
            {
                MoveDown();
            }
        }
    }
}
