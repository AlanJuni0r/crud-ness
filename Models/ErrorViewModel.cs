namespace CRUD_NESS_ALAN.Models
{
    public class Startup : IStartup1
    {
        public Startup(object routes, object option, IConfiguration configuration, string? requestId)
        {
            this.routes = routes;
            this.option = option;
            Configuration = configuration;
            RequestId = requestId;
        }

        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}