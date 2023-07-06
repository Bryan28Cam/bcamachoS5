using System;
using System.Collections.Generic;
using System.Text;

namespace bcamachoS5
{
    public interface Mensaje
    {
        void LongAlert(string mensaje);
        void ShortAlert(string mensaje);
    }
}
