using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Foxik_Assistant.Entities
{
    public class Users
    {
        public Users(List<User> usersList)
        {
            UsersList = usersList;
        }

        [JsonPropertyName("users")]
        public List<User> UsersList {  get; set; }
        
    }
}
