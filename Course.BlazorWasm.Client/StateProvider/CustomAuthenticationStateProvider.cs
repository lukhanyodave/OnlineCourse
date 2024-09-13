using Course.BlazorWasm.Client.Model;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System.Security.Claims;

namespace Course.BlazorWasm.Client.StateProvider;
public class CustomAuthenticationStateProvider : AuthenticationStateProvider, IDisposable
{
    public User? CurrentUser { get; set; } = new();
    //private readonly BlazorUserService _blazorUserService;
  //  private readonly GoogleResponse _googleResponse;

    public CustomAuthenticationStateProvider( )
    {
        AuthenticationStateChanged += OnAuthenticationStateChangedAsync;
        //_blazorUserService = blazorUserService;
       // _googleResponse = googleResponse;   
         
    }
    private async void OnAuthenticationStateChangedAsync(Task<AuthenticationState> task)
    {
        var authenticationState = await task;

        if (authenticationState is not null)
        {
            CurrentUser = User.FromClaimsPrincipal(authenticationState.User);
        }


    }

    public void Dispose() => AuthenticationStateChanged -= OnAuthenticationStateChangedAsync;

    //public override async  Task<AuthenticationState> GetAuthenticationStateAsync()
    //{
    //   // var principal = new ClaimsPrincipal();
    //    //if (CurrentUser is not  null) 
    //    //{
    //    //    principal = CurrentUser.ToClaimsPrincipal();//?? User.FromGoogleJwt(_googleResponse.Credential).ToClaimsPrincipal(); 
    //    //}

    //  //   var user = _blazorUserService.FetchUserFromBrowser();

    //    //if (user is not null)
    //    //{
    //      //  var authenticatedUser = await _blazorUserService.SendAuthenticateRequestAsync(user.Username, user.Password);
    //       //var authenticatedUser = User.FromGoogleJwt(_googleResponse.Credential);
    //       // if (authenticatedUser is not null)
    //       // {
    //       //     principal = authenticatedUser.ToClaimsPrincipal();
    //       // }
    //    //}

    //    return new ClaimsPrincipal(); ;
    //}

    [JSInvokable]
    public void GoogleLogin(GoogleResponse googleResponse)
    {
        var principal = new ClaimsPrincipal();
        var user = User.FromGoogleJwt(googleResponse.Credential);
        CurrentUser = user;

        if (user is not null)
        {
            principal = user.ToClaimsPrincipal();
        }

        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(principal)));
    }

    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        throw new NotImplementedException();
    }
}
