namespace PortfolioApplication.Models;

public record User(
    string FirstName,
    string LastName,
    DateOnly BirthDate,
    string? OtherName,
    string? Picture,
    string? Bio);