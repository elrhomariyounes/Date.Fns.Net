Date Fns .Net
================


[![NuGet][nuget-badge]][nuget]

[nuget]: https://www.nuget.org/packages/Date.Fns.Net/0.2.0
[nuget-badge]: https://img.shields.io/badge/nuget-v0.2.0-blue?style=flat-square
[date-fns]:https://date-fns.org/

This is a .Net Wrapper for [date-fns] Javascript library to be used with Blazor WASM and Server.

The methods have the same signature as the Javascript library so for more documentation you can check it at [date-fns]

## Install

Install the [Package][nuget] from Nuget.org

```
$ dotnet add package Date.Fns.Net --version 0.2.0
```

## Usage

### Blazor WebAssembly
1. Register of the dependency in a service container. In the Program.cs
```csharp
public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            //Add the below line
            builder.Services.AddDateService(); /*Add this line*/
            await builder.Build().RunAsync();
        }
    }
```
2. In the index.html file located at wwwroot folder, add the following line
```html
 <script src="_content/Date.Fns.Net/date-fns.js"></script>
```
3. In your Imports.razor add this two lines :
```csharp
@using Date.Fns.Net
@using Date.Fns.Net.Services
```
4. Now you can inject the IDateService into your components and call the available date methods like this :
```csharp
var distance = await IDateService.FormatDistance(DateTime.Now, new DateTime(2000,9,15));
```

### Blazor Server

1. Register of the dependency in a service container. In the Startup.cs add the same line to register the service
```csharp
    services.AddDateService(); /*Add this line*/
```
2. Add the same line into your _Host.cshtml file to link date-fns.js file to the project :
```html
 <script src="_content/Date.Fns.Net/date-fns.js"></script>
```

3. In your Imports.razor add this two lines :
```csharp
@using Date.Fns.Net
@using Date.Fns.Net.Services
```

## Contributing

Any help or ideas are welcome. The project is still in progress trying to wrap more date-fns functions.

Thank you very much.