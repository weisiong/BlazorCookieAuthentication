﻿using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorLogin.Utilities
{
    //public class CustomAuthStateProvider : AuthenticationStateProvider
    //{
    //    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    //    {
    //        var identity = new ClaimsIdentity(new[]
    //        {
    //            new Claim(ClaimTypes.Email, "admin@gmail.com"),
    //        }, "Fake authentication type");

    //        var user = new ClaimsPrincipal(identity);

    //        return Task.FromResult(new AuthenticationState(user));
    //    }
    //}
}
