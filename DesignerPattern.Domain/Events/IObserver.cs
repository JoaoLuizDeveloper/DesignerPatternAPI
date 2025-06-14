namespace DesignerPattern.Domain.Events
{
    public interface IObserver
    {
        void Update(string eventData);
    }
}