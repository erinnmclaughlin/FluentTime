namespace FluentTime;

public interface IDateTimeIsExactlyExpression
{
    bool After(DateTime other);
    bool Before(DateTime other);
}
