using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetcoreapirest.Business;
using dotnetcoreapirest.Business.Implementations;
using dotnetcoreapirest.Model.Context;
using dotnetcoreapirest.Repository;
using dotnetcoreapirest.Repository.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using Swashbuckle.AspNetCore.Swagger;

namespace dotnet_core_api_rest
{
    public class Startup
    {
		private readonly ILogger _logger;

        public IConfiguration _configuration { get; }

		public IHostingEnvironment _environment { get; }

		public Startup(IConfiguration configuration, IHostingEnvironment environment, ILogger<Startup> logger)
        {
			_configuration = configuration;
			_environment = environment;
			_logger = logger;
        }
  

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
			var connectionString = _configuration["MySqlConnetion:MySqlConnectionString"];
			services.AddDbContext<MySQLContext>(options => options.UseMySql(connectionString));
                 
            // Compatibilty dotnet 2.1
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            /// Include JSON and XML Formatter
			services.AddMvc(options =>
			{
				options.RespectBrowserAcceptHeader = true;
				options.FormatterMappings.SetMediaTypeMappingForFormat("xml", MediaTypeHeaderValue.Parse("text/xml"));
				options.FormatterMappings.SetMediaTypeMappingForFormat("json", MediaTypeHeaderValue.Parse("application/json"));
			}).AddXmlSerializerFormatters();

			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new Info 
				{ 
					Title = "RESTFul API with ASP.NET Core 2.1 ", 
					Version = "V1" 
				});
			});

            // Dependency Injection
			services.AddScoped<IPersonBusiness, PersonBusinessImpl>();
			services.AddScoped<IBookBusiness,BookBusinessImpl>();

			services.AddScoped(typeof (IRepository<>), typeof (GenericRepository<>));

            // Versioning API 
			services.AddApiVersioning(option => option.ReportApiVersions = true);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

			app.UseSwagger();

			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1");
			});

			var option = new RewriteOptions();
			option.AddRedirect("^$", "swagger");
			app.UseRewriter(option);

            app.UseHttpsRedirection();
            app.UseMvc();

        }
    }
}
