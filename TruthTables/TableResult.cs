namespace TruthTables
{
    abstract class TableResult
    {
        protected bool result;

        protected abstract void SetResult(bool x, bool y);

        public abstract bool GetTable(bool x, bool y);
    }
}
