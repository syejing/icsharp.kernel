﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICSharp.Kernel.Messages
{
    public class HistoryReply : ShellMessage
    {
        public List<string> history { get; set; }
    }
}
