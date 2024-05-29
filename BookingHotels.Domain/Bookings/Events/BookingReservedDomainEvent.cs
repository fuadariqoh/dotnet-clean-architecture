namespace BookingHotels.Domain;

public record BookingReservedDomainEvent(Guid BookingId) : IDomainEvent;

