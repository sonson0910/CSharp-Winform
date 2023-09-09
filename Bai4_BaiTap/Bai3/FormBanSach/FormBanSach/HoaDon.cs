using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBanSach
{
    public class HoaDon
    {
        string name, phoneNumber, product;
        bool cash, sec, credit, pnb, fax, email;

        public HoaDon(string name, string phoneNumber, string product)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.product = product;
        }

        public HoaDon(string name, string phoneNumber, string product, bool cash, bool sec, bool credit, bool pnb, bool fax, bool email) : this(name, phoneNumber, product)
        {
            this.cash = cash;
            this.sec = sec;
            this.credit = credit;
            this.pnb = pnb;
            this.fax = fax;
            this.email = email;
        }

        public string nameAndPhoneNumber()
        {
            return name + " " + phoneNumber + " ";
        }

        

        public string Name { get => name; set => name = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Product { get => product; set => product = value; }
    }
}
