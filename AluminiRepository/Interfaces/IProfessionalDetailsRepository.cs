﻿using Alumini.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluminiRepository.Interfaces
{
    public interface IProfessionalDetailsRepository : GenericCRUDRepository<ProfessionalDetail>
    {
        ProfessionalDetail UpdateUserProfDetails(int id, ProfessionalDetail Prof);
        List<Companys> GetAllCompanys(int id);
        List<View_UserDetails> GetUserDetails(string Name,int id);
        IEnumerable<Companys> GetCompanyDetailsforAutosearch(string Auto, string Designation);
        List<View_UserDetails> GetUserDetailsonSearchbased(string Name, int id, string Designation);
    }
}