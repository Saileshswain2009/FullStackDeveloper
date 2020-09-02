using System;
using System.Net.Security;

namespace EventBasic1
{
    public class SimpleEvent
    {
        public SimpleEvent(string text) { Text = text; }
        public string Text { get; }
    }
    class Publisher
    {
        public delegate void SampleEventHandler(object sender, SimpleEvent e);

        public event SampleEventHandler SimpleEvent;

        // Wrap the event in a protected virtual method
        // to enable derived classes to raise the event.
        protected virtual void RaiseSampleEvent()
        {
            SimpleEvent?.Invoke(this, new SimpleEvent("Welcome"));
        }
    }
}
