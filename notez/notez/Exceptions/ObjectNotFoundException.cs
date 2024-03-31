using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace notez.Exceptions;

[Serializable]

internal class ObjectNotFoundException : ApplicationException
{
    public ObjectNotFoundException(int i) : base("Не найден обьект по позиции" + i) { }

    public ObjectNotFoundException() : base() { }

    public ObjectNotFoundException(string message) : base(message) { }

    public ObjectNotFoundException(string message,  Exception exception) : base(message, exception) { }

    protected ObjectNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}
