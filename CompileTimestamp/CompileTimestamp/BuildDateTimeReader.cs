using System.Reflection;

namespace EzTool.SDK.Utilities.CompileTimestamp
{
    public class BuildDateTimeReader
    {
        public static DateTime ReadFrom(Assembly? pi_objSource = null)
        {
            var objAssembly = pi_objSource ?? Assembly.GetCallingAssembly();
            var objBuildDateTimeAttribute =
                Attribute.GetCustomAttribute(objAssembly, typeof(BuildDateTimeAttribute)) as BuildDateTimeAttribute;

            if (objBuildDateTimeAttribute != null
                && DateTime.TryParse(objBuildDateTimeAttribute?.Date, out DateTime dt))
            {
                return dt;
            }
            else
            {
                throw new WithoutRequiredAttributeException();
            }
        }
    }
}
