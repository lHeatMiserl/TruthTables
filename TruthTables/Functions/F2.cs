﻿namespace TruthTables
{
    class F2 : TableResult
    {
        protected override void SetResult(bool x, bool y)
        {
            result = (x & y);
        }

        public override bool GetTable(bool x, bool y)
        {
            SetResult(x, y);
            return result;
        }
    }
}
