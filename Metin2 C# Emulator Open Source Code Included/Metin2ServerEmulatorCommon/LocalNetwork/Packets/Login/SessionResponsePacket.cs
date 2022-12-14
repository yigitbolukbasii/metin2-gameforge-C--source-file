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

using System;

namespace Metin2ServerEmulatorCommon.LocalNetwork.Packets.Login
{
    [Serializable]
    public class SessionResponsePacket : IPacket
    {
        public SessionResponsePacket(string username, SessionResponse response)
        {
            Username = username;
            Response = response;
        }

        public string Username { get; private set; }
        public SessionResponse Response { get; private set; }

        #region IPacket Members

        public int Id
        {
            get { return (int) LoginPackets.SessionResponsePacket; }
        }

        #endregion
    }
}