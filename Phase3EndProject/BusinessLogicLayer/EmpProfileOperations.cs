using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class EmpProfileOperations
    {

        EmpProfileRepository empProfileRepository = new EmpProfileRepository(new EmsContext());

        public void insertEmpProfile(EmpProfile empProfile)
        {
            empProfileRepository.Insert(empProfile);
        }
        public List<EmpProfile> ListOfEmployee()
        {
            return empProfileRepository.GetAll().ToList();

        }
        public void deleteEmpProfile(int EmpCode)
        {
            empProfileRepository.Delete(EmpCode);
            
        }
        public void updateEmpProfile(EmpProfile empProfile)
        {
            empProfileRepository.Update(empProfile);
        }
    }
}
