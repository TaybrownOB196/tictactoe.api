using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using tictactoe.api.dataaccess;
using tictactoe.api.dataaccess.providers;
using tictactoe.api.dataaccess.models;

namespace tictactoe.api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TictactoeDbContext>(opt => opt.UseInMemoryDatabase("TicTacToe"));
            services.AddCors(options => {
                options.AddPolicy("policy_one", 
                builder => {
                    builder
                        .WithOrigins("http://localhost:8989")
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddTransient(typeof(IEntityProvider<GameResult>), typeof(GameResultsProvider));
            services.AddTransient(typeof(IEntityProvider<GameSession>), typeof(GameSessionsProvider));
            services.AddTransient(typeof(IEntityProvider<Player>), typeof(PlayersProvider));
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
                app.UseHttpsRedirection();
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //HTTP Strict Transport Security
                app.UseHsts();
            }

            app.UseCors("policy_one");
            app.UseMvc();
        }
    }
}
