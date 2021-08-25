﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PremierTest.Application.Services
{
    public static class CriptoService
    {
        public static string GenerateHash(string pw)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(pw));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
