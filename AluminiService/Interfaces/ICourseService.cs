﻿using Alumini.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluminiService.Interfaces
{
    public interface ICourseService : GenericCRUDService<Courses>
    {

        IEnumerable<Cours> GetAllCoursesByCategoryId(int id);
    }
}
