using Dal;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
   public class NeedyConverters
    {
        public static Dal.Needy GetNeedy(DTO.NeedyDTO needyDTO)
        {
            Dal.Needy needy = new Dal.Needy();
            if (needyDTO.ExpireDate != null)

                needy.ExpireDate = needyDTO.ExpireDate;
            else needy.ExpireDate = null;
            if (needyDTO.NeedyDescribe != null)
                needy.NeedyDescribe = needyDTO.NeedyDescribe;
         else   needy.NeedyDescribe = "";
            if (needyDTO.AmountToHelp != null)
                needy.AmountToHelp = needyDTO.AmountToHelp;
            else needy.AmountToHelp = null;
            if (needyDTO.QuantityUsed != null)
                needy.QuantityUsed = needyDTO.QuantityUsed;
            else needy.QuantityUsed = null;
            needy.Needy_Kod = needyDTO.Needy_Kod;
            needy.Number_Of_Persons = needyDTO.Number_Of_Persons;
            needy.User = UserConverters.GetUser(needyDTO.User);

            return needy;
        }
      public static NeedyDTO GetNeedyDTO(Needy needy)
        {
            NeedyDTO needyDTO = new NeedyDTO();
            if (needy.ExpireDate != null)
                needyDTO.ExpireDate = needy.ExpireDate;
            else needyDTO.ExpireDate = null;
            if (needy.NeedyDescribe != null)
                needyDTO.NeedyDescribe = needy.NeedyDescribe;
            else needyDTO.NeedyDescribe = "";
            if (needy.AmountToHelp != null)
                needyDTO.AmountToHelp = needy.AmountToHelp;
            else needyDTO.AmountToHelp = null;
            if (needy.QuantityUsed != null)
                needyDTO.QuantityUsed = needy.QuantityUsed;
            else needyDTO.QuantityUsed = null;
            needyDTO.Needy_Kod = needy.Needy_Kod;
            needyDTO.Number_Of_Persons = needy.Number_Of_Persons;
            needyDTO.User = UserConverters.userDTO(needy.User);
     ;
            return needyDTO;
        }
        public static List<Dal.Needy> GetListNeedy(List<DTO.NeedyDTO> ls)
        {
            List<Dal.Needy> dl = new List<Dal.Needy>();
            foreach (var item in ls)

            {
                dl.Add(GetNeedy(item));

            }
            return dl;

        }
        public static List<DTO.NeedyDTO> GetListNeedyDTO(List<Dal.Needy> ls)
        {
            List<DTO.NeedyDTO> dl = new List<DTO.NeedyDTO>();
            foreach (var item in ls)
            {
                dl.Add(GetNeedyDTO(item));
            }
            return dl;
        }
    }
}
