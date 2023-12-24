# FluentTime
A fluent interface for working with `DateTime`

```csharp
public class ExpirationDateService
{
    public DateTime ExpirationDate { get; set; }

    public bool IsExpired()
    {
        return ExpirationDate.IsInThePast();
    }

    public bool IsExpiringSoon()
    {
        return !IsExpired() && ExpirationDate.IsWithin(48).Hours;
    }

    public bool IsReallyExpired()
    {
        return Currently.It.IsAtLeast(7).Days.After(ExpirationDate);
    }
}
```
