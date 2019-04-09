namespace MRIdentityClient.Tools
{
    public sealed class Navigator
    {
        private readonly string _fingerprint;

        public Navigator(string fingerprint)
        {
            _fingerprint = fingerprint;
        }

        const string BASE = "http://identity.madrat.studio";
        public string ApproveLogin(string token) => $"{BASE}/login/provider/approve?token={token}&fingerprint={_fingerprint}";
    }
}
