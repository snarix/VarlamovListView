using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlamovListView
{
    public class Hardware
    {
        public int TypeCPU { get; set; }
        public int Memory { get; set; }
        public int HDD { get; set; }
        public string Video { get; set; }

    }
        public static class Value
        {
            public static ObservableCollection<Hardware> hardwares;
        }
}
