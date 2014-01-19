using System;
using System.Globalization;
using System.Reflection;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.IO;
#if !N_PRODUCT_HAS_NO_LICENSES
using Neurotec.Licensing;
#endif

namespace Neurotec.Samples
{
	public static class Utils
	{
		public static void PrintTutorialHeader(string [] args)
		{
			string description = ((AssemblyDescriptionAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false)[0]).Description;
			string version = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
			string copyright = ((AssemblyCopyrightAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false)[0]).Copyright;
			Console.WriteLine(GetAssemblyName());
			Console.WriteLine("");
			Console.WriteLine(@"{0} (Version: {1})", description, version);
			Console.WriteLine(copyright.Replace("?", "(C)"));
			Console.WriteLine();
			if (args != null && args.Length > 0)
			{
				Console.WriteLine("Arguments:");
				foreach (string item in args)
				{
					Console.WriteLine("\t{0}", item);
				}
				Console.WriteLine();
			}
		}

#if !N_PRODUCT_HAS_NO_LICENSES

		public static void ObtainLicenses(string license)
		{
			ObtainLicenses(new string[] { license });
		}

		public static void ObtainLicenses(IList<string> licenses)
		{
			foreach (string license in licenses)
			{
				try
				{
					bool available = NLicense.ObtainComponents("/local", "5000", license);

					if (!available)
					{
						throw new ApplicationException(string.Format("license for {0} was not obtained", license));
					}
				}
				catch (Exception ex)
				{
					throw new ApplicationException(string.Format("Error while obtaining license. Please check if Neurotec Activation Service is running. Details: {0}", ex));
				}
			}
		}

		public static void ReleaseLicenses(IList<string> licenses)
		{
			foreach (string license in licenses)
			{
				NLicense.ReleaseComponents(license);
			}
		}

	#endif // !N_PRODUCT_HAS_NO_LICENSES

		public static string GetAssemblyName()
		{
			return Assembly.GetExecutingAssembly().GetName().Name;
		}

		public static string GetAssemblyPath()
		{
			return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
		}

		public static int QualityToPercent(byte value)
		{
			return (2 * value * 100 + 255) / (2 * 255);
		}

		public static byte QualityFromPercent(int value)
		{
			return (byte)((2 * value * 255 + 100) / (2 * 100));
		}

		public static string MatchingThresholdToString(int value)
		{
			double p = -value / 12.0;
			return string.Format(string.Format("{{0:P{0}}}", Math.Max(0, (int)Math.Ceiling(-p) - 2)), Math.Pow(10, p));
		}

		public static int MatchingThresholdFromString(string value)
		{
			double p = Math.Log10(Math.Max(double.Epsilon, Math.Min(1,
				double.Parse(value.Replace(CultureInfo.CurrentCulture.NumberFormat.PercentSymbol, "")) / 100)));
			return Math.Max(0, (int)Math.Round(-12 * p));
		}

		public static int MaximalRotationToDegrees(byte value)
		{
			return (2 * value * 360 + 256) / (2 * 256);
		}

		public static byte MaximalRotationFromDegrees(int value)
		{
			return (byte)((2 * value * 256 + 360) / (2 * 360));
		}

		public static string GetUserLocalDataDir(string productName)
		{
			string localDataDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			localDataDir = Path.Combine(localDataDir, "Neurotechnology");
			if (!Directory.Exists(localDataDir))
			{
				Directory.CreateDirectory(localDataDir);
			}
			localDataDir = Path.Combine(localDataDir, productName);
			if (!Directory.Exists(localDataDir))
			{
				Directory.CreateDirectory(localDataDir);
			}

			return localDataDir;
		}
	}
}
