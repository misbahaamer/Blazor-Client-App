using Blazor_Client_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Client_App.Services
{
    public interface IUserService
    {
        Task<UserData> GetUserData();
        Task <UserDataList> GetUserList();
    }
}
