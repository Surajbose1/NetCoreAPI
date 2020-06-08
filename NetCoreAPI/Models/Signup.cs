namespace NetCoreAPI.Models
{
    public class Signup
    {
        public string client_id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string connection { get; set; }
    }

    public class SignupResponseModel
    {
        public string _id { get; set; }
        public string email { get; set; }
        public bool email_verified { get; set; }
    }

    public class TokenInput
    {
        public string grant_type { get; set; }
        public string client_id { get; set; }
        public string audience { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string client_secret { get; set; }
    }

    public class TokenInputResponseModel
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public string token_type { get; set; }
    }
}
