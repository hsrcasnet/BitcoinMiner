using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinMiner.Console
{
    public enum WorkState : long // CA1028
    {
        Idle = 2,
        InProgress = 3,
    }
}
