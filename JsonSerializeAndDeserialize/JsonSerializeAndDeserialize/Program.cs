using System.Text.Json;

namespace JsonSerializeAndDeserialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //JSON Serialize
            Developer developer = new Developer();
            developer.Name = "Sirac";
            developer.Surname = "Huseynov";
            developer.Age = 19;
            developer.Salary = 15000;
            developer.DevelopmentSkills = ".NET";
            developer.Experience = 10;
            DeveloperToJson(developer);

            //JSON Deserialize
            Console.WriteLine(JsonToDeveloper());
        }

        public static void DeveloperToJson(Developer developer)
        {
            string path = "C:\\Users\\Sirac Huseynov\\Desktop\\data.json";

            using Stream stream = new FileStream(path, FileMode.Create);

            JsonSerializer.Serialize(stream, developer);
        }

        public static Developer JsonToDeveloper()
        {
            string path = "C:\\Users\\Sirac Huseynov\\Desktop\\data.json";

            using Stream stream = new FileStream(path, FileMode.Open);

            return JsonSerializer.Deserialize<Developer>(stream);
        }
    }
}
