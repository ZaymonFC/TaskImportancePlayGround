using System;
using System.Collections.Generic;

namespace TaskImportance
{
    public class Task {

        protected string taskName;
        protected RationalAgent parentAgent;

        public ushort priority { get; }

        protected List<ActionItem> childActions;

        public Task (string taskName, ushort initialPriority, RationalAgent parentAgent) {
            this.taskName = taskName;
            this.priority = initialPriority;
            this.parentAgent = parentAgent;
            childActions = new List<ActionItem>();
        }

        public void UpdatePriority() {
            CalculatePriority();
        }

        protected virtual void CalculatePriority() { }

        public virtual void Act() { }

        protected void LogActions() {
            foreach(ActionItem action in childActions) {
                LogSingle(action.Perform());
                System.Threading.Thread.Sleep(300);
            }
        }

        protected void LogSingle(string action) {
            Console.WriteLine($"[{parentAgent.name}]: {action}");
        }
    }
}

