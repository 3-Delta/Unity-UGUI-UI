using System;
using System.Collections.Generic;
using System.Reflection;

namespace ILRuntime.Runtime.Generated
{
    public static class CLRManualBindings
    {
        public static void Initialize(ILRuntime.Runtime.Enviorment.AppDomain appDomain)
        {
            ManualBinding_UnityEngine_GameObject.Register(appDomain);
        }
    }
}
