using System;
using System.Collections.Generic;
using System.Text;

namespace BudStudio.DgvColumn.SFL
{
    public class DataValid
    {
        /// <summary>
        /// 判断一个对象是否为空，如传入对象为string类型，
        /// 该方法会判断所传入的string是否包含内容。
        /// </summary>
        public static bool IsNull(object obj)
        {
            if (obj == null) return true;
            if (obj is string)
            {
                string tmpStr = (string)obj;
                return string.IsNullOrEmpty(tmpStr.Trim());
            }
            else
                return false;
        }

        /// <summary>
        /// 判断一个字符串是否是一个有效的布尔（bool)类型。
        /// </summary>
        public static bool IsBool(string value)
        {
            try
            {
                Convert.ToBoolean(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否是一个有效的Char类型。
        /// </summary>
        public static bool IsChar(string value)
        {
            try
            {
                Convert.ToChar(value.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否是一个有效的日期。
        /// </summary>
        public static bool IsDateTime(string value)
        {
            try
            {
                Convert.ToDateTime(value.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否是一个有效的数字。
        /// </summary>
        public static bool IsDecimal(string value)
        {
            try
            {
                Convert.ToDecimal(value.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否是一个有效的数字。
        /// </summary>
        public static bool IsDouble(string value)
        {
            try
            {
                Convert.ToDouble(value.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否是一个有效的数字。
        /// </summary>
        public static bool IsFloat(string value)
        {
            try
            {
                Convert.ToSingle(value.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否是一个有效的Guid。
        /// </summary>
        public static bool IsGuid(string value)
        {
            try
            {
                Guid guid = new Guid(value.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否是一个有效的整数。
        /// </summary>
        public static bool IsSByte(string value)
        {
            try
            {
                Convert.ToSByte(value.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否是一个有效的正整数。
        /// </summary>
        public static bool IsByte(string value)
        {
            try
            {
                Convert.ToByte(value.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否是一个有效的整数。
        /// </summary>
        public static bool IsInt(string value)
        {
            try
            {
                Convert.ToInt32(value.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否是一个有效的正整数。
        /// </summary>
        public static bool IsUInt(string value)
        {
            try
            {
                Convert.ToUInt32(value.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否是一个有效的整数。
        /// </summary>
        public static bool IsShort(string value)
        {
            try
            {
                Convert.ToInt16(value.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// 判断一个字符串是否是一个有效的正整数。
        /// </summary>
        public static bool IsUShort(string value)
        {
            try
            {
                Convert.ToUInt16(value.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// 判断一个字符串是否是一个有效的整数。
        /// </summary>
        public static bool IsLong(string value)
        {
            try
            {
                Convert.ToInt64(value.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否是一个有效的正整数。
        /// </summary>
        public static bool IsULong(string value)
        {
            try
            {
                Convert.ToUInt64(value.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否为空，当所传入的字符串不会空时，
        /// 将检测该字符串是否是一个有效的布尔（bool)类型。
        /// </summary>
        public static bool IsNullOrBool(string value)
        {
            if (string.IsNullOrEmpty(value)) return true;
            value = value.Trim();
            try
            {
                Convert.ToBoolean(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否为空，当所传入的字符串不会空时，
        /// 将检测该字符串是否是一个有效的Char类型。
        /// </summary>
        public static bool IsNullOrChar(string value)
        {
            if (string.IsNullOrEmpty(value)) return true;
            value = value.Trim();
            try
            {
                Convert.ToChar(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否为空，当所传入的字符串不会空时，
        /// 将检测该字符串是否是一个有效的日期。
        /// </summary>
        public static bool IsNullOrDateTime(string value)
        {
            if (string.IsNullOrEmpty(value)) return true;
            value = value.Trim();
            try
            {
                Convert.ToDateTime(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否为空，当所传入的字符串不会空时，
        /// 将检测该字符串是否是一个有效的数字。
        /// </summary>
        public static bool IsNullOrDecimal(string value)
        {
            if (string.IsNullOrEmpty(value)) return true;
            value = value.Trim();
            try
            {
                Convert.ToDecimal(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否为空，当所传入的字符串不会空时，
        /// 将检测该字符串是否是一个有效的数字。
        /// </summary>
        public static bool IsNullOrDouble(string value)
        {
            if (string.IsNullOrEmpty(value)) return true;
            value = value.Trim();
            try
            {
                Convert.ToDouble(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否为空，当所传入的字符串不会空时，
        /// 将检测该字符串是否是一个有效的数字。
        /// </summary>
        public static bool IsNullOrFloat(string value)
        {
            if (string.IsNullOrEmpty(value)) return true;
            value = value.Trim();
            try
            {
                Convert.ToSingle(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否为空，当所传入的字符串不会空时，
        /// 将检测该字符串是否是一个有效的Guid。
        /// </summary>
        public static bool IsNullOrGuid(string value)
        {
            if (string.IsNullOrEmpty(value)) return true;
            value = value.Trim();
            try
            {
                Guid guid = new Guid(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否为空，当所传入的字符串不会空时，
        /// 将检测该字符串是否是一个有效的整数。
        /// </summary>
        public static bool IsNullOrSByte(string value)
        {
            if (string.IsNullOrEmpty(value)) return true;
            value = value.Trim();
            try
            {
                Convert.ToSByte(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否为空，当所传入的字符串不会空时，
        /// 将检测该字符串是否是一个有效的正整数。
        /// </summary>
        public static bool IsNullOrByte(string value)
        {
            if (string.IsNullOrEmpty(value)) return true;
            value = value.Trim(); 
            try
            {
                Convert.ToByte(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否为空，当所传入的字符串不会空时，
        /// 将检测该字符串是否是一个有效的整数。
        /// </summary>
        public static bool IsNullOrInt(string value)
        {
            if (string.IsNullOrEmpty(value)) return true;
            value = value.Trim(); 
            try
            {
                Convert.ToInt32(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否为空，当所传入的字符串不会空时，
        /// 将检测该字符串是否是一个有效的正整数。
        /// </summary>
        public static bool IsNullOrUInt(string value)
        {
            if (string.IsNullOrEmpty(value)) return true;
            value = value.Trim(); 
            try
            {
                Convert.ToUInt32(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否为空，当所传入的字符串不会空时，
        /// 将检测该字符串是否是一个有效的整数。
        /// </summary>
        public static bool IsNullOrShort(string value)
        {
            if (string.IsNullOrEmpty(value)) return true;
            value = value.Trim(); 
            try
            {
                Convert.ToInt16(value);
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// 判断一个字符串是否为空，当所传入的字符串不会空时，
        /// 将检测该字符串是否是一个有效的正整数。
        /// </summary>
        public static bool IsNullOrUShort(string value)
        {
            if (string.IsNullOrEmpty(value)) return true;
            value = value.Trim(); 
            try
            {
                Convert.ToUInt16(value);
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// 判断一个字符串是否为空，当所传入的字符串不会空时，
        /// 将检测该字符串是否是一个有效的整数。
        /// </summary>
        public static bool IsNullOrLong(string value)
        {
            if (string.IsNullOrEmpty(value)) return true;
            value = value.Trim(); 
            try
            {
                Convert.ToInt64(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断一个字符串是否为空，当所传入的字符串不会空时，
        /// 将检测该字符串是否是一个有效的正整数。
        /// </summary>
        public static bool IsNullOrULong(string value)
        {
            if (string.IsNullOrEmpty(value)) return true;
            value = value.Trim(); 
            try
            {
                Convert.ToUInt64(value);
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// 对所传入的字符串进行判断，如果字符串为空，直接返回null值。
        /// 如字符串不为空，尝试将该字符串转换为一个布尔（bool)类型返回。
        /// </summary>
        public static bool? GetNullOrBool(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            value = value.Trim();
            return Convert.ToBoolean(value);
        }

        /// <summary>
        /// 对所传入的字符串进行判断，如果字符串为空，直接返回null值。
        /// 如字符串不为空，尝试将该字符串转换为一个DateTime类型返回。
        /// </summary>
        public static DateTime? GetNullOrDateTime(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            value = value.Trim();
            return Convert.ToDateTime(value);
        }

        /// <summary>
        /// 对所传入的字符串进行判断，如果字符串为空，直接返回null值。
        /// 如字符串不为空，尝试将该字符串转换为一个Decimal类型返回。
        /// </summary>
        public static decimal? GetNullOrDecimal(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            value = value.Trim();
            return Convert.ToDecimal(value);
        }

        /// <summary>
        /// 对所传入的字符串进行判断，如果字符串为空，直接返回null值。
        /// 如字符串不为空，尝试将该字符串转换为一个double类型返回。
        /// </summary>
        public static double? GetNullOrDouble(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            value = value.Trim();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// 对所传入的字符串进行判断，如果字符串为空，直接返回null值。
        /// 如字符串不为空，尝试将该字符串转换为一个float类型返回。
        /// </summary>
        public static float? GetNullOrFloat(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            value = value.Trim();
            return Convert.ToSingle(value);
        }

        /// <summary>
        /// 对所传入的字符串进行判断，如果字符串为空，直接返回null值。
        /// 如字符串不为空，尝试将该字符串转换为一个Guid类型返回。
        /// </summary>
        public static Guid? GetNullOrGuid(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            value = value.Trim();
            return new Guid(value);
        }

        /// <summary>
        /// 对所传入的字符串进行判断，如果字符串为空，直接返回null值。
        /// 如字符串不为空，尝试将该字符串转换为一个byte类型返回。
        /// </summary>
        public static byte? GetNullOrByte(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            value = value.Trim();
            return Convert.ToByte(value);
        }

        /// <summary>
        /// 对所传入的字符串进行判断，如果字符串为空，直接返回null值。
        /// 如字符串不为空，尝试将该字符串转换为一个sbyte类型返回。
        /// </summary>
        public static sbyte? GetNullOrSByte(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            value = value.Trim();
            return Convert.ToSByte(value);
        }

        /// <summary>
        /// 对所传入的字符串进行判断，如果字符串为空，直接返回null值。
        /// 如字符串不为空，尝试将该字符串转换为一个char类型返回。
        /// </summary>
        public static char? GetNullOrChar(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            value = value.Trim();
            return Convert.ToChar(value);
        }

        /// <summary>
        /// 对所传入的字符串进行判断，如果字符串为空，直接返回null值。
        /// 如字符串不为空，尝试将该字符串转换为一个short类型返回。
        /// </summary>
        public static short? GetNullOrShort(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            value = value.Trim();
            return Convert.ToInt16(value);
        }

        /// <summary>
        /// 对所传入的字符串进行判断，如果字符串为空，直接返回null值。
        /// 如字符串不为空，尝试将该字符串转换为一个ushort类型返回。
        /// </summary>
        public static ushort? GetNullOrUShort(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            value = value.Trim();
            return Convert.ToUInt16(value);
        }

        /// <summary>
        /// 对所传入的字符串进行判断，如果字符串为空，直接返回null值。
        /// 如字符串不为空，尝试将该字符串转换为一个int类型返回。
        /// </summary>
        public static int? GetNullOrInt(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            value = value.Trim();
            return Convert.ToInt32(value);
        }

        /// <summary>
        /// 对所传入的字符串进行判断，如果字符串为空，直接返回null值。
        /// 如字符串不为空，尝试将该字符串转换为一个uint类型返回。
        /// </summary>
        public static uint? GetNullOrUInt(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            value = value.Trim();
            return Convert.ToUInt32(value);
        }

        /// <summary>
        /// 对所传入的字符串进行判断，如果字符串为空，直接返回null值。
        /// 如字符串不为空，尝试将该字符串转换为一个long类型返回。
        /// </summary>
        public static long? GetNullOrLong(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            value = value.Trim();
            return Convert.ToInt64(value);
        }

        /// <summary>
        /// 对所传入的字符串进行判断，如果字符串为空，直接返回null值。
        /// 如字符串不为空，尝试将该字符串转换为一个ulong类型返回。
        /// </summary>
        public static ulong? GetNullOrULong(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            value = value.Trim();
            return Convert.ToUInt64(value);
        }

        /// <summary>
        /// 对所传入的字符串进行判断，如果字符串为空，直接返回null值。
        /// 如字符串不为空，Trim()后返回该字符串。
        /// </summary>
        public static string GetNullOrString(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            value = value.Trim();
            return value;
        }

        /// <summary>
        /// 判断所传入字符串的长度，是否超过指定长度。
        /// 如果字符串为空或null，返回false。
        /// </summary>
        public static bool IsOutLength(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return false;
            if (value.Length > maxLength) return true;
            return false;
        }

        /// <summary>
        /// 对所传入的字符串进行判断，如果字符串为空，直接返回null值。
        /// 如字符串不为空，尝试将该字符串转换为一个int类型返回。
        /// </summary>
        public static int GetIntOrZero(string value)
        {
            try
            {
                return Convert.ToInt32(value.Trim());
            }
            catch
            {
                return 0;
            }
        }
    }
}
