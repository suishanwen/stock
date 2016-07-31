using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock.util
{

    class StringUtil
    {
        /// <summary>
        /// 判断字符串的是否为空
        /// </summary>
        /// <param name="str">需要判断的字符串</param>
        /// <returns>如果为空返回为true，如果不为空返回为false</returns>
        public static Boolean isEmpty(String str)
        {
            if (str == null)
                return true;
            String tempStr = str.Trim();
            if (tempStr.Length == 0)
                return true;
            if (tempStr.Equals(("null")))
                return true;
            return false;
        }

        public static void setText(TextBox textbox,String text)
        {
            if (!isEmpty(text))
            {
                textbox.Text = text;
            }
        }

        public static void setLabel(Label label, String text)
        {
            if (!isEmpty(text))
            {
                label.Text = text;
            }
        }
    }
}
