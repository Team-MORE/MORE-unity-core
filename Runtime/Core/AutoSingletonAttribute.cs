using System;

namespace MORE.Core
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    public class AutoSingletonAttribute : Attribute
    {
        public bool LoadOnStart { get; private set; }
        public bool CreatePrefab { get; private set; }

        public AutoSingletonAttribute(bool loadOnStart = true, bool createPrefab = true)
        {
            LoadOnStart = loadOnStart;
            CreatePrefab = createPrefab;
        }
    }
}
