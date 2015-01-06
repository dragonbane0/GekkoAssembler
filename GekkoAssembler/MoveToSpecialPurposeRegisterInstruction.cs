﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GekkoAssembler
{
    public class MoveToSpecialPurposeRegisterInstruction : IGekkoInstruction
    {
        public int Address { get; }
        public int ByteCode
        {
            get
            {
                return 0x7C0003A6 | (RegisterSource << 21) | ((SpecialPurposeRegister & 0x1F) << 16) | ((SpecialPurposeRegister >> 5) << 11);
            }
        }

        public int SpecialPurposeRegister { get; }
        public int RegisterSource { get; }

        public MoveToSpecialPurposeRegisterInstruction(int address, int specialPurposeRegister, int registerSource)
        {
            Address = address;
            RegisterSource = registerSource;
            SpecialPurposeRegister = specialPurposeRegister;
        }
    }
}
