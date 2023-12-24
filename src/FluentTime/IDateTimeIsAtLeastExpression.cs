namespace FluentTime;

public interface IDateTimeIsAtLeastExpression
{
    bool After(DateTime other);
    bool Before(DateTime other);
}
