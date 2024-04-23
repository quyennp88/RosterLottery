using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    [Flags]
    public enum Status
    {
        Waiting = 0,
        Win = 1,
        Fail = 2
    }
}
