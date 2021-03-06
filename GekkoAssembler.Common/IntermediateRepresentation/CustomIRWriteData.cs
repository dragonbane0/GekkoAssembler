﻿namespace GekkoAssembler.IntermediateRepresentation
{
    public class CustomIRWriteData : IRWriteData
    {
        public override int Address { get; }

        public override byte[] Data { get; }

        public CustomIRWriteData(int address, byte[] data)
        {
            Address = address;
            Data = data;
        }
    }
}
