using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    internal class Karyawan
    {
        internal string _id;
        internal string _nama;
        internal string _departemen;

        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }
        public string Departemen
        {
            get { return _departemen; }
            set { _departemen = value; }
        }
        public string Id
        {
            get { return _id; }
        }
    }
}
