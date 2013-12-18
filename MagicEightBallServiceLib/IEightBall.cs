using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
//added in github website
<<<<<<< HEAD
//wljalajdfdfddddddddd
//wlj:真的很强大
=======
>>>>>>> parent of f43dc54... tetteetete
namespace MagicEightBallServiceLib
{   [ServiceContract]
    interface IEightBall
    {
    [OperationContract]
    string ObtainAnswerToQuestion(string userQuestion);
    }
}
