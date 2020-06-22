using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMana.DTO
{
    class Sale
    {

        int      _ID;
        int      _UserID;
        DateTime _Time;
        decimal  _TotalBill;
        decimal  _CashGiven;
        decimal  _CashReturn;

        public int      ID         { get => _ID; set => _ID = value; }
        public int      UserID     { get => _UserID; set => _UserID = value; }
        public DateTime Time       { get => _Time; set => _Time = value; }
        public decimal  TotalBill  { get => _TotalBill; set => _TotalBill = value; }
        public decimal  CashGiven  { get => _CashGiven; set => _CashGiven = value; }
        public decimal  CashReturn { get => _CashReturn; set => _CashReturn = value; }
    }
}
