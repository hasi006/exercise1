using System;

namespace WorkflowEngineEx
{
    public class Activitie:ITask
    {
        private readonly string _activityName;

        public Activitie(string activityName)
        {
            if (string.IsNullOrEmpty(activityName))
            {
                throw new ArgumentException("message", nameof(activityName));
            }

            this._activityName = activityName;
        }

        public void Execute()
        {
            Console.WriteLine($"ACTIVITY:{_activityName} is runing..");
        }
    }
}
