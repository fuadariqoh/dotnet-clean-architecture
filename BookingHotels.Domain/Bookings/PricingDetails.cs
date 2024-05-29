using BookingHotels.Domain.Apartments;

namespace BookingHotels.Domain;

public record PricingDetails(
    Money PriceForPeriod,
    Money CleaningFee,
    Money AmenitiesUpCharge,
    Money TotalPrice
);

