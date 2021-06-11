# jsonyte-aspnetcore

[![Docs](https://img.shields.io/badge/docs-wiki-blue.svg?style=for-the-badge)](https://github.com/jsonyte/jsonyte/wiki) [![NuGet](https://img.shields.io/nuget/v/Jsonyte.AspNetCore?style=for-the-badge)](https://www.nuget.org/packages/Jsonyte.AspNetCore) [![Discussions](https://img.shields.io/badge/DISCUSS-ON%20GITHUB-yellow?style=for-the-badge)](https://github.com/jsonyte/jsonyte/discussions) [![License](https://img.shields.io/github/license/jsonyte-aspnetcore/jsonyte?style=for-the-badge)](https://github.com/jsonyte/jsonyte-aspnetcore/blob/master/LICENSE)

An ASP.NET Core implementation of the JSON:API specification using Jsonyte and `System.Text.Json`.

## Usage
Install the package from NuGet with `dotnet add package Jsonyte.AspNetCore`.

For your ASP.NET Core application, simply add the following to the startup:

```csharp
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services
            .AddControllers()
            .AddJsonOptions(x => x.JsonSerializerOptions.AddJsonApi());
    }
}
```

## Documentation
See the [wiki](https://github.com/jsonyte/jsonyte/wiki) for examples and help using Jsonyte.

## Get in touch
Discuss with us on [Discussions](https://github.com/jsonyte/jsonyte/discussions), or raise an [issue](https://github.com/jsonyte/jsonyte/issues).

[![Discussions](https://img.shields.io/badge/DISCUSS-ON%20GITHUB-yellow?style=for-the-badge)](https://github.com/jsonyte/jsonyte/discussions)

## Contributing
Please read [CONTRIBUTING.md](CONTRIBUTING.md) for details on how to contribute to this project.

## License
Jsonyte is released under the [MIT License](LICENSE)