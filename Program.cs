using System;
using System.Reflection;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            var CurrentDirectory = Path.Combine(Environment.CurrentDirectory,"..","..","..","test_groupBy.csv");
            var reader = new StreamReader(File.OpenRead(CurrentDirectory));
            List<Role> roles = new List<Role>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                Role role = new Role();
                role.RoleSn = values[0];
                role.RoleName = values[1];
                roles.Add(role);
               
            }
            // group by roleSn, roleName
            // order by roleSn

            Console.WriteLine("end");
        }
    }
    public class Role
    {
        public string? RoleSn { get; set; }
        public string? RoleName { get; set; }
    }
}
