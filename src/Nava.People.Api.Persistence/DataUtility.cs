
using Microsoft.Extensions.Hosting.Internal;
using Nava.People.Api.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nava.People.Api.Persistence
{
    class DataUtility
    {
        private static string _peopleJsonFilePath;

        public DataUtility(string peopleJsonFilePath)
        {
            _peopleJsonFilePath = peopleJsonFilePath;
        }

        public async Task<List<Person>> LoadPeopleDataFromJsonFileAsync()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), _peopleJsonFilePath);

            if (File.Exists(_peopleJsonFilePath))
            {

                
                using (StreamReader reader = File.OpenText(_peopleJsonFilePath))
                {
                    string json = await reader.ReadToEndAsync();
                    List<Person> people = JsonConvert.DeserializeObject<List<Person>>(json);
                    return people;
                }
            }
            else
            {
                Console.WriteLine($"File {_peopleJsonFilePath} not found.");
                return new List<Person>();
            }
        }
    }
}
