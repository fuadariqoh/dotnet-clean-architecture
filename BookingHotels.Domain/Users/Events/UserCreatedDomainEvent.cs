namespace BookingHotels.Domain;

public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;



