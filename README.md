# UserFormApp

A Blazor Web App with a reusable form component for collecting user information.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Build and Run

```bash
git clone <repository-url>
cd UserFormApp
dotnet run
```

Open the URL shown in the terminal output (e.g. `http://localhost:5085`).

## Project Structure

```
UserFormApp/
├── Components/
│   ├── Layout/
│   ├── Pages/
│   │   └── UserFormPage.razor       # Parent page that uses the component
│   └── UserForm.razor               # Reusable form component
├── Models/
│   └── UserModel.cs                 # Data model with DataAnnotations
├── Services/
│   ├── IEmailValidationService.cs
│   └── EmailValidationService.cs    # Mocked email uniqueness check
├── Program.cs
└── README.md
```

## Notes

- The `UserForm` component accepts a `UserModel` via parameter and exposes an `EventCallback` for submission. Business logic stays in the parent.
- The component clones the input model internally to support both Create and Edit without mutating the original.
- The Email field is bound manually (no `@bind`) to allow an async uniqueness check on change.
- `test@test.com` and `admin@example.com` are treated as taken emails for testing purposes.
- Age is nullable (`int?`) to avoid defaulting to 0 on new entries.
