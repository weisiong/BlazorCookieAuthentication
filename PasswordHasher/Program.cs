using Microsoft.AspNetCore.Identity;
using System;

namespace AuthenticationIdentitySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var passwordHasher = new PasswordHasher<string>();
            Console.WriteLine(passwordHasher.HashPassword(null, "123456"));
            Console.ReadLine();
        }
    }
}
