namespace ShipManagementService.Core.Messaging
{
    public enum MessageTypes
    {
        Unknown,
        ServiceRequested,
        CustomerCreated,
        CustomerUpdated,
        CustomerDeleted,
        ShipDocked,
        ShipUndocked,
        ServiceCreated,
        ServiceUpdated,
        ServiceDeleted
    }
}
