﻿#region License

//     This file is part of Metin 2 Server Emulator.
// 
//     Metin 2 Server Emulator is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     Metin 2 Server Emulator is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with Metin 2 Server Emulator.  If not, see <http://www.gnu.org/licenses/>

#endregion

using System;

namespace Metin2AuthServerEmulator.Network.Packets.Out
{
    internal class LoginOkPacket : IPacket
    {
        internal LoginOkPacket(uint sessionId)
        {
            Data = new byte[8];
            Data[0] = Id;
            BitConverter.GetBytes(sessionId).CopyTo(Data, 1);
            Data[5] = 0x01;
        }

        #region IPacket Members

        public byte Id
        {
            get { return (byte) OutPackets.LoginOkPacket; }
        }

        public byte[] Data { get; set; }

        #endregion
    }
}