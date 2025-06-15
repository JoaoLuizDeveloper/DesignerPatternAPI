using DesignerPattern.Domain.Events;

namespace DesignerPattern.Application.Events
{
    public class PaymentSubject
    {
        private readonly List<IObserver> _observers = new();

        // Adiciona um novo observador à lista dos observadores
        public void Attach(IObserver observer) => _observers.Add(observer);

        // Notifica os observadores
        public void Notify(string message)
        {
            foreach (var obs in _observers)
                obs.Update(message);
        }
    }
}