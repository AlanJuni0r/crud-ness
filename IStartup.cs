
namespace CRUD_NESS_ALAN.Models
{
    public interface IStartup
    {
        IConfiguration Configuration { get; }
        string? RequestId { get; set; }
        bool ShowRequestId { get; }

        void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env);
        void ConfigureServices(IServiceCollection services);
    }
}