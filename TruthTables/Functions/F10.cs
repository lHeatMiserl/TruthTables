﻿namespace TruthTables
{
    class F10 : TableResult
    {
        protected override void SetResult(bool x, bool y)
        {
            result = ((x & y) || (!x & !y));
        }

        public override bool GetTable(bool x, bool y)
        {
            SetResult(x, y);
            return result;
        }
    }
}
