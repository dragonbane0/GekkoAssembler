﻿namespace GekkoAssembler.GekkoInstructions
{
    public sealed class StoreWordInstruction : GekkoInstruction
    {
        public enum Opcode
        {
            STW  = 36,
            STWU = 37
        }

        public override int ByteCode { get; }

        public StoreWordInstruction(int address, int rS, int offset, int rA, Opcode opcode) : base(address)
        {
            ByteCode = ((int)opcode << 26 | rS << 21 | rA << 16 | offset & 0xFFFF);
        }
    }
}
