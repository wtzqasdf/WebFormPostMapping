using System;
using System.Reflection;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public class BasePage : Page
    {
        protected T GetPost<T>()
        {
            //利用泛型建立物件
            T result = (T)Activator.CreateInstance(typeof(T));
            Mapping(result, Request.Form);
            return result;
        }

        private void Mapping(object obj, NameValueCollection collection)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                //取得Attribute Name，如果沒有就取Property Name
                ColumnAttribute attribute = (ColumnAttribute)prop.GetCustomAttribute(typeof(ColumnAttribute));
                string name = attribute != null ? attribute.Name : prop.Name;
                string value = collection[name].ToString();
                //型別判斷與資料轉換
                if (prop.PropertyType == typeof(int) ||
                    //Enum判斷 + Enum的基礎型別判斷
                    (prop.PropertyType.IsEnum && prop.PropertyType.GetEnumUnderlyingType() == typeof(int)))
                {
                    int result = default;
                    int.TryParse(value, out result);
                    prop.SetValue(obj, result);
                }
                else if (prop.PropertyType == typeof(float))
                {
                    float result = default;
                    float.TryParse(value, out result);
                    prop.SetValue(obj, result);
                }
                else if (prop.PropertyType == typeof(DateTime))
                {
                    DateTime result = default;
                    DateTime.TryParse(value, out result);
                    prop.SetValue(obj, result);
                }
                else if (prop.PropertyType == typeof(string))
                {
                    prop.SetValue(obj, value);
                }
                //型別判斷與資料轉換(Nullable型別)
                else if (prop.PropertyType == typeof(int?))
                {
                    int? result = null;
                    if (int.TryParse(value, out int origin))
                    {
                        result = origin;
                    }
                    prop.SetValue(obj, result);
                }
                else if (prop.PropertyType == typeof(float?))
                {
                    float? result = null;
                    if (float.TryParse(value, out float origin))
                    {
                        result = origin;
                    }
                    prop.SetValue(obj, result);
                }
                else if (prop.PropertyType == typeof(DateTime?))
                {
                    DateTime? result = null;
                    if (DateTime.TryParse(value, out DateTime origin))
                    {
                        result = origin;
                    }
                    prop.SetValue(obj, result);
                }
            }
        }
    }
}