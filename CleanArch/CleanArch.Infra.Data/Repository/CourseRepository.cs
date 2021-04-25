using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext universityDBContext;

        public CourseRepository(UniversityDBContext universityDBContext)
        {
            this.universityDBContext = universityDBContext;
        }
        public IEnumerable<Course> GetCourses()
        {
            return universityDBContext.Courses;
        }
    }
}
