using CallingApi.AppSettings;
using CallingApi.Extensions;
using CallingApi.Interface;
using CallingApi.Request;
using CallingApi.Response;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CallingApi.Services
{
    public class StudentService : IStudentInterface
    {
        private readonly HttpClient _httpClient;
        private readonly IOptions<AppSetting> _appSetting;


        public StudentService(HttpClient httpClient, IOptions<AppSetting> appSetting)
        {
            _httpClient = httpClient;
            _appSetting = appSetting;
        }

        public async Task<IEnumerable<StudentDetailsResponse>> AddStudent(StudentDetailsRequest request)
        {
            
            string result = string.Empty;
            StudentDetailsResponse sDResponse = new StudentDetailsResponse();

           // StudentDetailsRequest sDRequest = new StudentDetailsRequest();


            var stringContent = StringContentExtension.CreateJasonContent(request);

            var Request = new HttpRequestMessage{

               Method=HttpMethod.Post,
               RequestUri=new Uri(_appSetting.Value.studentDetails.ToString()),
               Content= stringContent
            };

            var response = await _httpClient.SendAsync(Request);
            IEnumerable<StudentDetailsResponse> res;
            if(response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
                res= JsonConvert.DeserializeObject<IEnumerable<StudentDetailsResponse>>(result);
                

            }
            else
            {
                return null;
            }
            return res;
            

        }
    }
}
