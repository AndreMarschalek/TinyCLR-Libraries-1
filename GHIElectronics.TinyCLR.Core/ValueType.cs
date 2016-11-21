////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace System
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    [Serializable]
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public abstract class ValueType
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern override bool Equals(Object obj);

    }
}

