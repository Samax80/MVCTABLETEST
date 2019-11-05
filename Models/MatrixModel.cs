using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SibiliTest.Models
{
    public class MatrixModel
    {

                
        public int Xdimention { get; set; }
        public int Ydimention { get; set; }
        public string color { get; set; }
        public string font { get; set; }
        public int FormatNumber { get; set; }//will hold the selected format (Binary,Hex, or Decimal)


        /*This functions will be  used at the  SetMatrixDetails.cshtml view to convert the number to the selected format */
        public string ToBinary(int MyNumber)
        {
            Int64 myDecimal = Convert.ToInt64(MyNumber);

            Int64 BinaryHolder;
            char[] BinaryArray;
            string BinaryResult = "";

            while (myDecimal > 0)
            {
                BinaryHolder = myDecimal % 2;
                BinaryResult += BinaryHolder;
                myDecimal = myDecimal / 2;
            }

            BinaryArray = BinaryResult.ToCharArray();
            Array.Reverse(BinaryArray);
            BinaryResult = new string(BinaryArray);

            return BinaryResult;

        }/**/

        public string ToHex(int MyNumber)

        {

            string hexValue = MyNumber.ToString("X");
            
            return hexValue;
        }

        public Decimal ToDecimal(int MyNumber)

        {

            decimal decimalvalue = (Convert.ToDecimal(MyNumber));

            return decimalvalue;

        }


        /*
         FUNCTION TO BE IMPLEMENTED FOR :(Optional) – color the background of the Prime numbers.
          public static bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= boundary; i+=2)
        if (number % i == 0)
            return false;

    return true;        
}*/


    }
}