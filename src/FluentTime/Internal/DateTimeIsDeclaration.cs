namespace FluentTime.Internal;

internal sealed record DateTimeIsDelclaration(DateTime DateTime, double Value) :
    IDateTimeIsAtLeast,
    IDateTimeIsWithin;