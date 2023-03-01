using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Observer
{
    public class Publisher
    {
        private IList<ISubscriber<BaseMessage>> _subscribers;

        public Publisher()
        {
            _subscribers = new List<ISubscriber<BaseMessage>>();
        }

        public void Subscribe(ISubscriber<BaseMessage> subs)
        {
            _subscribers.Add(subs);
        }
        public void Unsubscribe(ISubscriber<BaseMessage> subs)
        {
            _subscribers.Remove(subs);
        }

        public void NotifyAllSubscribers(BaseMessage message)
        {
            foreach (var item in _subscribers)
            {
                item.Update(message);
            }
        }

    }
}
