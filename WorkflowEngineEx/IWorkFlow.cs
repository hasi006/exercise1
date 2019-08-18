using System.Collections.Generic;

namespace WorkflowEngineEx
{
    public interface IWorkFlow
    {
        void Add(ITask task);
        void Remove(ITask task);

        IEnumerable<ITask> GetTasks();
    }
}
