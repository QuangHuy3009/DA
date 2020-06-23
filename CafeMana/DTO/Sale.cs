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
        int      _SalesManID;
        DateTime _Time;
        decimal  _Total;
        decimal  _CashGiven;
        decimal  _CashReturn;

        public int      ID         { get => _ID; set => _ID = value; }
        public int      SalesManID { get => _SalesManID; set => _SalesManID = value; }
        public DateTime Time       { get => _Time; set => _Time = value; }
        public decimal  Total      { get => _Total; set => _Total = value; }
        public decimal  CashGiven  { get => _CashGiven; set => _CashGiven = value; }
        public decimal  CashReturn { get => _CashReturn; set => _CashReturn = value; }
    }
}
