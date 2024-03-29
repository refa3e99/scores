// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Scores.Components.Account.Pages.Manage
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\005044\source\repos\Scores\Scores\Components\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\005044\source\repos\Scores\Scores\Components\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\005044\source\repos\Scores\Scores\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\005044\source\repos\Scores\Scores\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\005044\source\repos\Scores\Scores\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\005044\source\repos\Scores\Scores\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\005044\source\repos\Scores\Scores\Components\_Imports.razor"
using static Microsoft.AspNetCore.Components.Web.RenderMode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\005044\source\repos\Scores\Scores\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\005044\source\repos\Scores\Scores\Components\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\005044\source\repos\Scores\Scores\Components\_Imports.razor"
using Scores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\005044\source\repos\Scores\Scores\Components\_Imports.razor"
using Scores.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\005044\source\repos\Scores\Scores\Components\Account\Pages\_Imports.razor"
using Scores.Components.Account.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\005044\source\repos\Scores\Scores\Components\Account\Pages\Manage\Index.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\005044\source\repos\Scores\Scores\Components\Account\Pages\Manage\Index.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\005044\source\repos\Scores\Scores\Components\Account\Pages\Manage\Index.razor"
using Scores.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\005044\source\repos\Scores\Scores\Components\Account\Pages\Manage\_Imports.razor"
[Microsoft.AspNetCore.Authorization.Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(ManageLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Account/Manage")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\005044\source\repos\Scores\Scores\Components\Account\Pages\Manage\Index.razor"
       
    private ApplicationUser user = default!;
    private string? username;
    private string? phoneNumber;

    [CascadingParameter]
    private HttpContext HttpContext { get; set; } = default!;

    [SupplyParameterFromForm]
    private InputModel Input { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        user = await UserAccessor.GetRequiredUserAsync(HttpContext);
        username = await UserManager.GetUserNameAsync(user);
        phoneNumber = await UserManager.GetPhoneNumberAsync(user);

        Input.PhoneNumber ??= phoneNumber;
    }

    private async Task OnValidSubmitAsync()
    {
        if (Input.PhoneNumber != phoneNumber)
        {
            var setPhoneResult = await UserManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
            if (!setPhoneResult.Succeeded)
            {
                RedirectManager.RedirectToCurrentPageWithStatus("Error: Failed to set phone number.", HttpContext);
            }
        }

        await SignInManager.RefreshSignInAsync(user);
        RedirectManager.RedirectToCurrentPageWithStatus("Your profile has been updated", HttpContext);
    }

    private sealed class InputModel
    {
        [Phone]
        [Display(Name = "Phone number")]
        public string? PhoneNumber { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IdentityRedirectManager RedirectManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IdentityUserAccessor UserAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<ApplicationUser> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> UserManager { get; set; }
    }
}
#pragma warning restore 1591
