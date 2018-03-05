using System;

namespace TaskImportance.Tasks
{
    public class SleepTask : Task
    {
        public SleepTask(RationalAgent agent) : base("Sleep", 0, agent) {
            childActions.Add(new ActionItem("Move to bed"));
            childActions.Add(new ActionItem("Fold back covers"));
            childActions.Add(new ActionItem("Get into bed"));
            childActions.Add(new ActionItem("Fall asleep"));
        }

        protected override void CalculatePriority () {
            // parentAgent;
        }

        public override void Act() {
            LogActions();

            parentAgent.sleep = 100;

            System.Threading.Thread.Sleep(3000);
        }



    }
}