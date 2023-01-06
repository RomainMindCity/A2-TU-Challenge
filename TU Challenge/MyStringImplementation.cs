using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null || input == "" || input == " " || input == "    ")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string MixString(string a, string b)
        {
            if (a == null || b == null || a == "" || b == "")
            {
                throw new ArgumentException();
            }
            else
            {
                string result = "";
                int i = 0;
                int j = 0;
                while (i < a.Length && j < b.Length)
                {
                    result += a[i];
                    result += b[j];
                    i++;
                    j++;
                }
                if (i < a.Length)
                {
                    result += a.Substring(i);
                }
                if (j < b.Length)
                {
                    result += b.Substring(j);
                }
                return result;
            }
        }

        public static string ToLowerCase(string a)
        {
            string result = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 'A' && a[i] <= 'Z')
                {
                    result += (char)(a[i] + 32);
                }
                else
                {
                    result += a[i];
                }
            }
            return result;
        }

        public static string Voyelles(string a)
        {
            string result = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u' || a[i] == 'y' || a[i] == 'A' || a[i] == 'E' || a[i] == 'I' || a[i] == 'O' || a[i] == 'U' || a[i] == 'Y')
                {
                    bool alreadyIn = false;
                    for (int j = 0; j < result.Length; j++)
                    {
                        if (result[j] == a[i])
                        {
                            alreadyIn = true;
                        }
                    }
                    if (alreadyIn == false)
                    {
                        result += a[i];
                    }
                }
            }
            result = ToLowerCase(result);
            return result;
        }

        public static string Reverse(string a)
        {
            string result = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                result += a[i];
            }
            return result;
        }


        public static string BazardString(string input)
        {
            string resultat = "";
            string autresLettres = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    resultat += input[i];
                }
                else
                {
                    autresLettres += input[i];
                }
            }
            return resultat + autresLettres;
        }

        public static string UnBazardString(string input)
        {
            string resultat = "";
            string autresLettres = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (i < input.Length / 2)
                {
                    resultat += input[i];
                }
                else
                {
                    autresLettres += input[i];
                }
            }
            string result = "";
            for (int i = 0; i < resultat.Length; i++)
            {
                result += resultat[i];
                if (i < autresLettres.Length)
                {
                    result += autresLettres[i];
                }
            }
            return result;
        }

        public static string ToCesarCode(string input, int decalage)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    result.Append((char)((input[i] - 'a' + decalage) % 26 + 'a'));
                }
                else if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    result.Append((char)((input[i] - 'A' + decalage) % 26 + 'A'));
                }
                else
                {
                    result.Append(input[i]);
                }
            }

            return result.ToString();
        }

        
    }
}
