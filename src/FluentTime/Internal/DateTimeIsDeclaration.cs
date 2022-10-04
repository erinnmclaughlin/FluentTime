namespace FluentTime.Internal;

internal sealed record DateTimeIsDelclarationInitial(DateTime DateTime, double Value) :
    IDateTimeIsAtLeastInitial,
    IDateTimeIsWithinInitial;

internal sealed record DateTimeIsDeclaration(DateTime DateTime, TimeMeasurement Value) :
    IDateTimeIsAtLeast,
    IDateTimeIsWithin;