
using MRIdentityClient.Node;
using MRIdentityClient.Tools;

namespace MRIdentityClient
{
    public class IdentityClient
    {
        public readonly Navigator Navigator = new Navigator();
        public readonly string Secret;

        public SignupNode Signup { get; set; }

        protected IdentityClient()
        {
            Signup = new SignupNode(this);
        }

        public IdentityClient(string secret) : this()
        {
            Secret = secret;
        }
    }
}
