using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using dotnetcoreapirest.Model;
using dotnetcoreapirest.Repository;
using dotnetcoreapirest.Security.Configuration;

namespace dotnetcoreapirest.Business.Implementations
{
	public class LoginBusinessImpl : ILoginBusiness
	{
		private ILoginRepository _repository;
		private SigningConfiguration _signingConfiguration;
		private TokenConfiguration _tokenConfiguration;
        
        /// <summary>
        /// Initializes a new instance of the
        /// </summary>
        /// <param name="repository">Repository.</param>
        /// <param name="signingConfigurations">Signing configurations.</param>
        /// <param name="tokenConfiguration">Token configuration.</param>
		public LoginBusinessImpl(ILoginRepository repository, SigningConfiguration signingConfigurations, TokenConfiguration tokenConfiguration)
		{
			_repository = repository;
			_signingConfiguration = signingConfigurations;
			_tokenConfiguration = tokenConfiguration;
		}
       
        /// <summary>
        /// Finds the by login.
        /// </summary>
        /// <returns>The by login.</returns>
        /// <param name="login">Login.</param>
		public object FindByLogin(Login login)
		{
			bool credentialsIsValid = false;
			if (login != null && !string.IsNullOrWhiteSpace(login.LoginUser))
            {
				var baseUser = _repository.FindByLogin(login.LoginUser);
				credentialsIsValid = (baseUser != null && login.LoginUser == baseUser.LoginUser && login.AccessKey == baseUser.AccessKey);
            }

			if (credentialsIsValid)
            {
                ClaimsIdentity identity = new ClaimsIdentity(
					new GenericIdentity(login.LoginUser, "LoginUser"),
                        new[]
                        {
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
					        new Claim(JwtRegisteredClaimNames.UniqueName, login.LoginUser)
                        }
                    );

                DateTime createDate = DateTime.Now;
                DateTime expirationDate = createDate + TimeSpan.FromSeconds(_tokenConfiguration.Seconds);

                var handler = new JwtSecurityTokenHandler();
                string token = CreateToken(identity, createDate, expirationDate, handler);

                return SuccessObject(createDate, expirationDate, token);
            }
            else
            {
                return ExceptionObject();
            }
		}

        /// <summary>
        /// Creates the token.
        /// </summary>
        /// <returns>The token.</returns>
        /// <param name="identity">Identity.</param>
        /// <param name="createDate">Create date.</param>
        /// <param name="expirationDate">Expiration date.</param>
        /// <param name="handler">Handler.</param>
		private string CreateToken(ClaimsIdentity identity, DateTime createDate, DateTime expirationDate, JwtSecurityTokenHandler handler)
		{
			var securityToken = handler.CreateToken(new Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor
            {
                Issuer = _tokenConfiguration.Issuer,
                Audience = _tokenConfiguration.Audience,
                SigningCredentials = _signingConfiguration.SigningCredentials,
                Subject = identity,
                NotBefore = createDate,
                Expires = expirationDate
            });

            var token = handler.WriteToken(securityToken);
            return token;
		}

		/// <summary>
		/// Exceptions the object.
		/// </summary>
		/// <returns>The object.</returns>
		private object ExceptionObject()
		{
			return new
            {
                autenticated = false,
                message = "Failed to autheticate"
            };
		}

        /// <summary>
        /// Successes the object.
        /// </summary>
        /// <returns>The object.</returns>
        /// <param name="createDate">Create date.</param>
        /// <param name="expirationDate">Expiration date.</param>
        /// <param name="token">Token.</param>
		private object SuccessObject(DateTime createDate, DateTime expirationDate, string token)
		{
			return new
            {
                autenticated = true,
                created = createDate.ToString("yyyy-MM-dd HH:mm:ss"),
                expiration = expirationDate.ToString("yyyy-MM-dd HH:mm:ss"),
                accessToken = token,
                message = "OK"
            };
		}
	}
}
