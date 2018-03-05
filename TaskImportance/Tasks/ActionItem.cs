using System;

namespace TaskImportance
{
    public class ActionItem
    {
        
        protected string actionDescription;
        
        public ActionItem(string actionDescription)
        {
            this.actionDescription = actionDescription;
        }

        public string Perform() {
            return actionDescription;
        }
    }
}