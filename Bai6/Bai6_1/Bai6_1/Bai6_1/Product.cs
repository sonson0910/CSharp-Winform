using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_1
{
    public class Product
    {
        string proCode, proName;
        int proNum;

        public Product(string proCode, string proName, int proNum)
        {
            this.proCode = proCode;
            this.proName = proName;
            this.proNum = proNum;
        }

        public string ProCode { get => proCode; set => proCode = value; }
        public string ProName { get => proName; set => proName = value; }
        public int ProNum { get => proNum; set => proNum = value; }
    }
}
