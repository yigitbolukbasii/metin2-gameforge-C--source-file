#region License

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

namespace Metin2AuthServerEmulator.Network.Packets
{
    internal enum InPackets
    {
        HandshakePacket = 0xFF,
        LoginPacket = 0x6F
    }

    internal enum OutPackets
    {
        HandshakeOpenPacket = 0xFD,
        HandshakeMidPacket = 0xFF,
        HandshakeClosePacket = 0xFD,
        LoginOkPacket = 0x96,
        LoginFailPacket = 0x07
    }
}