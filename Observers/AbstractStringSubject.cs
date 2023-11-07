using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Observers
{
    public abstract class AbstractStringSubject :ISubject<AbstractStringSubject>
    {
        private readonly ISet<IObserver<AbstractStringSubject>> _observers;

        private string item;
        public string Item
        {
            get => item;
            protected set
            {
                item = value;
                foreach(var obs in _observers)
                {
                    obs.Update(this);
                }
            }
        }

        protected AbstractStringSubject()
        {
            _observers = new HashSet<IObserver<AbstractStringSubject>>();
        }

        public void RegisterObserver(IObserver<AbstractStringSubject> obs)
        {
            _observers.Add(obs);
        }

        public void RemoveObserver(IObserver<AbstractStringSubject> obs)
        {
            _observers.Remove(obs);
        }
    }
}