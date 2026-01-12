namespace HOA.Application.Interfaces.Graph
{
    public interface IGraphAuthService
    {
        Task<string> GetAccessTokenAsync();
    }
}
