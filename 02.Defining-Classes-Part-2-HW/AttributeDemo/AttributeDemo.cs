namespace AttributeDemo
{
    using System;

    [VersionAttribute(3, 12)]
    public class AttributeMain
    {
        public static void Main()
        {
            Type t = typeof(AttributeMain);
            object[] allAttributes = t.GetCustomAttributes(false);
            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("The class {0} is version {1}. ", attr.TypeId, attr.Version);
            }
        }
    }
}
