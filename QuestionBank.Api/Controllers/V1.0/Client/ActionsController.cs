using QuestionBank.Api.Contracts.Client.Request;
using QuestionBank.Application.Commands.ApiClaims;
using Microsoft.AspNetCore.Authorization;
using System.Reflection;

namespace QuestionBank.Api.Controllers.V1._0.Client
{

    public class ActionsController : BaseController
    {
        [AllowAnonymous]
        [HttpPost(nameof(IdentityClaimSeeder))]
        public async Task<IActionResult> IdentityClaimSeeder()
        {

            Assembly asm = Assembly.GetExecutingAssembly();

            var controlleractionlist = asm.GetTypes()
                    .Where(type => typeof(ControllerBase).IsAssignableFrom(type))
                    .SelectMany(type => type.GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public))
                    .Where(m => !m.GetCustomAttributes(typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute), true).Any())
                    .Select(x => new { Controller = x.DeclaringType.Name, Action = x.Name, ReturnType = x.ReturnType.Name, Attributes = String.Join(",", x.GetCustomAttributes().Select(a => a.GetType().Name.Replace("Attribute", ""))) })
                    .OrderBy(x => x.Controller).ThenBy(x => x.Action).ToList();
            Claimrequest claimrequest = new Claimrequest() { requiredIdToken = true, serviceId = 1, claim = new List<string>() };

            foreach (var controlleraction in controlleractionlist)
            {
                claimrequest.claim.Add(controlleraction.Controller.Replace("Controller", "") + "-" + controlleraction.Action);
            }

            string accessToken = HttpContext.Session.GetString("accessToken");

            var result = await _mediator.Send(new CreateApiClaim { Claim = claimrequest.claim, ServiceId = 1, RequireIdToken = true });


            if (!result.IsError)
            {
                return Ok(result.Message = "Seeded Claims Successfully");
            }
            else
            {
                Ok(result.Errors);
            }
            return null;
        }
    




    }

  


}
