using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Foxik_Assistant.Entities
{
    public class User
    {

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }

        public override string ToString()
        {
            return $"Name {Name}, Email {Email}, Password {Password}";
        }
    }
}
