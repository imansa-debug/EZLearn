using EzLearn.DataLayer.Entities.Course;
using System;
using System.Collections.Generic;
using System.Text;

namespace EzLearn.Core.Services.Interfaces
{
   public interface ICourseService
    {
        #region Group
        List<CourseGroup> GetAllGroup();
        #endregion
    }
}
