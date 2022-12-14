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
using System.Diagnostics;

namespace Metin2KeyForcer.Metin2
{
    internal static class KeyWriter
    {
        private const int KeyPointerHigherLevel = 0x3d070c;
        private const int Offset = 0x42;


        internal static void SetMetin2Key(string process, byte[] buffer)
        {
            Metin2Key key = new Metin2Key(Process.GetProcessesByName(process)[0],
                                          new IntPtr(GetBase(process) + KeyPointerHigherLevel), new int[] {Offset});
            key.WriteKey(buffer);
        }

        private static long GetBase(string process)
        {
            Process proc = Process.GetProcessesByName(process)[0];
            return proc.MainModule.BaseAddress.ToInt64();
        }
    }
}