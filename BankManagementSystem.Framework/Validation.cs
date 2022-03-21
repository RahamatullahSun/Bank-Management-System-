using System;

namespace BankManagementSystem.Framework
{
    public static class Validation
    {
        public static bool IsStringInvalid(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                return false;

            return true;
        }
        public static bool IsIntvalid(string value)
        {
            int i;
            return Int32.TryParse(value, out i);
        }
        public static bool IsFloatValid(string value)
        {
            try
            {
                float.Parse(value);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool IsDateTimeValid(string value)
        {
            try
            {
                DateTime.Parse(value);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
