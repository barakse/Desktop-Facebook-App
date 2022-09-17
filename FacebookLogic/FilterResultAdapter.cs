using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class FilterResultAdapter : IFilterResultFormat
    {
        private const int k_NoYearDefaultValue = 1;
        private readonly DateTime r_Birthday;
        private readonly List<string> r_Signs = new List<string>()
                                                    {
                                                        string.Empty,
                                                        "Capricorn",
                                                        "Aquarius",
                                                        "Pisces",
                                                        "Aries",
                                                        "Taurus",
                                                        "Gemini",
                                                        "Cancer",
                                                        "Leo",
                                                        "Virgo",
                                                        "Libra",
                                                        "Scorpio",
                                                        "Sagittarius"
                                                    };
        
        public FilterResultAdapter(string i_Birthday)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            r_Birthday = i_Birthday.Length != 10
                             ? DateTime.ParseExact(i_Birthday, "MM/dd", provider)
                             : DateTime.ParseExact(i_Birthday, "MM/dd/yyyy", provider);

            if (i_Birthday.Length != 10)
            {
                r_Birthday = new DateTime(k_NoYearDefaultValue, r_Birthday.Month, r_Birthday.Day);
            }
        }

        public string GetAge()
        {
            int age = 0; 

            if(r_Birthday.Year != k_NoYearDefaultValue)
            {
                age = DateTime.Today.Year - r_Birthday.Year;

                if(DateTime.Today.DayOfYear < r_Birthday.DayOfYear)
                {
                    age -= 1;
                }
            }

            return r_Birthday.Year != k_NoYearDefaultValue ? age.ToString() : "-";
        }

        public string GetSign()
        {
            string sign = null;

            switch(r_Birthday.Month)
            {
                case 1:
                    {
                        sign = r_Birthday.Day <= 20 ? r_Signs[1] : r_Signs[2];
                        break;
                    }

                case 2:
                    {
                        sign = r_Birthday.Day <= 18 ? r_Signs[2] : r_Signs[3];
                        break;
                    }

                case 3:
                    {
                        sign = r_Birthday.Day <= 20 ? r_Signs[3] : r_Signs[4];
                        break;
                    }

                case 4:
                    {
                        sign = r_Birthday.Day <= 20 ? r_Signs[4] : r_Signs[5];
                        break;
                    }

                case 5:
                    {
                        sign = r_Birthday.Day <= 20 ? r_Signs[5] : r_Signs[6];
                        break;
                    }

                case 6:
                    {
                        sign = r_Birthday.Day <= 21 ? r_Signs[6] : r_Signs[7];
                        break;
                    }

                case 7:
                    {
                        sign = r_Birthday.Day <= 22 ? r_Signs[7] : r_Signs[8];
                        break;
                    }

                case 8:
                    {
                        sign = r_Birthday.Day <= 22 ? r_Signs[8] : r_Signs[9];
                        break;
                    }

                case 9:
                    {
                        sign = r_Birthday.Day <= 22 ? r_Signs[9] : r_Signs[10];
                        break;
                    }

                case 10:
                    {
                        sign = r_Birthday.Day <= 23 ? r_Signs[10] : r_Signs[11];
                        break;
                    }

                case 11:
                    {
                        sign = r_Birthday.Day <= 21 ? r_Signs[11] : r_Signs[12];
                        break;
                    }

                case 12:
                    {
                        sign = r_Birthday.Day <= 21 ? r_Signs[12] : r_Signs[1];
                        break;
                    }
            }

            return sign;
        }
    }
}
