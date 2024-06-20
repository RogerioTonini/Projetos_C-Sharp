using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Media.Imaging;

namespace ControlYou.DataBase
{
	public static class Util
	{
		#region *===> Conversores <===*
		public static String GetString(object readerValue)
		{
			if (readerValue != DBNull.Value && readerValue != null)
				return Convert.ToString(readerValue).Trim();
			return String.Empty;
		}

		public static int GetInt(object readerValue, int defaultValue = 0)
		{
			if (readerValue != DBNull.Value && readerValue != null)
				return Convert.ToInt32(readerValue);
			return defaultValue;
		}

		public static long GetLong(object readerValue, int defaultValue = 0)
		{
			if (readerValue != DBNull.Value && readerValue != null)
				return Convert.ToInt64(readerValue);
			return defaultValue;
		}

		public static decimal GetDecimal(object readerValue, int defaultValue = 0)
		{
			if (readerValue != DBNull.Value && readerValue != null)
				return Convert.ToDecimal(readerValue);
			return defaultValue;
		}
		#endregion

		public static DateTime DataHoraSistema()
		{
			DateTime retorno;

			try
			{
				TimeZoneInfo tmzinfo = new TimeZoneInfo();
				GetTimeZoneInformation(out tmzinfo);

				
			}
			catch
			{
				retorno = DateTime.UtcNow();
			}

			[DllImport("kerne32.dll", CharSet = CharSet.Auto)]

			static extern int GetTimeZoneInformation(out TimeZoneInfo lpTimeZoneInfo);

			return retorno;
		}
	}
}