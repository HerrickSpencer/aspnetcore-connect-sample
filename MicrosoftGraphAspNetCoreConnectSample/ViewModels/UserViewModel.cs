using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosoftGraphAspNetCoreConnectSample.ViewModels
{
    public class UserViewModel
    {
        public User User { get; set; }
        public string Picture { get; set; }
        public UserViewModel(User user, string picture)
        {
            User = user;
            Picture = picture;
        }
    }
}
