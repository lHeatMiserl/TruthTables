﻿namespace TruthTables
{
    class F16 : TableResult
    {
        protected override void SetResult(bool x, bool y)
        {
            result = true;
        }
        public override bool GetTable(bool x, bool y)
        {
            SetResult(x, y);
            return result;
        }
    }
}
