using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms1
{
    class NWD {
        private int a;
        private int b;

        public NWD(int a, int b) {
            this.a = a;
            this.b = b;
        }

        public int GetNWD() {
            while (b != 0) {
                int temp = a;
                a = b;
                b = temp % b;
            }
            return a;
        }
    }
}
