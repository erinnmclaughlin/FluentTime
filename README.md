# FluentTime
A fluent interface for working with `DateTime`

```csharp
public class ExpirationDateService
{
    public DateTime ExpirationDate { get; set; }

    public bool IsExpired()
    {
        return DateTime.Now.IsAfter(expirationDate);
    }

    public bool IsAlmostExpired()
    {
        return !IsExpired() && expirationDate.IsWithin(48).Hours.Of(DateTime.Now);
    }
}
```
