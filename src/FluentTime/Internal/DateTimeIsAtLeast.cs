namespace FluentTime.Internal;
internal sealed record DateTimeIsAtLeast(IDateTimeIs Is, double Number) : IDateTimeIsAtLeast;