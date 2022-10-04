namespace FluentTime.Internal;

internal sealed record DateTimeIsDelclarationInitial(DateTime DateTime, double Value) :
    IDateTimeIsAtLeastInitial,
    IDateTimeIsWithinInitial,
    IDateTimeIsExactlyInitial;

internal sealed record DateTimeIsDeclaration(DateTime DateTime, TimeMeasurement Value) :
    IDateTimeIsAtLeast,
    IDateTimeIsWithin,
    IDateTimeIsExactly;