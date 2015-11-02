﻿namespace GekkoAssembler.IntermediateRepresentation
{
    public class IRSigned8Unequal : IIRUnit
    {
        public int Address { get; }
        public sbyte Value { get; }

        public IRCodeBlock ConditionalCode { get; }

        public IRSigned8Unequal(int address, sbyte value, IRCodeBlock conditionalCode)
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
