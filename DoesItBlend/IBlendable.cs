using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// A interface for items that are blendable.
    /// </summary>
    interface IBlendable
    {
        /// <summary>
        /// Blends the object;
        /// </summary>
        /// <returns></returns>
        string Blend();
    }
}
