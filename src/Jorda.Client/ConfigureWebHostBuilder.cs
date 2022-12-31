using Jorda.Client.Services.Goal;
using Jorda.Client.Services.HistoryItem;
using Jorda.Client.Services.Identity;
using Jorda.Client.Services.Note;
using Jorda.Client.Services.Notification;
using Jorda.Client.Services.Section;
using Jorda.Client.Services.ToDoItem;
using Jorda.Client.Services.UserFile;
using Jorda.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;
using System.Reflection;
using FluentValidation;

namespace Jorda.Client
{
    public static class ConfigureWebHostBuilder
    {
        public static WebAssemblyHostBuilder AddRootComponents(this WebAssemblyHostBuilder builder)
        {
            builder.RootComponents.Add<App>("#app");
            return builder;
        }

        public static WebAssemblyHostBuilder AddClientServices(this WebAssemblyHostBuilder builder)
        {
            builder.Services
                    .AddBlazoredLocalStorage()
                    .AddScoped<IGoalService, GoalService>()
                    .AddScoped<IHistoryItemService, HistoryItemService>()
                    .AddScoped<IAccountService, AccountService>()
                    .AddScoped<IAuthService, AuthService>()
                    .AddScoped<IUserService, UserService>()
                    .AddScoped<INoteService, NoteService>()
                    .AddScoped<INotificationService, NotificationService>()
                    .AddScoped<ISectionService, SectionService>()
                    .AddScoped<IToDoItemService, ToDoItemService>()
                    .AddScoped<IUserFileService, UserFileService>()
                    .AddScoped<IHttpService, HttpService>()
                    .AddScoped<IClientPreferenceService,ClientPreferenceService>()
                    .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly())
                    .AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["apiUrl"]!) }); ;
            return builder;
        }
    }
}
