using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    internal class karyawan
    {
        private string _id;
        private string _nama;
        private string _id_dep;

        public string id
        {
            get { return _id; }
        }
        public string nama
        {
            get { return _nama; }
            set { _nama = value; }
        }
        public string id_dep
        {
            get { return _id_dep; }
            set { _id_dep = value; }
        }
    }
}
