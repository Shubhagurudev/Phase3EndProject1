using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BusinessLogicLayer;
using DataAccessLayer;
using Phase3endProject1App.Models;

namespace Phase3endProject1App.Controllers
{
    public class EmpProfileApiController : ApiController
    {
        EmpProfileOperations profileOperations = new EmpProfileOperations();

        public void Post(EmpProfileModel empModel)
        {
            EmpProfile emp = new EmpProfile();
            emp.EmpCode = empModel.EmpCode;
            emp.DateOfBirth = empModel.DateOfBirth;
            emp.EmpName = empModel.EmpName;
            emp.Email = empModel.Email;
            emp.DeptCode = empModel.DeptCode; 
            profileOperations.insertEmpProfile(emp);
        }
       public void Delete(int id)
        {
            List<EmpProfileModel> empList = new List<EmpProfileModel>();
            empList.delete(e => e.EmpCode == id);
        }

        public void put(EmpProfileModel empModel)
        {
            EmpProfile emp = new EmpProfile();
            emp.EmpCode = empModel.EmpCode;
            emp.DateOfBirth = empModel.DateOfBirth;
            emp.EmpName = empModel.EmpName;
            emp.Email = empModel.Email;
            emp.DeptCode = empModel.DeptCode;
            profileOperations.insertEmpProfile(emp);
        }
        public List<EmpProfileModel> GetAll()
        {
            List<EmpProfile> list = profileOperations.ListOfEmployee();
            List<EmpProfileModel> empList = new List<EmpProfileModel>();
            foreach (EmpProfile empModel in list)
            {
                EmpProfileModel emp = new EmpProfileModel();
                emp.EmpCode = empModel.EmpCode;
                emp.DateOfBirth = empModel.DateOfBirth;
                emp.EmpName = empModel.EmpName;
                emp.Email = empModel.Email;
                emp.DeptCode = empModel.DeptCode;
                empList.Add(emp);
            }
            return empList;
        }


    }
}
