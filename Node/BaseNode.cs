using MRIdentityClient.Tools;

namespace MRIdentityClient.Node
{
    public abstract class BaseNode
    {
        protected readonly IdentityClient _client;
        protected Navigator _navigator => _client?.Navigator;

        public BaseNode(IdentityClient client)
        {
            _client = client;
        }
    }
}
