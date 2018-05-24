namespace ShipManagementService.Core.Messaging
{
    public enum MessageTypes
    {
        Unknown,
        ServiceRequested,
        ShipUndockRequested,
        ShipNearingHarbor,
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
