//using System;
//using System.IO;
//using Microsoft.Extensions.Configuration;
//using Microsoft.EntityFrameworkCore.Design;
//using EFGetStarted.AspNetCore.NewDb.Models;
//using Microsoft.EntityFrameworkCore;

//namespace EFGetStarted.AspNetCore.NewDb
//{
//    public class TutorialDBFactory : IDesignTimeDbContextFactory<BloggingContext>
//    {
       
//        public TutorialDBFactory CreateDbContext(string[] args)
//        {
//            string appSettingsPath = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;

//            Console.WriteLine(appSettingsPath);
//            IConfigurationRoot configuration = new ConfigurationBuilder()
//                .SetBasePath(appSettingsPath)
//                .AddJsonFile("appsettings.Development.json", true)
//                .Build();
//            //var connectionString = configuration.GetConnectionString("TutorialDBConnection");
//            var connectionString = @"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";
//            // If argument is passed in, assume the first argument points to the location of appsettings
//            if (args.Length > 0)
//            {
//                connectionString = args[0];
//            }
//            var builder = new DbContextOptionsBuilder<BloggingContext>();
//            builder.UseSqlServer(connectionString);
//            return new BloggingContext(builder.Options);
//        }
//    }
//}
