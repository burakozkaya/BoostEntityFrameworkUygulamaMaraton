using System.Security.Cryptography;
using System.Text;

namespace BoostEntityFrameworkUygulamaMaraton.BLL.Validation_Rules;

public class Sifreleme
{
    public string sha256_hash(string sifre) 
    { using (SHA256 hash = SHA256Managed.Create()) { return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2"))); } }
}