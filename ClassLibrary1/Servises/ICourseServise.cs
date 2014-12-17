using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Servises
{
    public interface ICourseServise
    {
        void addNewCourse(Course c);
        void validate(Course c);
    }
}
