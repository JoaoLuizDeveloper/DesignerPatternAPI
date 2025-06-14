using DesignerPattern.Domain.Events;
using DesignerPattern.Infrastructure.Services;

namespace DesignerPattern.Infrastructure.Notifications
{
    public class EmailNotifier : IObserver
    {
        public void Update(string eventData)
        {
            Logger.Instance.Log($"Email sent: {eventData}");
        }
    }
}
