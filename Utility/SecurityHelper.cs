using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace JobMonitor.Utility
{
	public static class SecurityHelper
	{
		static string encryptKey = "PjkYmkd4L6OrcOFmSX8H+g==";

		/// <summary>
		/// Encrypts the specified original string.
		/// </summary>
		/// <param name="plainText">The plain string.</param>
		/// <param name="key">The secret key to use for the symmetric algorithm.</param>
		/// <returns></returns>
		/// <exception cref="System.ArgumentNullException">The string which needs to be encrypted can not be null.</exception>
		public static string Encrypt(string plainText) {
			if ( String.IsNullOrEmpty(plainText) ) {
				return plainText;
			}
			var rgbKey = Encoding.ASCII.GetBytes(encryptKey);
			var rgbIV = Encoding.ASCII.GetBytes(encryptKey);
			DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream,
				cryptoProvider.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
			StreamWriter writer = new StreamWriter(cryptoStream);
			writer.Write(plainText);
			writer.Flush();
			cryptoStream.FlushFinalBlock();
			writer.Flush();
			return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
		}

		public static string Decrypt(string cryptedString) {
			if ( String.IsNullOrEmpty(cryptedString) ) {
				return cryptedString;
			}
			var rgbKey = Encoding.ASCII.GetBytes(encryptKey);
			var rgbIV = Encoding.ASCII.GetBytes(encryptKey);
			DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
			MemoryStream memoryStream = new MemoryStream
					(Convert.FromBase64String(cryptedString));
			CryptoStream cryptoStream = new CryptoStream(memoryStream,
				cryptoProvider.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Read);
			StreamReader reader = new StreamReader(cryptoStream);
			return reader.ReadToEnd();
		}
	}
}
