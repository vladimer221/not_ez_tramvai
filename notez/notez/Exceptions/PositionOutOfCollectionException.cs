using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace notez.Exceptions;

[Serializable]

internal class PositionOutOfCollectionException : ApplicationException
{
    public PositionOutOfCollectionException(int i) : base("Выход за границы коллекции. Позиции" +i) { }

    public PositionOutOfCollectionException() : base() { }

    public PositionOutOfCollectionException(string message) : base(message) { }

    public PositionOutOfCollectionException(string message, Exception exception) : base(message, exception) { } 

    protected PositionOutOfCollectionException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}
