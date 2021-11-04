namespace TruthTables
{
    class NegateVariableX : TableResult
    {
        protected override void SetResult(bool x, bool y)
        {
            result = (!x);
        }

        public override bool GetTable(bool x, bool y)
        {
            SetResult(x, y);
            return result;
        }
    }
}
