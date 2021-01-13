using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Meals_MenuDTO
    {
        public int Meals_Menu_Kod { get; set; }
        public int Organization_Kod { get; set; }
        public int Food_Type { get; set; }
        public int Amount { get; set; }
        public int Status { get; set; }

        public  Food_TypeDTO Food_Type1 { get; set; }
        public virtual OrganizationDTO Organization { get; set; }
        public virtual Status_FoodDTO Status_Food { get; set; }
    }
}
