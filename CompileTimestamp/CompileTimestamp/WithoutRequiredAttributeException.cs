using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzTool.SDK.Utilities.CompileTimestamp
{
    public class WithoutRequiredAttributeException : Exception
    {
        public override string Message
        {
            get
            {
                var sReturn = string.Empty;
                string resourceName = GetType().Assembly.GetManifestResourceNames()
                    .Single(str => str.EndsWith("WithoutRequiredAttributeMessage.txt"));

                using (Stream stream = GetType().Assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    sReturn = reader.ReadToEnd();
                }

                return sReturn;
            }
        }
    }
}
