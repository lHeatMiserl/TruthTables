using System;

namespace TruthTables
{
    class Calculator
    {
        public static int CalculateValue(TableResult logicFunction, int x, int y)
        {
            return Convert.ToInt32(logicFunction.GetTable(Convert.ToBoolean(x), Convert.ToBoolean(y)));
        }
    }
}
