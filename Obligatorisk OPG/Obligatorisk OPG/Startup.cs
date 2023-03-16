﻿using Obligatorisk_OPG.Services.Interfaces;
using Obligatorisk_OPG.Services.TabelServices;
using Obligatorisk_OPG.Services.TabelServices.DormitroyS;
using Obligatorisk_OPG.Services.TabelServices.LeasingS;
using Obligatorisk_OPG.Services.TabelServices.RoomS;
using Obligatorisk_OPG.Services.TabelServices.StudentS;

namespace Obligatorisk_OPG
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
            services.AddRazorPages();

            services.AddTransient<IDormitoryService, DormitoryService>();
            services.AddTransient<IRoomService, RoomService>();
            services.AddTransient<IStudentService, ADOStudentService>();
            services.AddTransient<ILeasingServiceM, LeasingServiceM>();
            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}