using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Models;
using Newtonsoft.Json;// library to serialize and deserialize

namespace ConsumeRestApi
{
    class Program
    {
        static async Task<IEnumerable<User>> get()
        {
            HttpClient client = new HttpClient();
           // client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/users");
            var response = await client.GetAsync("https://jsonplaceholder.typicode.com/users");
            var result = await response.Content.ReadAsStringAsync();
            var users= JsonConvert.DeserializeObject<IEnumerable<User>>(result);
            return users;
        }
        static void Main(string[] args)
        {
            var users = get();
            foreach (var user in users.Result)
            {
                Console.WriteLine($"{user.id} {user.username}  {user.phone}");
            }
            
            Console.Read();
        }
    }
}
