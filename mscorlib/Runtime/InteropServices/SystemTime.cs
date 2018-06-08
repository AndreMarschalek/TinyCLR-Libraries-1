﻿using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices {
    public static class SystemTime {
        [MethodImpl(MethodImplOptions.InternalCall)]
        [CLSCompliant(false)]
        public static extern void SetSystemTime(ulong utcTicks, int timezoneOffsetMinutes);
    }
}