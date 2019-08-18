using System;
using System.Collections.Generic;

namespace WorkflowEngineEx
{
    public class WorkFlow : IWorkFlow
    {
        private readonly IList<ITask> _tasks;

        public WorkFlow()
        {
            this._tasks = new List<ITask>();
        }

        public IList<ITask> Tasks
        {
            get { return _tasks; }
        }


        public void Add(ITask task)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            _tasks.Add(task);
        }

        
        public void Remove(ITask task)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            _tasks.Remove(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }

    }
}
