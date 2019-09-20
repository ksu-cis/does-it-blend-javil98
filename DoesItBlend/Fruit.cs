using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    //The differnce between the abstract and interface, is that abstract has a heirarchyl structure and is of nature, while a interface "does a".

    /// <summary>
    /// A base class representing fruit
    /// </summary>
    public abstract class Fruit : IBlendable
    {
        public abstract string Blend();
    }
}
