using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
//added in github website
//wljalajdfdfddddddddd
//wlj:真的很强大
namespace MagicEightBallServiceLib
{   [ServiceContract]
    interface IEightBall
    {
    [OperationContract]
    string ObtainAnswerToQuestion(string userQuestion);
    }
}
