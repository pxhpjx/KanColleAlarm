using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Reflection;
using System.Threading;

namespace KanColleAlarm
{
    /// <summary>
    /// PP's FormatTools -20140320 ver-
    /// 数据格式转化工具
    /// </summary>
    public static class FormatTools
    {
        #region 数据格式转换

        /// <summary>
        /// 转化任意数据为Int（无效返回0）
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ParseInt(object obj)
        {
            int result;
            if (obj != null && int.TryParse(obj.ToString(), out result))
                return result;
            else
                return 0;
        }

        /// <summary>
        /// 转化任意数据为Int?（无效返回null）
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int? ParseNInt(object obj)
        {
            int? result = null;
            int i;
            if (obj != null && int.TryParse(obj.ToString(), out i))
                result = i;
            return result;
        }

        /// <summary>
        /// 转化任意数据为double（无效返回0）
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static double ParseDouble(object obj)
        {
            double result;
            if (obj != null && double.TryParse(obj.ToString(), out result))
                return result;
            else
                return 0;
        }

        /// <summary>
        /// 转化任意数据为double?（无效返回null）
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static double? ParseNDouble(object obj)
        {
            double? result = null;
            double d;
            if (obj != null && double.TryParse(obj.ToString(), out d))
                result = d;
            return result;
        }

        /// <summary>
        /// 转化任意数据为指定小数位数的double?（无效返回null）
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="i">小数位数</param>
        /// <returns></returns>
        public static double? ParseNDouble(object obj, int i)
        {
            double? result = null;
            double d;
            if (obj != null && double.TryParse(obj.ToString(), out d))
                result = d;
            if (result != null)
                while (i > 0)
                {
                    result /= 10;
                    i--;
                }
            return result;
        }


        /// <summary>
        /// 转化任意数据为long（无效返回0）
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static long ParseLong(object obj)
        {
            long result;
            if (obj != null && long.TryParse(obj.ToString(), out result))
                return result;
            else
                return 0;
        }

        /// <summary>
        /// 转化任意数据为byte（无效返回0）
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static byte ParseByte(object obj)
        {
            byte result;
            if (obj != null && byte.TryParse(obj.ToString(), out result))
                return result;
            else
                return 0;
        }

        /// <summary>
        /// 转化任意数据为byte?（无效返回null）
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static byte? ParseNByte(object obj)
        {
            byte? result = null;
            byte b;
            if (obj != null && byte.TryParse(obj.ToString(), out b))
                result = b;
            return result;
        }

        /// <summary>
        /// 转化任意数据为DateTime（无效返回new DateTime()）
        /// 特别的，可以识别YYYYMMDD格式的8位数字并进行转化
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static DateTime ParseDate(object obj)
        {
            DateTime result;
            if (obj != null && DateTime.TryParse(obj.ToString(), out result))
                return result;
            if (obj != null && obj.ToString().Length == 8 && ParseInt(obj) > 0)
                return new DateTime(ParseInt(obj.ToString().Substring(0, 4)), ParseInt(obj.ToString().Substring(4, 2)), ParseInt(obj.ToString().Substring(6, 2)));
            return new DateTime();
        }

        /// <summary>
        /// 转化任意数据为DateTime（无效返回null）
        /// 特别的，可以识别YYYYMMDD格式的8位数字并进行转化
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static DateTime? ParseNDate(object obj)
        {
            DateTime result;
            if (obj != null && DateTime.TryParse(obj.ToString(), out result))
                return result;
            if (obj != null && obj.ToString().Length == 8 && ParseInt(obj) > 0)
                return new DateTime(ParseInt(obj.ToString().Substring(0, 4)), ParseInt(obj.ToString().Substring(4, 2)), ParseInt(obj.ToString().Substring(6, 2)));
            return null;
        }

        /// <summary>
        /// 转化任意数据为string（无效返回null）
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ParseString(object obj)
        {
            return obj == null ? null : obj.ToString();
        }

        /// <summary>
        /// 转化任意数据为string（无效返回""）
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ParseStringE(object obj)
        {
            return obj == null ? "" : obj.ToString();
        }

        /// <summary>
        /// 转化日期为string（无效或new则返回""）
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Date2String(object obj)
        {
            DateTime result = new DateTime();
            try
            {
                result = (DateTime)obj;
            }
            catch { }
            return result == new DateTime() ? "" : result.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// 将日期做Oracle数据库可null处理，若无效或new则返回""
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static object Date2Oracle(object obj)
        {
            DateTime result = new DateTime();
            try
            {
                result = (DateTime)obj;
            }
            catch { }
            return result == new DateTime() ? (object)"" : obj;
        }

        /// <summary>
        /// 转化任意数据为decimal
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static decimal ParseDecimal(object obj)
        {
            decimal result;
            if (obj != null && decimal.TryParse(obj.ToString(), out result))
                return result;
            else
                return 0;
        }

        /// <summary>
        /// 转化任意数据为bool（特例：1/0转化为true/false）
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool ParseBool(object obj)
        {
            bool result = false;
            if (obj != null)
            {
                if (obj.ToString() == "0")
                    return false;
                if (obj.ToString() == "1")
                    return true;
                bool.TryParse(obj.ToString(), out result);
            }
            return result;
        }

        public static TimeSpan ParseTimeSpan(object obj)
        {
            TimeSpan result;
            if (obj != null && TimeSpan.TryParse(obj.ToString(), out result))
                return result;
            else
                return new TimeSpan();
        }

        #endregion

        /// <summary>
        /// 将两个List中的数据合并到一个新的List中。
        /// List中的每一个实体均保持原有引用。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static List<T> ListCombine<T>(List<T> list1, List<T> list2)
        {
            List<T> result = new List<T>();
            if (list1 != null && list1.Count > 0)
                foreach (T entity in list1)
                    result.Add(entity);
            if (list2 != null && list2.Count > 0)
                foreach (T entity in list2)
                    result.Add(entity);
            return result;
        }

        #region 复制

        /// <summary>
        /// 简单复制类的值。
        /// 类中含有引用类型字段时，会 导致引用复制该字段。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        public static T SampleCopy<T>(T input) where T : class,new()
        {
            T Result = null;
            if (input != null)
            {
                try
                {
                    Result = new T();
                    Type type = typeof(T);
                    PropertyInfo[] Props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                    foreach (PropertyInfo p in Props)
                    {
                        object ElementValue = p.GetValue(input, null);
                        p.SetValue(Result, ElementValue, null);
                    }
                }
                catch { }
            }
            return Result;
        }

        /// <summary>
        /// Developing
        /// 完全复制类与结构的值。不能用于复制List。
        /// 无论类中是否含有引用类型字段，都 不会 复制引用，而是创建一个具有相同值的副本。
        /// 除非input为object，否则不需要强制指定inputType。inputType与T不统一时，无法进行复制。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <param name="inputType"></param>
        /// <returns></returns>
        public static T ValueCopy<T>(T input, Type inputType = null)
        {
            T result = default(T);
            if (input != null)
            {
                try
                {
                    Type type = (inputType == null ? typeof(T) : inputType);
                    result = (T)Activator.CreateInstance(type);
                    PropertyInfo[] Props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
                    if (type.IsValueType)
                    {
                        if (Props == null)
                            return input;
                        if (Props.ToList().Find(item => !item.PropertyType.IsValueType) == null)
                            return input;
                    }
                    foreach (PropertyInfo p in Props)
                    {
                        Type t = p.PropertyType;
                        object ElementValue = p.GetValue(input, null);
                        if (!t.IsValueType && t.FullName != "System.String")
                        {
                            object value = ValueCopy(ElementValue, t);
                            p.SetValue(result, value, null);
                        }
                        else
                            p.SetValue(result, ElementValue, null);
                    }
                }
                catch { }
            }
            return result;
        }

        /// <summary>
        /// 使用指定的Type生成空List
        /// </summary>
        /// <param name="inputType"></param>
        /// <returns></returns>
        public static object CreateListByType(Type inputType)
        {
            object result = null;
            try
            {
                MethodInfo mi = typeof(FormatTools).GetMethod("CreateList").MakeGenericMethod(inputType);
                result = mi.Invoke("", null);
            }
            catch { }
            return result;
        }

        /// <summary>
        /// 创建List。
        /// 为反射提供入口，不做其他用途。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> CreateList<T>()
        {
            return new List<T>();
        }

        #endregion

        /// <summary>
        /// 附加超时限制运行方法。
        /// </summary>
        /// <typeparam name="T">返回值类型</typeparam>
        /// <param name="func">需要执行的方法</param>
        /// <param name="timeOut">超时限制（毫秒）</param>
        /// <param name="output">方法输出结果</param>
        /// <returns>是否成功执行完毕</returns>
        public static bool ExecFuncWithTimeOut<T>(Func<T> func, int timeOut, out T output)
        {
            bool isExecFinished = false;
            T result = default(T);
            Thread th = new Thread(() => { result = func(); isExecFinished = true; });
            Timer t = null;
            try
            {
                th.Start();
                t = new Timer(new System.Threading.TimerCallback(th.Abort), null, timeOut, int.MaxValue);
                while (!isExecFinished && th.IsAlive)
                {
                    Thread.Sleep(50);
                }
            }
            catch { }
            if (t != null)
                t.Dispose();
            if (th.IsAlive)
                th.Abort();

            output = result;
            return isExecFinished;
        }



    }
}
