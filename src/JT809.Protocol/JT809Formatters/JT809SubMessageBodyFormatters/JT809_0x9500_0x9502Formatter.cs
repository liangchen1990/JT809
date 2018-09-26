﻿using JT809.Protocol.JT809Extensions;
using JT809.Protocol.JT809SubMessageBody;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace JT809.Protocol.JT809Formatters.JT809SubMessageBodyFormatters
{
    public class JT809_0x9500_0x9502Formatter : IJT809Formatter<JT809_0x9500_0x9502>
    {
        public JT809_0x9500_0x9502 Deserialize(ReadOnlySpan<byte> bytes, out int readSize)
        {
            int offset = 0;
            JT809_0x9500_0x9502 jT809_0X9500_0X9502 = new JT809_0x9500_0x9502();
            jT809_0X9500_0X9502.LensID =  JT809BinaryExtensions.ReadByteLittle(bytes, ref offset);
            jT809_0X9500_0X9502.SizeType = JT809BinaryExtensions.ReadByteLittle(bytes, ref offset);
            readSize = offset;
            return jT809_0X9500_0X9502;
        }

        public int Serialize(IMemoryOwner<byte> memoryOwner, int offset, JT809_0x9500_0x9502 value)
        {
            offset += JT809BinaryExtensions.WriteByteLittle(memoryOwner, offset, value.LensID);
            offset += JT809BinaryExtensions.WriteByteLittle(memoryOwner, offset, value.SizeType);
            return offset;
        }
    }
}