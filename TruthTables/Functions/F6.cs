﻿namespace TruthTables
{
    class F6 : TableResult
    {
        protected override void SetResult(bool x, bool y)
        {
            result = (y);
        }

        public override bool GetTable(bool x, bool y)
        {
            SetResult(x, y);
            return result;
        }
    }
}
