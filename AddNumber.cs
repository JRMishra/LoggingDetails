using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLogProject
{
    class AddNumber
    {
        NLog nLog = new NLog();
        public int Sum(int firstNumber , int secondNumber)
        {
            if(firstNumber ==0 || secondNumber ==0)
            {
                nLog.LogDebug("Debug Unsuccessfull : Sum()");
                nLog.LogError("Expecting null values");
                nLog.LogWarn("a or b should not equal to 0");
            }
            int sum = firstNumber + secondNumber;
            nLog.LogDebug("Debug Successfull : Sum()");
            nLog.LogInfo("Sum Method passed, Result " + sum);
            return sum;
        }
    }
}
