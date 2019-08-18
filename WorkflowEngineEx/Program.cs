namespace WorkflowEngineEx
{

    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new WorkFlow();
            workflow.Add(new Activitie("Activity 1"));
            workflow.Add(new Step("Step 1"));
            workflow.Add(new Activitie("Activity 2"));
            workflow.Add(new Step("Step 2"));

            WorkflowEngine workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }
    }
}
