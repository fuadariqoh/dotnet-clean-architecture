using BookingHotels.Domain.Apartments;

namespace BookingHotels.Domain;

public interface IApartmentRepository
{
    Task<Apartment?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
