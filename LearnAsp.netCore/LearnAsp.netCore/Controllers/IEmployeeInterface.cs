using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnAsp.netCore.Controllers
{
   public interface IEmployeeInterface
    {
         Employee GetEmployee(int id);
    }
}
