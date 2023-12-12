using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    internal class departemen
    {
        private string _id_dep;
        private string _nama_dep;

        public string id_dep
        {
            get { return _id_dep; } 
        }
        public string nama_dep
        {
            get { return _nama_dep;}
            set { _nama_dep = value; }
        }
    }
}
