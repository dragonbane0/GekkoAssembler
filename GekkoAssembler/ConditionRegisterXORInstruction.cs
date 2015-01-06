﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GekkoAssembler
{
    public class ConditionRegisterXORInstruction : IGekkoInstruction
    {
        public int Address { get; }
        public int ByteCode
        {
            get
            {
                return (((((((((19 << 5) | ConditionRegisterDestination) << 5) | ConditionRegisterA) << 5) | ConditionRegisterB) << 10) | 193) << 1);
            }
        }

        public int ConditionRegisterDestination { get; }
        public int ConditionRegisterA { get; }
        public int ConditionRegisterB { get; }

        public ConditionRegisterXORInstruction(int address, int conditionRegisterDestination, int conditionRegisterA, int conditionRegisterB)
        {
            Address = address;
            ConditionRegisterDestination = conditionRegisterDestination;
            ConditionRegisterA = conditionRegisterA;
            ConditionRegisterB = conditionRegisterB;
        }
    }
}
