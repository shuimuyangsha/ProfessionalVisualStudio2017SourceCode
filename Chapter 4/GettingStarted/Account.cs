using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GettingStarted
{
    public class Account
    {
        public int DivisionID { get; set; }
        public int BranchID { get; set; }
        public int CostCentreID { get; set; }

        public void BeginEdit() { }

        public void EndEdit() { }

        public void EnableValidation() { }

        private readonly string value1 = String.Empty;
        private readonly string value2 = String.Empty;
        private readonly string value3 = String.Empty;
        private readonly string value4 = String.Empty;
        private readonly string value5 = String.Empty;

    }
}
