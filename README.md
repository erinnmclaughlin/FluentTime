# FluentTime
A fluent wrapper around `DateTime`

```csharp
public class ExpirationDateService
{
    public DateTime ExpirationDate { get; set; }

    public bool IsExpired()
    {
        return Currently.It.IsAfter(ExpirationDate);
    }
    
    public bool IsAlmostExpired()
    {
        return Currently.It.IsBefore(ExpirationDate) && ExpirationDate.IsWithin(48).Hours;
    }

    public bool IsVeryExpired()
    {
        return Currently.It.IsAtLeast(7).Days.After(ExpirationDate);
    }
    
    public bool IsExpiredAsOf(DateTime dateToCheck)
    {
        return dateToCheck.IsAfter(dateToCheck);
    }

    public bool IsAlmostExpiredAsOf(DateTime dateToCheck)
    {
        return dateToCheck.IsBefore(ExpirationDate) && ExpirationDate.IsWithin(48).Hours.Of(dateToCheck);
    }
}
```

TODO:

NuGet package coming soon!
