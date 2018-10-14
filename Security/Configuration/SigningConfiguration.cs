using System;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;

namespace dotnetcoreapirest.Security.Configuration
{
    public class SigningConfiguration
    {
		public SecurityKey Key { get; }
		public SigningCredentials SigningCredentials { get; }

        /// <summary>
        /// Initializes a new instance of the
        /// </summary>
		public SigningConfiguration()
		{
			using(var provider = new RSACryptoServiceProvider(2048))
			{
				Key = new RsaSecurityKey(provider.ExportParameters(true));
			}

			SigningCredentials = new SigningCredentials(Key, SecurityAlgorithms.RsaSha256Signature);
		}
    }
}
