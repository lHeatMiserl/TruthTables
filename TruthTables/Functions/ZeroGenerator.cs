namespace TruthTables
{
    class ZeroGenerator : TableResult
    {
        protected override void SetResult(bool x, bool y)
        {
            result = false;
        }

        public override bool GetTable(bool x, bool y)
        {
            SetResult(x, y);
            return result;
        }
    }
}
