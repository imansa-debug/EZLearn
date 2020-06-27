using EzLearn.Core.Services.Interfaces;
using EzLearn.DataLayer.Context;
using EzLearn.DataLayer.Entities.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EzLearn.Core.Services
{
    public class CourseService: ICourseService
    {
        private EzLearnContext _context;
        public CourseService(EzLearnContext context)
        {
            _context = context;
        }
        public List<CourseGroup> GetAllGroup()
        {
            return _context.CourseGroups.ToList();
        }
    }
}
