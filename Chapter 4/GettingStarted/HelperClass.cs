using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GettingStarted
{
    class HelperClass
    {
        public int HelpWithNumbers(int i, int j)
        {
            return i * j;
        } 

        public int MoreHelpWithNumbers(int i, int j, int k)
        {
            return HelpWithNumbers(i, j) - HelpWithNumbers(j, k);
        }

        private string value1 = String.Empty;
        private string value2 = String.Empty;
        private string value3 = String.Empty;
        private string value4 = String.Empty;
        private string value5 = String.Empty;

    }
}
