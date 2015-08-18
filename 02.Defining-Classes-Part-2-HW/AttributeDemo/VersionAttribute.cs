namespace AttributeDemo
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = true)]
    public class VersionAttribute : Attribute
    {
        private int major;
        private int minor;

        public VersionAttribute(int major, int minor)
        {
            this.major = major;
            this.minor = minor;
        }

        public string Version
        {
            get
            {
                return string.Format(this.major + "." + this.minor);
            }
        }
    }
}
