# FluentTime
A fluent interface for working with `DateTime`

```csharp
public class ExpirationDateService
{
    public DateTime ExpirationDate { get; set; }

    public bool IsExpired()
    {
        return Currently.It.IsBefore(expirationDate);
    }

    public bool IsExpiringSoon()
    {
        return !IsExpired() && expirationDate.IsWithin(48).Hours.Of(DateTime.Now);
    }
}
```
