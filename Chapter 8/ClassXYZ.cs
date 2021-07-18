using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CSWpfApp
{
    class ClassXYZ
    {

        public void MethodXYZ(string name)
        {
            var start = 1;
            var data = InternalMethod(start + 2);
            var result = AnotherInternalMethod(name, data);
        }


        private object AnotherInternalMethod(string data2, string name)
        {
            var data = InternalMethod(2.0);
            var result = AnotherInternalMethod(data, name);
            return data;
        }

        private string InternalMethod(double v)
        {
            throw new NotImplementedException();
        }

        private string displayName;

        public string DisplayName
        {
            get
            {
                return displayName;
            }

            set
            {
                displayName = value;
            }
        }
    }
}
