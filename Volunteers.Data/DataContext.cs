using System.Globalization;
using Volunteers.Core.entities;
using CsvHelper;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace Volunteers.Data
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=volunteers_db;Trusted_Connection=True");
        }
        public DbSet<OrgEntity> Orgs { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ActivityEntity> Activities { get; set; }
        public DbSet<VolunteerInActivityEntity> VolunteerInActivities { get; set; }
        //private readonly string _directory;
        //private readonly string _orgsPath;
        //private readonly string _usersPath;
        //private readonly string _activityPath;
        //private readonly string _volunteerInActivityPath;
        //public DataContext()
        //{

        //    ///load data in file 
        //    _directory = @"E:\dotNetCore\Volunteers.Api\Volunteers.Data\csv files\";

        //    _orgsPath = Path.Combine(_directory, "orgs.csv");
        //    _usersPath = Path.Combine(_directory, "users.csv");
        //    _activityPath = Path.Combine(_directory, "activities.csv");
        //    _volunteerInActivityPath = Path.Combine(_directory, "volunteerInActivities.csv");

        //    using (var orgs_reader = new StreamReader(_orgsPath))
        //    using (var orgs_csv = new CsvReader(orgs_reader, CultureInfo.InvariantCulture))
        //    {
        //        Orgs = orgs_csv.GetRecords<OrgEntity>().ToList();
        //    }
        //    using (var users_reader = new StreamReader(_usersPath))
        //    using (var users_csv = new CsvReader(users_reader, CultureInfo.InvariantCulture))
        //    {
        //        Users = users_csv.GetRecords<UserEntity>().ToList();
        //    }
        //    using (var activities_reader = new StreamReader(_activityPath))
        //    using (var activities_csv = new CsvReader(activities_reader, CultureInfo.InvariantCulture))
        //    {
        //        Activities = activities_csv.GetRecords<ActivityEntity>().ToList();
        //    }
        //    using (var VolunteerInActivity_reader = new StreamReader(_volunteerInActivityPath))
        //    using (var VolunteerInActivity_csv = new CsvReader(VolunteerInActivity_reader, CultureInfo.InvariantCulture))
        //    {
        //        VolunteerInActivities = VolunteerInActivity_csv.GetRecords<VolunteerInActivityEntity>().ToList();
        //    }

        //}


        public bool saveData()
        {
            //TOOD:add code save in file 
            //using (var orgs_writer = new StreamWriter(_orgsPath))
            //using (var orgs_csv = new CsvWriter(orgs_writer, CultureInfo.InvariantCulture))
            //{
            //    orgs_csv.WriteRecords(Orgs);
            //}
            //using (var users_writer = new StreamWriter(_usersPath))
            //using (var users_csv = new CsvWriter(users_writer, CultureInfo.InvariantCulture))
            //{
            //    users_csv.WriteRecords(Users);
            //}
            //using (var activities_writer = new StreamWriter(_activityPath))
            //using (var activities_csv = new CsvWriter(activities_writer, CultureInfo.InvariantCulture))
            //{
            //    activities_csv.WriteRecords(Activities);
            //}
            //using (var volunteerInActivity_writer = new StreamWriter(_volunteerInActivityPath))
            //using (var volunteerInActivity_csv = new CsvWriter(volunteerInActivity_writer, CultureInfo.InvariantCulture))
            //{
            //    volunteerInActivity_csv.WriteRecords(VolunteerInActivities);
            //}
            return true;

        }
        
    }
}