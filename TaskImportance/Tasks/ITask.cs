namespace TaskImportance.Tasks
{
    public interface ITask
    {
        ushort UpdatePriority();
        void CalculatePriority();
    }
}