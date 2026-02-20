# Diff Details

Date : 2026-02-17 11:23:11

Directory /Users/althaf/Desktop/LaundrySolution/src

Total : 146 files,  166 codes, 7 comments, 35 blanks, all 208 lines

[Summary](results.md) / [Details](details.md) / [Diff Summary](diff.md) / Diff Details

## Files
| filename | language | code | comment | blank | total |
| :--- | :--- | ---: | ---: | ---: | ---: |
| [Laundry.slnx](/Laundry.slnx) | XML | -10 | 0 | -1 | -11 |
| [README.md](/README.md) | Markdown | -2 | 0 | -1 | -3 |
| [src/Application/Application.csproj](/src/Application/Application.csproj) | XML | 16 | 0 | 5 | 21 |
| [src/Application/DependencyInjection.cs](/src/Application/DependencyInjection.cs) | C# | 14 | 0 | 3 | 17 |
| [src/Domain/Common/DomainExceptions.cs](/src/Domain/Common/DomainExceptions.cs) | C# | 8 | 0 | 0 | 8 |
| [src/Domain/Common/IAggregateRoot.cs](/src/Domain/Common/IAggregateRoot.cs) | C# | 2 | 0 | 0 | 2 |
| [src/Domain/Common/IEntity.cs](/src/Domain/Common/IEntity.cs) | C# | 2 | 0 | 0 | 2 |
| [src/Domain/Common/Result.cs](/src/Domain/Common/Result.cs) | C# | 39 | 0 | 14 | 53 |
| [src/Domain/Common/ValueObject.cs](/src/Domain/Common/ValueObject.cs) | C# | 33 | 0 | 12 | 45 |
| [src/Domain/Domain.csproj](/src/Domain/Domain.csproj) | XML | 7 | 0 | 3 | 10 |
| [src/Domain/Entities/Order.cs](/src/Domain/Entities/Order.cs) | C# | 1 | 0 | 1 | 2 |
| [src/Domain/Errors/ValueObjectErrors/EmailErrors.cs](/src/Domain/Errors/ValueObjectErrors/EmailErrors.cs) | C# | 34 | 0 | 7 | 41 |
| [src/Domain/Errors/ValueObjectErrors/WeightErrors.cs](/src/Domain/Errors/ValueObjectErrors/WeightErrors.cs) | C# | 32 | 0 | 5 | 37 |
| [src/Domain/Exceptions/DomainException.cs](/src/Domain/Exceptions/DomainException.cs) | C# | 8 | 0 | 0 | 8 |
| [src/Domain/Exceptions/InvalidValueObjectState.cs](/src/Domain/Exceptions/InvalidValueObjectState.cs) | C# | 7 | 0 | 1 | 8 |
| [src/Domain/ValueObjects/Email.cs](/src/Domain/ValueObjects/Email.cs) | C# | 56 | 2 | 19 | 77 |
| [src/Domain/ValueObjects/Weight.cs](/src/Domain/ValueObjects/Weight.cs) | C# | 42 | 7 | 16 | 65 |
| [src/Infrastructure/DependencyInjection.cs](/src/Infrastructure/DependencyInjection.cs) | C# | 17 | 5 | 8 | 30 |
| [src/Infrastructure/Identity/ApplicationUser.cs](/src/Infrastructure/Identity/ApplicationUser.cs) | C# | 5 | 0 | 2 | 7 |
| [src/Infrastructure/Infrastructure.csproj](/src/Infrastructure/Infrastructure.csproj) | XML | 24 | 0 | 5 | 29 |
| [src/Infrastructure/Persistance/ApplicationDbContext.cs](/src/Infrastructure/Persistance/ApplicationDbContext.cs) | C# | 8 | 0 | 3 | 11 |
| [src/Infrastructure/Persistance/ApplicationDbContextFactory.cs](/src/Infrastructure/Persistance/ApplicationDbContextFactory.cs) | C# | 0 | 0 | 1 | 1 |
| [src/Infrastructure/RateLimiting/RateLimitConfig.cs](/src/Infrastructure/RateLimiting/RateLimitConfig.cs) | C# | 3 | 0 | 1 | 4 |
| [src/Infrastructure/Services/Bot/workflow/workflow.md](/src/Infrastructure/Services/Bot/workflow/workflow.md) | Markdown | 1 | 0 | 0 | 1 |
| [src/Laundry.Application/DependencyInjection.cs](/src/Laundry.Application/DependencyInjection.cs) | C# | -13 | -2 | -3 | -18 |
| [src/Laundry.Application/Laundry.Application.csproj](/src/Laundry.Application/Laundry.Application.csproj) | XML | -13 | 0 | -4 | -17 |
| [src/Laundry.Domain/Common/IAggregateRoot.cs](/src/Laundry.Domain/Common/IAggregateRoot.cs) | C# | -2 | 0 | 0 | -2 |
| [src/Laundry.Domain/Common/IDomainExceptions.cs](/src/Laundry.Domain/Common/IDomainExceptions.cs) | C# | -2 | 0 | 0 | -2 |
| [src/Laundry.Domain/Common/IEntity.cs](/src/Laundry.Domain/Common/IEntity.cs) | C# | -2 | 0 | 0 | -2 |
| [src/Laundry.Domain/Common/Result.cs](/src/Laundry.Domain/Common/Result.cs) | C# | -36 | 0 | -14 | -50 |
| [src/Laundry.Domain/Common/ValueObject.cs](/src/Laundry.Domain/Common/ValueObject.cs) | C# | -33 | 0 | -13 | -46 |
| [src/Laundry.Domain/Errors/ValueObjectErrors/EmailErrors.cs](/src/Laundry.Domain/Errors/ValueObjectErrors/EmailErrors.cs) | C# | -14 | 0 | -4 | -18 |
| [src/Laundry.Domain/Laundry.Domain.csproj](/src/Laundry.Domain/Laundry.Domain.csproj) | XML | -7 | 0 | -3 | -10 |
| [src/Laundry.Domain/ValueObjects/Address.cs](/src/Laundry.Domain/ValueObjects/Address.cs) | C# | 0 | 0 | -1 | -1 |
| [src/Laundry.Domain/ValueObjects/DateRange.cs](/src/Laundry.Domain/ValueObjects/DateRange.cs) | C# | 0 | 0 | -1 | -1 |
| [src/Laundry.Domain/ValueObjects/Email.cs](/src/Laundry.Domain/ValueObjects/Email.cs) | C# | -22 | 0 | -8 | -30 |
| [src/Laundry.Domain/ValueObjects/Money.cs](/src/Laundry.Domain/ValueObjects/Money.cs) | C# | 0 | 0 | -1 | -1 |
| [src/Laundry.Domain/ValueObjects/OrderCode.cs](/src/Laundry.Domain/ValueObjects/OrderCode.cs) | C# | 0 | 0 | -1 | -1 |
| [src/Laundry.Domain/ValueObjects/PhoneNumber.cs](/src/Laundry.Domain/ValueObjects/PhoneNumber.cs) | C# | 0 | 0 | -1 | -1 |
| [src/Laundry.Domain/ValueObjects/Weight.cs](/src/Laundry.Domain/ValueObjects/Weight.cs) | C# | 0 | 0 | -1 | -1 |
| [src/Laundry.Infrastructure/DependencyInjection.cs](/src/Laundry.Infrastructure/DependencyInjection.cs) | C# | -12 | -5 | -8 | -25 |
| [src/Laundry.Infrastructure/Laundry.Infrastructure.csproj](/src/Laundry.Infrastructure/Laundry.Infrastructure.csproj) | XML | -24 | 0 | -5 | -29 |
| [src/Laundry.Infrastructure/Persistance/ApplicationDbContext.cs](/src/Laundry.Infrastructure/Persistance/ApplicationDbContext.cs) | C# | -2 | 0 | 0 | -2 |
| [src/Laundry.Infrastructure/Persistance/ApplicationDbContextFactory.cs](/src/Laundry.Infrastructure/Persistance/ApplicationDbContextFactory.cs) | C# | 0 | 0 | -1 | -1 |
| [src/Laundry.Presentation/Laundry.WebApp/Laundry.WebApp.csproj](/src/Laundry.Presentation/Laundry.WebApp/Laundry.WebApp.csproj) | XML | -12 | 0 | -4 | -16 |
| [src/Laundry.Presentation/Laundry.WebApp/Pages/Error.cshtml](/src/Laundry.Presentation/Laundry.WebApp/Pages/Error.cshtml) | ASP.NET Razor | -23 | 0 | -4 | -27 |
| [src/Laundry.Presentation/Laundry.WebApp/Pages/Error.cshtml.cs](/src/Laundry.Presentation/Laundry.WebApp/Pages/Error.cshtml.cs) | C# | -20 | 0 | -8 | -28 |
| [src/Laundry.Presentation/Laundry.WebApp/Pages/Index.cshtml](/src/Laundry.Presentation/Laundry.WebApp/Pages/Index.cshtml) | ASP.NET Razor | -19 | 0 | -4 | -23 |
| [src/Laundry.Presentation/Laundry.WebApp/Pages/Index.cshtml.cs](/src/Laundry.Presentation/Laundry.WebApp/Pages/Index.cshtml.cs) | C# | -14 | 0 | -6 | -20 |
| [src/Laundry.Presentation/Laundry.WebApp/Pages/Privacy.cshtml](/src/Laundry.Presentation/Laundry.WebApp/Pages/Privacy.cshtml) | ASP.NET Razor | -7 | 0 | -2 | -9 |
| [src/Laundry.Presentation/Laundry.WebApp/Pages/Privacy.cshtml.cs](/src/Laundry.Presentation/Laundry.WebApp/Pages/Privacy.cshtml.cs) | C# | -14 | 0 | -6 | -20 |
| [src/Laundry.Presentation/Laundry.WebApp/Pages/Shared/\_Layout.cshtml](/src/Laundry.Presentation/Laundry.WebApp/Pages/Shared/_Layout.cshtml) | ASP.NET Razor | -54 | 0 | -4 | -58 |
| [src/Laundry.Presentation/Laundry.WebApp/Pages/Shared/\_Layout.cshtml.css](/src/Laundry.Presentation/Laundry.WebApp/Pages/Shared/_Layout.cshtml.css) | PostCSS | -38 | -2 | -9 | -49 |
| [src/Laundry.Presentation/Laundry.WebApp/Pages/Shared/\_ValidationScriptsPartial.cshtml](/src/Laundry.Presentation/Laundry.WebApp/Pages/Shared/_ValidationScriptsPartial.cshtml) | ASP.NET Razor | -2 | 0 | -1 | -3 |
| [src/Laundry.Presentation/Laundry.WebApp/Pages/\_ViewImports.cshtml](/src/Laundry.Presentation/Laundry.WebApp/Pages/_ViewImports.cshtml) | ASP.NET Razor | -3 | 0 | -1 | -4 |
| [src/Laundry.Presentation/Laundry.WebApp/Pages/\_ViewStart.cshtml](/src/Laundry.Presentation/Laundry.WebApp/Pages/_ViewStart.cshtml) | ASP.NET Razor | -3 | 0 | -1 | -4 |
| [src/Laundry.Presentation/Laundry.WebApp/Program.cs](/src/Laundry.Presentation/Laundry.WebApp/Program.cs) | C# | -19 | -4 | -12 | -35 |
| [src/Laundry.Presentation/Laundry.WebApp/Properties/launchSettings.json](/src/Laundry.Presentation/Laundry.WebApp/Properties/launchSettings.json) | JSON | -23 | 0 | -1 | -24 |
| [src/Laundry.Presentation/Laundry.WebApp/appsettings.Development.json](/src/Laundry.Presentation/Laundry.WebApp/appsettings.Development.json) | JSON | -9 | 0 | -1 | -10 |
| [src/Laundry.Presentation/Laundry.WebApp/appsettings.json](/src/Laundry.Presentation/Laundry.WebApp/appsettings.json) | JSON | -21 | 0 | -2 | -23 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/css/site.css](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/css/site.css) | PostCSS | -25 | 0 | -6 | -31 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/js/site.js](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/js/site.js) | JavaScript | 0 | -3 | -2 | -5 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.css](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.css) | PostCSS | -3,886 | -6 | -193 | -4,085 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.min.css](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.min.css) | PostCSS | -1 | -5 | 0 | -6 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.css](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.css) | PostCSS | -3,886 | -6 | -192 | -4,084 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.min.css](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.min.css) | PostCSS | -1 | -5 | 0 | -6 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.css](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.css) | PostCSS | -518 | -14 | -65 | -597 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.min.css](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.min.css) | PostCSS | -1 | -5 | 0 | -6 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.css](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.css) | PostCSS | -524 | -6 | -64 | -594 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.min.css](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.min.css) | PostCSS | -1 | -5 | 0 | -6 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.css](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.css) | PostCSS | -4,891 | -8 | -503 | -5,402 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.min.css](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.min.css) | PostCSS | -1 | -5 | 0 | -6 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.css](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.css) | PostCSS | -4,887 | -6 | -500 | -5,393 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.min.css](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.min.css) | PostCSS | -1 | -5 | 0 | -6 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap.css](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap.css) | PostCSS | -11,136 | -24 | -897 | -12,057 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css) | PostCSS | -5 | -1 | 0 | -6 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.css](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.css) | PostCSS | -11,138 | -6 | -886 | -12,030 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.min.css](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.min.css) | PostCSS | -5 | -1 | 0 | -6 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.js](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.js) | JavaScript | -5,064 | -655 | -596 | -6,315 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js) | JavaScript | -1 | -6 | 0 | -7 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.js](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.js) | JavaScript | -3,568 | -578 | -302 | -4,448 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.min.js](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.min.js) | JavaScript | -1 | -6 | 0 | -7 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/js/bootstrap.js](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/js/bootstrap.js) | JavaScript | -3,604 | -584 | -307 | -4,495 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/js/bootstrap.min.js](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/bootstrap/dist/js/bootstrap.min.js) | JavaScript | -1 | -6 | 0 | -7 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.js](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.js) | JavaScript | -306 | -76 | -54 | -436 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js) | JavaScript | -1 | -7 | 0 | -8 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery-validation/LICENSE.md](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery-validation/LICENSE.md) | Markdown | -18 | 0 | -5 | -23 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery-validation/dist/additional-methods.js](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery-validation/dist/additional-methods.js) | JavaScript | -1,106 | -258 | -141 | -1,505 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery-validation/dist/additional-methods.min.js](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery-validation/dist/additional-methods.min.js) | JavaScript | -1 | -3 | 0 | -4 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery-validation/dist/jquery.validate.js](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery-validation/dist/jquery.validate.js) | JavaScript | -1,265 | -188 | -250 | -1,703 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery-validation/dist/jquery.validate.min.js](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery-validation/dist/jquery.validate.min.js) | JavaScript | -1 | -3 | 0 | -4 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery/dist/jquery.js](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery/dist/jquery.js) | JavaScript | -6,767 | -1,887 | -2,063 | -10,717 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery/dist/jquery.min.js](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery/dist/jquery.min.js) | JavaScript | -1 | -1 | -1 | -3 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery/dist/jquery.slim.js](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery/dist/jquery.slim.js) | JavaScript | -5,381 | -1,558 | -1,679 | -8,618 |
| [src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery/dist/jquery.slim.min.js](/src/Laundry.Presentation/Laundry.WebApp/wwwroot/lib/jquery/dist/jquery.slim.min.js) | JavaScript | -1 | -1 | -1 | -3 |
| [src/Presentation/Web/Pages/Error.cshtml](/src/Presentation/Web/Pages/Error.cshtml) | ASP.NET Razor | 23 | 0 | 4 | 27 |
| [src/Presentation/Web/Pages/Error.cshtml.cs](/src/Presentation/Web/Pages/Error.cshtml.cs) | C# | 20 | 0 | 8 | 28 |
| [src/Presentation/Web/Pages/Index.cshtml](/src/Presentation/Web/Pages/Index.cshtml) | ASP.NET Razor | 19 | 0 | 4 | 23 |
| [src/Presentation/Web/Pages/Index.cshtml.cs](/src/Presentation/Web/Pages/Index.cshtml.cs) | C# | 14 | 0 | 6 | 20 |
| [src/Presentation/Web/Pages/Privacy.cshtml](/src/Presentation/Web/Pages/Privacy.cshtml) | ASP.NET Razor | 7 | 0 | 2 | 9 |
| [src/Presentation/Web/Pages/Privacy.cshtml.cs](/src/Presentation/Web/Pages/Privacy.cshtml.cs) | C# | 14 | 0 | 6 | 20 |
| [src/Presentation/Web/Pages/Shared/\_Layout.cshtml](/src/Presentation/Web/Pages/Shared/_Layout.cshtml) | ASP.NET Razor | 54 | 0 | 4 | 58 |
| [src/Presentation/Web/Pages/Shared/\_Layout.cshtml.css](/src/Presentation/Web/Pages/Shared/_Layout.cshtml.css) | PostCSS | 38 | 2 | 9 | 49 |
| [src/Presentation/Web/Pages/Shared/\_ValidationScriptsPartial.cshtml](/src/Presentation/Web/Pages/Shared/_ValidationScriptsPartial.cshtml) | ASP.NET Razor | 2 | 0 | 1 | 3 |
| [src/Presentation/Web/Pages/\_ViewImports.cshtml](/src/Presentation/Web/Pages/_ViewImports.cshtml) | ASP.NET Razor | 3 | 0 | 1 | 4 |
| [src/Presentation/Web/Pages/\_ViewStart.cshtml](/src/Presentation/Web/Pages/_ViewStart.cshtml) | ASP.NET Razor | 3 | 0 | 1 | 4 |
| [src/Presentation/Web/Program.cs](/src/Presentation/Web/Program.cs) | C# | 19 | 4 | 12 | 35 |
| [src/Presentation/Web/Properties/launchSettings.json](/src/Presentation/Web/Properties/launchSettings.json) | JSON | 23 | 0 | 1 | 24 |
| [src/Presentation/Web/Web.csproj](/src/Presentation/Web/Web.csproj) | XML | 13 | 0 | 4 | 17 |
| [src/Presentation/Web/appsettings.Development.json](/src/Presentation/Web/appsettings.Development.json) | JSON | 9 | 0 | 1 | 10 |
| [src/Presentation/Web/appsettings.json](/src/Presentation/Web/appsettings.json) | JSON | 21 | 0 | 2 | 23 |
| [src/Presentation/Web/wwwroot/css/site.css](/src/Presentation/Web/wwwroot/css/site.css) | PostCSS | 25 | 0 | 6 | 31 |
| [src/Presentation/Web/wwwroot/js/site.js](/src/Presentation/Web/wwwroot/js/site.js) | JavaScript | 0 | 3 | 2 | 5 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.css](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.css) | PostCSS | 3,886 | 6 | 193 | 4,085 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.min.css](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.min.css) | PostCSS | 1 | 5 | 0 | 6 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.css](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.css) | PostCSS | 3,886 | 6 | 192 | 4,084 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.min.css](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-grid.rtl.min.css) | PostCSS | 1 | 5 | 0 | 6 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.css](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.css) | PostCSS | 518 | 14 | 65 | 597 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.min.css](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.min.css) | PostCSS | 1 | 5 | 0 | 6 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.css](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.css) | PostCSS | 524 | 6 | 64 | 594 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.min.css](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.min.css) | PostCSS | 1 | 5 | 0 | 6 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.css](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.css) | PostCSS | 4,891 | 8 | 503 | 5,402 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.min.css](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.min.css) | PostCSS | 1 | 5 | 0 | 6 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.css](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.css) | PostCSS | 4,887 | 6 | 500 | 5,393 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.min.css](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap-utilities.rtl.min.css) | PostCSS | 1 | 5 | 0 | 6 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap.css](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap.css) | PostCSS | 11,136 | 24 | 897 | 12,057 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap.min.css) | PostCSS | 5 | 1 | 0 | 6 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.css](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.css) | PostCSS | 11,138 | 6 | 886 | 12,030 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.min.css](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/css/bootstrap.rtl.min.css) | PostCSS | 5 | 1 | 0 | 6 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.js](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.js) | JavaScript | 5,064 | 655 | 596 | 6,315 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/js/bootstrap.bundle.min.js) | JavaScript | 1 | 6 | 0 | 7 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.js](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.js) | JavaScript | 3,568 | 578 | 302 | 4,448 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.min.js](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/js/bootstrap.esm.min.js) | JavaScript | 1 | 6 | 0 | 7 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/js/bootstrap.js](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/js/bootstrap.js) | JavaScript | 3,604 | 584 | 307 | 4,495 |
| [src/Presentation/Web/wwwroot/lib/bootstrap/dist/js/bootstrap.min.js](/src/Presentation/Web/wwwroot/lib/bootstrap/dist/js/bootstrap.min.js) | JavaScript | 1 | 6 | 0 | 7 |
| [src/Presentation/Web/wwwroot/lib/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.js](/src/Presentation/Web/wwwroot/lib/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.js) | JavaScript | 306 | 76 | 54 | 436 |
| [src/Presentation/Web/wwwroot/lib/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js](/src/Presentation/Web/wwwroot/lib/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js) | JavaScript | 1 | 7 | 0 | 8 |
| [src/Presentation/Web/wwwroot/lib/jquery-validation/LICENSE.md](/src/Presentation/Web/wwwroot/lib/jquery-validation/LICENSE.md) | Markdown | 18 | 0 | 5 | 23 |
| [src/Presentation/Web/wwwroot/lib/jquery-validation/dist/additional-methods.js](/src/Presentation/Web/wwwroot/lib/jquery-validation/dist/additional-methods.js) | JavaScript | 1,106 | 258 | 141 | 1,505 |
| [src/Presentation/Web/wwwroot/lib/jquery-validation/dist/additional-methods.min.js](/src/Presentation/Web/wwwroot/lib/jquery-validation/dist/additional-methods.min.js) | JavaScript | 1 | 3 | 0 | 4 |
| [src/Presentation/Web/wwwroot/lib/jquery-validation/dist/jquery.validate.js](/src/Presentation/Web/wwwroot/lib/jquery-validation/dist/jquery.validate.js) | JavaScript | 1,265 | 188 | 250 | 1,703 |
| [src/Presentation/Web/wwwroot/lib/jquery-validation/dist/jquery.validate.min.js](/src/Presentation/Web/wwwroot/lib/jquery-validation/dist/jquery.validate.min.js) | JavaScript | 1 | 3 | 0 | 4 |
| [src/Presentation/Web/wwwroot/lib/jquery/dist/jquery.js](/src/Presentation/Web/wwwroot/lib/jquery/dist/jquery.js) | JavaScript | 6,767 | 1,887 | 2,063 | 10,717 |
| [src/Presentation/Web/wwwroot/lib/jquery/dist/jquery.min.js](/src/Presentation/Web/wwwroot/lib/jquery/dist/jquery.min.js) | JavaScript | 1 | 1 | 1 | 3 |
| [src/Presentation/Web/wwwroot/lib/jquery/dist/jquery.slim.js](/src/Presentation/Web/wwwroot/lib/jquery/dist/jquery.slim.js) | JavaScript | 5,381 | 1,558 | 1,679 | 8,618 |
| [src/Presentation/Web/wwwroot/lib/jquery/dist/jquery.slim.min.js](/src/Presentation/Web/wwwroot/lib/jquery/dist/jquery.slim.min.js) | JavaScript | 1 | 1 | 1 | 3 |

[Summary](results.md) / [Details](details.md) / [Diff Summary](diff.md) / Diff Details