using Blazor_Client_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Blazor_Client_App.Services
{
    public class UserService : IUserService
    {

        private readonly HttpClient httpClient;

        public UserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<UserData> GetUserData()
        {
            return await httpClient.GetJsonAsync<UserData>("api/users/2");
        }

        public async Task<UserDataList> GetUserList()
        {
            return await httpClient.GetJsonAsync<UserDataList>("api/users");
        }
    }
}
