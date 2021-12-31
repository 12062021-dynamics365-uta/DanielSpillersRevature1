using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            byte myByte = 255;
             sbyte mySbyte = -128;
             int myInt = 2147483647;
             uint myUint = 4294967295;
             short myShort = -32768;
             ushort myUShort = 65535;
             float myFloat = -31.1289f;
             double myDouble = -12.1231250;
             char myCharacter = 'A';
             bool myBool = true;
             string myText = "I control text";
             string numString = "15";
             decimal myDecimal = 3.001002003m;
             long myLong = 9223372036854775807;
             ulong myUlong = 18446744073709551615;
            PrintValues(myByte);
            PrintValues(mySbyte);
            PrintValues(myInt);
            PrintValues(myUint);
            PrintValues(myShort);
            PrintValues(myUShort);
            PrintValues(myFloat);
            PrintValues(myDouble);
            PrintValues(myCharacter);
            PrintValues(myBool);
            PrintValues(myText);
            PrintValues(numString);
            PrintValues(myDecimal);
            PrintValues(myLong);
            PrintValues(myUlong);

            string string1 = "I control text";
            string string2 = "112388";
            int? returnVal = StringToInt(string2);
            

            Console.WriteLine(string1 + " "+ returnVal);
        }

        /// <summary>
        /// This method has an 'object' type parameter. 
        /// 1. Create a switch statement that evaluates for the data type of the parameter
        /// 2. You will need to get the data type of the parameter in the 'case' part of the switch statement
        /// 3. For each data type, return a string of exactly format, "Data type => <type>" 
        /// 4. For example, an 'int' data type will return ,"Data type => int",
        /// 5. A 'ulong' data type will return "Data type => ulong",
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string PrintValues(object obj)
        {
           Type type = obj.GetType();
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:
                    return "Data type => byte";
                case TypeCode.Empty:
                    return "Data type => empty";
                case TypeCode.Object:
                    return "Data type => object";
                case TypeCode.DBNull:
                    return "Data type => DBNull";
                case TypeCode.Boolean:
                    return "Data type => bool";
                case TypeCode.Char:
                    return "Data type => char";
                case TypeCode.SByte:
                    return "Data type => sbyte";
                case TypeCode.Int16:
                    return "Data type => short";
                case TypeCode.UInt16:
                    return "Data type => ushort";
                case TypeCode.Int32:
                    return "Data type => int";
                case TypeCode.UInt32:
                    return "Data type => uint";
                case TypeCode.Int64:
                    return "Data type => long";
                case TypeCode.UInt64:
                    return "Data type => ulong";
                case TypeCode.Single:
                    return "Data type => float";
                case TypeCode.Double:
                    return "Data type => double";
                case TypeCode.Decimal:
                    return "Data type => decimal";
                case TypeCode.DateTime:
                    return "Data type => datetime";
                case TypeCode.String:
                    return "Data type => string";
            }
            return "Data type => <type>";
        }

        /// <summary>
        /// THis method has a string parameter.
        /// 1. Use the .TryParse() method of the Int32 class (Int32.TryParse()) to convert the string parameter to an integer. 
        /// 2. You'll need to investigate how .TryParse() and 'out' parameters work to implement the body of StringToInt().
        /// 3. If the string cannot be converted to a integer, return 'null'. 
        /// 4. Investigate how to use '?' to make non-nullable types nullable.
        /// </summary>
        /// <param name="numString"></param>
        /// <returns></returns>
        public static int? StringToInt(string numString)
        {
            int numToString;
            bool stringtoInt = Int32.TryParse(numString, out numToString);
            if(stringtoInt == false)  { return null; }
            return numToString;
        }
    }// end of class
}// End of Namespace
