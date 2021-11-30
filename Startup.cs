namespace CRUD_NESS_ALAN.Models
{
    public class Startup
    {
        private readonly object routes;
        private object option;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public IConfiguration Configuration { get; }

        // This method gets called bythe runtime. Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext(option.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))


            ,services.AddMvc());
        }

        // This method gets called bythe runtime. Use this method to add services to the container
        [Obsolete]
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                object p = UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                ;
            })
            ;
            {
                 routes.MapRoute(
                    name: "default",
                    template: "{controller=Personagens}/{action=Index}/{Id?}");
            } ;
                                 
        }

        private object UseBrowserLink()
        {
            throw new NotImplementedException();
        }
    }
}