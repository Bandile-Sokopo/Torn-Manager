namespace API
{
    public interface ISelector
    {
        int IdSelect();
        string EndpointSelect();
        string ApiKeySelect();
        HttpClient Client();
    }
}
