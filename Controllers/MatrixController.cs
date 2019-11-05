using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SibiliTest.Models;//we include this in order to have acces to the member variables of MatrixModel Class

namespace SibiliTest.Controllers
{
    public class MatrixController : Controller
    {
        
        public ActionResult GetMatrixDetails()
        {
           
            return View();
        }

        public ActionResult SetMatrixDetails(int Xdimention, int Ydimention, int? FormatNumber)
        /*this Function will receive the 3 arguments (int Xdimention, int Ydimention, int? FormatNumber)  fromm the view  GetMatrixDetails.cshtml
          to be set at the SetMatrixDetails.cshtml (
         Note:'int?' means that the FormatNumber is null able: FormatNumber can be--> int? FormatNumber=null is ok; !! if is not used--> int FormatNumber=null not ok*/
        {
            MatrixModel matrixObj = new MatrixModel();//MatrixModel object that will be passed to the SetMatrixDetails.cshtml view in order to display the values on it!


            if (FormatNumber == null)//if the formatNumber is Null (not selected) will set the value to 0
            {
                matrixObj.FormatNumber = 0;
            }

            matrixObj.Xdimention = Xdimention;//Passing the value to the MatrixModel object "matrixObj"

            matrixObj.Ydimention = Ydimention;//Passing the value to the MatrixModel object "matrixObj"

            matrixObj.FormatNumber = Convert.ToInt32(FormatNumber);//Implicity convertion is not possible ! int?  to int! ,cast( Convert.ToInt32)  is used instead

            return View(matrixObj);//Passing the MatrixModel object  to the SetMatrixDetails.cshtml view 

        }

    }
}