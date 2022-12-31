using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components;
using System.Net;
using Jorda.Client.Services.Identity;
using System.Security.Claims;
using Jorda.Client.Common.Helpers;

namespace Jorda.Client.Shared;

public class AppRouteView : RouteView
{
    [Inject]
    public NavigationManager NavigationManager { get; set; } = null!;

    [Inject]
    public IAuthService AuthenticationService { get; set; } = null!;

    protected override void Render(RenderTreeBuilder builder)
    {
        AuthorizeUser();
        base.Render(builder);
    }


    private void AuthorizeUser()
    {
        var authorize = (AuthorizeAttribute)Attribute.GetCustomAttribute(RouteData.PageType, typeof(AuthorizeAttribute))!;

        if (authorize != null)
        {
            if (AuthenticationService.Token == null)
            {
                var returnUrl = WebUtility.UrlEncode(new Uri(NavigationManager.Uri).PathAndQuery);
                NavigationManager.NavigateTo($"login?returnUrl={WebUtility.UrlEncode(new Uri(NavigationManager.Uri).PathAndQuery)}");
                return;
            }

            if (!string.IsNullOrWhiteSpace(authorize.Roles) && !authorize.Roles.Split(',')
                .Contains(JwtParseHelper.ParseClaimsFromJwt(AuthenticationService.Token!).FirstOrDefault(n => n.Type == ClaimTypes.Role)!.Value))
            {
                NavigationManager.NavigateTo($"access-denied");
                return;
            }
        }

    }
}
