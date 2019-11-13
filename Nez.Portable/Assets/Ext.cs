#if EXTENDED
using System;
using System.IO;

namespace Microsoft.Xna.Framework
{
    public static class TitleContainerExt
    {
        public static Func<string, Stream> OnGetStream;
    }

    public static class TitleContainer
    {
        public static Stream OpenStream(string name)
        {
            return TitleContainerExt.OnGetStream(name);
        }
    }
}
#endif