using JWT;
using JWT.Algorithms;
using JWT.Builder;
using JWT.Exceptions;
using JWT.Serializers;
using System;

namespace UserManagementMicroservice
{
    public class JWT
    {
        public static string CreateJWT(int userId, int time)
        {
            var token = new JwtBuilder()
                           .WithAlgorithm(new HMACSHA256Algorithm())
                           .WithSecret("GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk")
                           .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(time).ToUnixTimeSeconds())
                           .AddClaim("userId", userId)
                           .Encode();
            return token;
        }

        public static string CheckJWT(string jwtToken)
        {
            string json;
            try
            {
                IJsonSerializer serializer = new JsonNetSerializer();
                var provider = new UtcDateTimeProvider();
                IJwtValidator validator = new JwtValidator(serializer, provider);
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                IJwtAlgorithm algorithm = new HMACSHA256Algorithm(); // symmetric
                IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder, algorithm);

                json = decoder.Decode(jwtToken, "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk", verify: true);
            }
            catch (TokenExpiredException)
            {
                return "Token has expired";
            }
            catch (SignatureVerificationException)
            {
                return "Token has invalid signature";
            }
            return json;
        }
    }
}
