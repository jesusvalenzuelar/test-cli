# Qodyq Analysis Summary

- **Branch:** `development`
- **Status:** ❌ FAIL
- **Generated:** 2026-05-01 19:31:06 UTC
- **Files analyzed:** 6
- **Violations:** 8

## Git Information

| Field | Value |
|-------|-------|
| Current Branch | `development` |
| Base Branch | `main` |
| HEAD Commit | `4d21165` — Initial commit |
| Total Lines Changed | 185 |

### Delta

| File | Status | Hunks | Lines |
|------|--------|-------|-------|
| `INotification.cs` | Added | 1 | 13 |
| `Program.cs` | Added | 1 | 2 |
| `SMSNotification.cs` | Added | 1 | 35 |
| `TestSample.cs` | Added | 1 | 58 |
| `CliTests.cs` | Added | 1 | 14 |
| `SMSNotificationTests.cs` | Added | 1 | 63 |

### Recent Commits

| SHA | Message | Author | When |
|-----|---------|--------|------|
| `4d21165` | Initial commit | Jesus Gilberto Valenzuela Rochin | 2026-05-01 10:35 |

## Test Coverage

- **Test files found:** 4
- **Public methods in delta:** 3
- **Covered:** 1
- **Uncovered:** 2
- **Coverage estimate:** 33.3%

### Test Files
- `CliTests.cs`
- `SMSNotificationTests.cs`
- `AssemblyInfo.cs`
- `.NETFramework,Version=v4.7.2.AssemblyAttributes.cs`

### Methods Without Tests

#### `TestSample.cs` › `TestSample`

| Method | Line | Suggested Test Name |
|--------|------|---------------------|
| `FetchData` | 20 | `FetchData_WhenCalled_ShouldReturnExpectedResult` |
| `ProcessEverything` | 27 | `ProcessEverything_WhenCalled_ShouldReturnExpectedResult` |

## Analyzed Files
- `INotification.cs`
- `Program.cs`
- `SMSNotification.cs`
- `TestSample.cs`
- `CliTests.cs`
- `SMSNotificationTests.cs`

## Violations
### [Warning] AsyncSuffix — `INotification.cs` (line 11)
> Method 'Notify' returns Task but does not end with 'Async'.

```csharp
Task Notify(string sender, string message, string recipient);
    }
}
```

💡 **AI Hint:** Rename the method to end with 'Async' (e.g., `NotifyAsync`) to follow .NET async naming conventions and improve discoverability.

### [Warning] AsyncSuffix — `SMSNotification.cs` (line 13)
> Method 'Notify' returns Task but does not end with 'Async'.

```csharp
public async Task Notify(string sender, string message, string recipient)
        {
            if (string.IsNullOrWhiteSpace(sender))
                throw new ArgumentException("Sender cannot be null or empty.", nameof(sender));
```

💡 **AI Hint:** Rename the method to end with 'Async' (e.g., `NotifyAsync`) to follow .NET async naming conventions and improve discoverability.

### [Warning] MissingAccessModifier — `TestSample.cs` (line 12)
> Method 'DoSomething' is missing an explicit access modifier.

```csharp
void DoSomething()
        {
            Console.WriteLine("line 1");
            Console.WriteLine("line 2");
            Console.WriteLine("line 3");
```

💡 **AI Hint:** Add an explicit access modifier (e.g., `private`, `public`, `internal`) to make intent clear and avoid relying on default visibility.

### [Warning] AsyncSuffix — `TestSample.cs` (line 20)
> Method 'FetchData' returns Task but does not end with 'Async'.

```csharp
public async Task FetchData()
        {
            await Task.Delay(100);
            Console.WriteLine("fetching...");
        }
```

💡 **AI Hint:** Rename the method to end with 'Async' (e.g., `FetchDataAsync`) to follow .NET async naming conventions and improve discoverability.

### [Error] MaxMethodLines — `TestSample.cs` (line 28)
> Method 'ProcessEverything' has 29 lines (max: 25).

```csharp
public void ProcessEverything()
        {
            Console.WriteLine("step 1");
            Console.WriteLine("step 2");
            Console.WriteLine("step 3");
```

💡 **AI Hint:** Consider extracting logic into smaller private methods following the Single Responsibility Principle. Each method should do one thing and do it well.

### [Warning] AsyncSuffix — `SMSNotificationTests.cs` (line 12)
> Method 'Notify_InvalidSender_ThrowsArgumentException' returns Task but does not end with 'Async'.

```csharp
[DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("   ")]
        public async Task Notify_InvalidSender_ThrowsArgumentException(string sender)
```

💡 **AI Hint:** Rename the method to end with 'Async' (e.g., `Notify_InvalidSender_ThrowsArgumentExceptionAsync`) to follow .NET async naming conventions and improve discoverability.

### [Warning] AsyncSuffix — `SMSNotificationTests.cs` (line 29)
> Method 'Notify_InvalidMessage_ThrowsArgumentException' returns Task but does not end with 'Async'.

```csharp
[DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("   ")]
        public async Task Notify_InvalidMessage_ThrowsArgumentException(string message)
```

💡 **AI Hint:** Rename the method to end with 'Async' (e.g., `Notify_InvalidMessage_ThrowsArgumentExceptionAsync`) to follow .NET async naming conventions and improve discoverability.

### [Warning] AsyncSuffix — `SMSNotificationTests.cs` (line 46)
> Method 'Notify_InvalidRecipient_ThrowsArgumentException' returns Task but does not end with 'Async'.

```csharp
[DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("   ")]
        public async Task Notify_InvalidRecipient_ThrowsArgumentException(string recipient)
```

💡 **AI Hint:** Rename the method to end with 'Async' (e.g., `Notify_InvalidRecipient_ThrowsArgumentExceptionAsync`) to follow .NET async naming conventions and improve discoverability.

