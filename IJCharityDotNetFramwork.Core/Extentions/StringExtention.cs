using System;

namespace IJCharityDotNetFramwork.Core.Extentions
{
    public static class StringExtention
    {
        public static string ReplaceToYeFarsi(this string text)
        {
            if (!String.IsNullOrWhiteSpace(text) || !String.IsNullOrEmpty(text))
            {
                text = text.Replace("ي", "ی").Trim();
            }
            return text;
        }
        public static string ReplaceToYeDb(this string text)
        {
            if (!String.IsNullOrWhiteSpace(text) || !String.IsNullOrEmpty(text))
            {
                text = text.Replace("ی", "ي").Trim();
            }
            return text;
        }
        public static string ReplaceToKeFarsi(this string text)
        {
            if (!String.IsNullOrWhiteSpace(text) || !String.IsNullOrEmpty(text))
            {
                text = text.Replace("ك", "ک").Trim();
            }
            return text;
        }
        public static string ReplaceToKeDb(this string text)
        {
            if (!String.IsNullOrWhiteSpace(text) || !String.IsNullOrEmpty(text))
            {
                text = text.Replace("ک", "ك").Trim();
            }
            return text;
        }
        public static int RemoveDateChar(this string text)
        {
            if (!String.IsNullOrWhiteSpace(text) || !String.IsNullOrEmpty(text))
            {
                text = text.Replace("/", String.Empty).Trim();
            }
            return int.Parse(text);
        }
        public static int FindShomareParvande(this string text)
        {
            string shomareParvande = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    shomareParvande += text[i];
                }
            }
            if (!String.IsNullOrEmpty(shomareParvande))
            {
                return int.Parse(shomareParvande);
            }
            return 0;
        }

    }
}
