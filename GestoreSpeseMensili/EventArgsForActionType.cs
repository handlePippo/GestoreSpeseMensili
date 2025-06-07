using System;

namespace MonthExpenseManager
{
    public sealed class EventArgsForActionType : EventArgs
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public EventArgsForActionType()
        {

        }
    }
}