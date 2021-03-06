﻿namespace GekkoAssembler.IntermediateRepresentation
{
    public class IRSigned32Equal : IIRUnit
    {
        public int Address { get; }
        public int Value { get; }

        public IRCodeBlock ConditionalCode { get; }

        public IRSigned32Equal(int address, int value, IRCodeBlock conditionalCode)
        {
            Address = address;
            Value = value;
            ConditionalCode = conditionalCode;
        }

        public void Accept(IIRUnitVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
