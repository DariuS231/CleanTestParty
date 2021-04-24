using System;
using System.Collections;
using System.Collections.Generic;
using PlayFab.Party;
using UnityEngine;

public class Party : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Login.UserAuthenticated += HandleUserAuthenticated;
    }

    private void OnDestroy()
    {
        Login.UserAuthenticated -= HandleUserAuthenticated;
    }

    private void HandleUserAuthenticated()
    {
        Logger.Instance.Log("Party  -   HandleUserAuthenticated");
        PlayFabMultiplayerManager.Get().CreateAndJoinNetwork();
        PlayFabMultiplayerManager.Get().OnNetworkJoined += OnNetworkJoined;
        PlayFabMultiplayerManager.Get().OnError += OnError;
    }

    private void OnError(object sender, PlayFabMultiplayerManagerErrorArgs args)
    {
        Logger.Instance.LogError("Party  -   OnError");
        Logger.Instance.LogError(args.ToString());
    }

    private void OnNetworkJoined(object sender, string networkId)
    {
        Logger.Instance.Log("Party  -   OnNetworkJoined");
        // Print the Network ID so you can give it to the other client.
        Logger.Instance.Log(networkId);
    }
}
