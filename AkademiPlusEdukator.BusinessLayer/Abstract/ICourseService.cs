﻿using AkademiPlusEdukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusEdukator.BusinessLayer.Abstract
{
    public interface ICourseService : IGenericService<Course>
    {
        List<Course> TGetCoursesWithCategories();
    }
}
