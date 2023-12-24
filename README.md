# FluentTime
A fluent wrapper around `DateTime`

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

TODO:

NuGet package coming soon!
