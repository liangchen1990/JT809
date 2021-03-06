﻿using JT809.Protocol.Extensions;
using JT809.Protocol.SubMessageBody;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace JT809.Protocol.Formatters.SubMessageBodyFormatters
{
    public class JT809_0x1200_0x120C_Formatter : IJT809Formatter<JT809_0x1200_0x120C>
    {
        public JT809_0x1200_0x120C Deserialize(ReadOnlySpan<byte> bytes, out int readSize)
        {
            int offset = 0;
            JT809_0x1200_0x120C jT809_0X1200_0X120C = new JT809_0x1200_0x120C();
            jT809_0X1200_0X120C.DriverName = JT809BinaryExtensions.ReadStringLittle(bytes, ref offset, 16);
            jT809_0X1200_0X120C.DriverID = JT809BinaryExtensions.ReadStringLittle(bytes, ref offset, 20);
            jT809_0X1200_0X120C.Licence = JT809BinaryExtensions.ReadStringLittle(bytes, ref offset, 40);
            jT809_0X1200_0X120C.OrgName = JT809BinaryExtensions.ReadStringLittle(bytes, ref offset, 200);
            readSize = offset;
            return jT809_0X1200_0X120C;
        }

        public int Serialize(ref byte[] bytes, int offset, JT809_0x1200_0x120C value)
        {
            offset += JT809BinaryExtensions.WriteStringLittle(bytes, offset, value.DriverName, 16);
            offset += JT809BinaryExtensions.WriteStringLittle(bytes, offset, value.DriverID, 20);
            offset += JT809BinaryExtensions.WriteStringLittle(bytes, offset, value.Licence, 40);
            offset += JT809BinaryExtensions.WriteStringLittle(bytes, offset, value.OrgName, 200);
            return offset;
        }
    }
}
