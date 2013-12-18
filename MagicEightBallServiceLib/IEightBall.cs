using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
//added in github website
//wljalajdfdfddddddddd
//this is add in master branch
//now must commit before switch branch
namespace MagicEightBallServiceLib
{   [ServiceContract]
    interface IEightBall
    {
    [OperationContract]
    string ObtainAnswerToQuestion(string userQuestion);
    }
}
