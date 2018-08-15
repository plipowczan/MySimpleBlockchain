#region usings

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

#endregion

namespace MySimpleBlockchainApp
{
    public class Helper
    {
        #region Private methods

        private static byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        #endregion

        #region Public methods

        public static string GetSha256Hash(object obj)
        {
            var sha256 = new SHA256Managed();
            var hashBuilder = new StringBuilder();

            // zamiana obiektu na tablicę bajtów
            byte[] bytes = ObjectToByteArray(obj);
            // obliczanie hash-a
            byte[] hash = sha256.ComputeHash(bytes);

            // konwersja tablicy bajtów na łańcuch znaków hexadecymalnych
            foreach (byte x in hash)
                hashBuilder.Append($"{x:x2}");

            return hashBuilder.ToString();
        }

        #endregion
    }
}