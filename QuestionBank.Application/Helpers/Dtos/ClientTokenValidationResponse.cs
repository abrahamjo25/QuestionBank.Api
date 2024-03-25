using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank.Application.Helpers.Dtos
{
    public class ClientTokenValidationResponse
    {
        public string ClientId { get; set; } = string.Empty;
        public bool RequireIdToken { get; set; } = true;
    }
}
