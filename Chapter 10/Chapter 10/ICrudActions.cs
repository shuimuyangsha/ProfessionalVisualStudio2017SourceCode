using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_10
{
    public interface ICrudActions
    {
        int UniqueId { get; set; }

        void Create();
        void Delete();
        void Read();
        void Update();
    }
}