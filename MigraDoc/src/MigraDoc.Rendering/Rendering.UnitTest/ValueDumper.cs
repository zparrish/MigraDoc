using System.Reflection;

namespace MigraDoc.Rendering.UnitTest
{
    /// <summary>
    /// Summary description for ValueDumper.
    /// </summary>
    internal class ValueDumper
    {
        internal ValueDumper()
        { }

        internal static string DumpValues(object obj)
        {
            string dumpString = "[" + obj.GetType() + "]\r\n";
            foreach (FieldInfo fieldInfo in obj.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
#if !NETCORE
                if (fieldInfo.FieldType.IsValueType)
#else
                if (fieldInfo.FieldType.GetTypeInfo().IsValueType)
#endif
                {
                    dumpString += "  " + fieldInfo.Name + " = " + fieldInfo.GetValue(obj) + "\r\n";
                }
            }
            return dumpString;
        }
    }
}
