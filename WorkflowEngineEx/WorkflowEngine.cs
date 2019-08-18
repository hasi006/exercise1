namespace WorkflowEngineEx
{
    public class WorkflowEngine
    {
        public void Run(IWorkFlow workflow)
        {
            foreach (var activity in workflow.GetTasks())
                activity.Execute();
        }

        
    }
}
