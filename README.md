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
        return Currently.It.Is(7).OrMore.Days.After(ExpirationDate);
    }
    
    public bool IsExpiredAsOf(DateTime dateToCheck)
    {
        return dateToCheck.IsAfter(ExpirationDate);
    }

    public bool IsAlmostExpiredAsOf(DateTime dateToCheck)
    {
        return dateToCheck.IsBefore(ExpirationDate) && dateToCheck.IsWithin(48).Hours.Of(ExpirationDate);
    }
}
```

TODO:

NuGet package coming soon!
