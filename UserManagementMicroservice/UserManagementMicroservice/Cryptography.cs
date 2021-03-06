﻿
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using UserManagementMicroservice.Entities;

namespace UserManagementMicroservice
{
    public class Cryptography
    {
        static readonly byte[] salt = { 0x91, 0x61, 0x7a, 0xcc, 0x98, 0xa3, 0x87, 0x40, 0x09, 0x6d, 0x51, 0xb0, 0xdb, 0x3b, 0x4e, 0x21 };
        public static User HashUserData(User user)
        {
            User userHashed = new User();
            userHashed.UserName = user.UserName;
            userHashed.Password = HashString(user.Password);
            userHashed.Email = HashString(user.Email);
            userHashed.Administrator = user.Administrator;
            return userHashed;
        }

        public static string HashString(string plaintext)
        {
            
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
           password: plaintext,
           salt: salt,
           prf: KeyDerivationPrf.HMACSHA1,
           iterationCount: 10000,
           numBytesRequested: 256 / 8));
            return hashed;
        }
    }
}
