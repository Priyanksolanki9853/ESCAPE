using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Authentication;

public class CloudManager : MonoBehaviour
{
    async void Awake()
    {
        await UnityServices.InitializeAsync();

        // Use anonymous sign-in, ideal for quick mobile games.
        if (!AuthenticationService.Instance.IsSignedIn)
        {
            await AuthenticationService.Instance.SignInAnonymouslyAsync();
            Debug.Log("Player is signed in with ID: " + AuthenticationService.Instance.PlayerId);
        }
    }
}
