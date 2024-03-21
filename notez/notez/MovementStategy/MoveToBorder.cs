
namespace notez.MovementStategy;

public class MoveToBorder : AbstractStategy
{
        protected override bool IsTargetDestinaion()
    {
            ObjectParameters? objParams = GetObjectParameters;
            if (objParams == null)
            {
                return false;
            }
            return objParams.RightBorder + GetStep() >= FieldWight && objParams.DownBorder + GetStep() >= FieldHight;
        }

        protected override void MoveToTarget()
        {
            ObjectParameters? objParams = GetObjectParameters;
            if (objParams == null)
            {
                return;
            }

            int diffX = objParams.RightBorder - FieldWight;
            if (Math.Abs(diffX) > GetStep())
            {
                if (diffX < 0)
                {
                    MoveRight();
                }
            }

            int diffY = objParams.DownBorder - FieldHight;
            if (Math.Abs(diffY) > GetStep())
            {
                if (diffY < 0)
                {
                    MoveDown();
                }
            }
        }
    }