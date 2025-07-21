using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business.Utilities.Security.Jwt
{
    public class TokenOptions
    {
        public string Audience { get; set; } //token kullanıcı listesini tutar
        public string Issuer { get; set; } //token imzalayan
        public int AcccessTokenExpiration { get; set; } //Dakika cinsinden süre verir
        public string SecurityKey { get; set; } //Güvenlik anahtarı 
    }
}
