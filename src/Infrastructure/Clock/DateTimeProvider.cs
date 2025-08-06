using ConveApp.Application.Abstractions.Clock;

namespace ConveApp.Infrastructure.Clock;

internal sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
