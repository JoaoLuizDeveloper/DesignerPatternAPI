using DesignerPattern.Domain.Events;
using DesignerPattern.Infrastructure.Services;

namespace DesignerPattern.Infrastructure.Notifications
{
    public class SmsNotifier : IObserver
    {
        public void Update(string eventData)
        {
            Logger.Instance.Log($"SMS sent: {eventData}");
        }
    }
}
