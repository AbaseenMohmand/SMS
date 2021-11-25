using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SchoolManagementSystem2.Models;
using SchoolManagementSystem2.Repository;
using SchoolManagementSystem2.Repository.Attendances;
using SchoolManagementSystem2.Repository.Class;
using SchoolManagementSystem2.Repository.Employees;
using SchoolManagementSystem2.Repository.EmployeeTypes;
using SchoolManagementSystem2.Repository.Fees;
using SchoolManagementSystem2.Repository.Months;
using SchoolManagementSystem2.Repository.Registrations;
using SchoolManagementSystem2.Repository.Salleries;
using SchoolManagementSystem2.Repository.Sections;
using SchoolManagementSystem2.Repository.Students;
using SchoolManagementSystem2.Repository.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2
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
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                .RequireAuthenticatedUser()
                                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            }).AddXmlSerializerFormatters();

            services.AddTransient<IAttendanceRep, AttendanceRep>();
            services.AddTransient<IStudentRep, StudentRep>();
            services.AddTransient<IClassRep, ClassRep>();
            services.AddTransient<IEmployeeRep,EmployeeRep>();
            services.AddTransient<IEmployeeTypesRep, EmployeeTypesRep>();
            services.AddTransient<IFeesRep, FeesRep>();
            services.AddTransient<ISalleryRep, SalleryRep>();
            services.AddTransient<IMonthRep, MonthRep>();
            services.AddTransient<ISectionRep, SectionRep>();
            services.AddTransient<IRegistrationRep, RegistrationRep>();
            services.AddTransient<ITeacherRep, TeacherRep>();


            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<StudentDbContext>();
            services.AddDbContext<StudentDbContext>(option=>option.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
