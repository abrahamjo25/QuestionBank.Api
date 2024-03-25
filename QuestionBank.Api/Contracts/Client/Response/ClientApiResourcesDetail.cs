namespace QuestionBank.Api.Contracts.Client.Response
{
    public class ClientApiResourcesDetail
    {
        public long ClientId { get; set; }
        public long ApiClaimId { get; set; }
        public List<ApiDetail> ApiClaims { get; set; }
    }
    public class ApiDetail
    {
        public ApiClaimDetail ApiClaim { get; set; }

    }
}
