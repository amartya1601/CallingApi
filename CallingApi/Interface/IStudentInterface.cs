using CallingApi.Request;
using CallingApi.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallingApi.Interface
{
  public  interface IStudentInterface
    {
        public Task<IEnumerable<StudentDetailsResponse>> AddStudent(StudentDetailsRequest request);
    }
}
