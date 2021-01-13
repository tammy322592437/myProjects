using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class NeedyDTO
    {
        public int Needy_Kod { get; set; }
        public int Number_Of_Persons { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string NeedyDescribe { get; set; }
        public int? AmountToHelp { get; set; }
        public int? QuantityUsed { get; set; }
        public  UserDTO User { get; set; }
    }
}
