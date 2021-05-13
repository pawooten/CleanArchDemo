﻿using CleanArch.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime TimeStamp { get; protected set; }

        protected Command()
        {
#pragma warning disable DateTimeAnalyzer
            TimeStamp = DateTime.Now;
#pragma warning restore DateTimeAnalyzer
        }
    }
}
