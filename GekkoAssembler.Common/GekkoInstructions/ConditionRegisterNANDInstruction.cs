﻿namespace GekkoAssembler.GekkoInstructions
{
    public sealed class ConditionRegisterNANDInstruction : GekkoInstruction
    {
        public override int ByteCode { get; }

        public ConditionRegisterNANDInstruction(int address, int crD, int crA, int crB) : base(address)
        {
            ByteCode = (19 << 26 | crD << 21 | crA << 16 | crB << 11 | 225 << 1);
        }
    }
}
