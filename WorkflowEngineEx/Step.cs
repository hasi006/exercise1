using System;

namespace WorkflowEngineEx
{
    public class Step : ITask
    {
        private readonly string stepName;

        public Step(string stepName)
        {
            if (string.IsNullOrEmpty(stepName))
            {
                throw new ArgumentException("message", nameof(stepName));
            }

            this.stepName = stepName;
        }


        public void Execute()
        {
            Console.WriteLine($"STEP:{stepName} is runing..");
        }
    }
}
