﻿namespace BlockchainSharp.Vm
{
    public enum Bytecodes
    {
        Stop = 0x00,

        Add = 0x01,
        Multiply = 0x02,
        Subtract = 0x03,
        Divide = 0x04,

        LessThan = 0x10,
        GreaterThan = 0x11,

        Equal = 0x14,
        IsZero = 0x15,
        And = 0x16,
        Or = 0x17,
        Xor = 0x18,
        Not = 0x19,

        Address = 0x30,
        Origin = 0x32,
        Caller = 0x33,
        Coinbase = 0x41,

        Pop = 0x50,

        MLoad = 0x51,
        MStore = 0x52,
        MStore8 = 0x53,

        SLoad = 0x54,
        SStore = 0x55,

        Jump = 0x56,
        JumpI = 0x57,

        Pc = 0x58,

        Push1 = 0x60,
        Push2 = 0x61,
        Push3 = 0x62,
        Push4 = 0x63,
        Push5 = 0x64,
        Push6 = 0x65,
        Push7 = 0x66,
        Push8 = 0x67,
        Push9 = 0x68,
        Push10 = 0x69,
        Push11 = 0x6a,
        Push12 = 0x6b,
        Push13 = 0x6c,
        Push14 = 0x6d,
        Push15 = 0x6e,
        Push16 = 0x6f,
        Push17 = 0x70,
        Push18 = 0x71,
        Push19 = 0x72,
        Push20 = 0x73,
        Push21 = 0x74,
        Push22 = 0x75,
        Push23 = 0x76,
        Push24 = 0x77,
        Push25 = 0x78,
        Push26 = 0x79,
        Push27 = 0x7a,
        Push28 = 0x7b,
        Push29 = 0x7c,
        Push30 = 0x7d,
        Push31 = 0x7e,
        Push32 = 0x7f,

        Dup1 = 0x80,
        Dup2 = 0x81,
        Dup3 = 0x82,
        Dup4 = 0x83,
        Dup5 = 0x84,
        Dup6 = 0x85,
        Dup7 = 0x86,
        Dup8 = 0x87,
        Dup9 = 0x88,
        Dup10 = 0x89,
        Dup11 = 0x8a,
        Dup12 = 0x8b,
        Dup13 = 0x8c,
        Dup14 = 0x8d,
        Dup15 = 0x8e,
        Dup16 = 0x8f,

        Swap1 = 0x90,
        Swap2 = 0x091,
        Swap3 = 0x092,
        Swap4 = 0x093,
        Swap5 = 0x094,
        Swap6 = 0x095,
        Swap7 = 0x096,
        Swap8 = 0x097,
        Swap9 = 0x098,
        Swap10 = 0x099,
        Swap11 = 0x09a,
        Swap12 = 0x09b,
        Swap13 = 0x09c,
        Swap14 = 0x09d,
        Swap15 = 0x09e,
        Swap16 = 0x09f
    }
}
