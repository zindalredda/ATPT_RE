using System;

using UnityEngine;

namespace MisoL.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ReadonlyFieldAttribute : PropertyAttribute
    {
    }
}
