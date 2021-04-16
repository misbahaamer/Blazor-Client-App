using Blazor_Client_App.Models;
using Blazor_Client_App.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Client_App.Pages.Users
{
    public partial class UserList : ComponentBase
    {
        [Inject]
        public IUserService UserService { get; set; }

        public UserData User { get; set; }
        public UserDataList userDataList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //User = await UserService.GetUserData();
            userDataList = await UserService.GetUserList();
        }
    }
}
