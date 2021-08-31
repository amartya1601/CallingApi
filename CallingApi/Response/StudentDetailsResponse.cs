using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CallingApi.Response
{
    public class StudentDetailsResponse
    {
        [JsonPropertyName("studId")]
        public int StudId { get; set; }


        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }
    }
}
