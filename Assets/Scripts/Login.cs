using System;
using System.Collections;
using System.Collections.Generic;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;

public class Login : MonoBehaviour
{
    private static Login _instance;

    public static Login Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
    }

    private string userDisplayName;

    private string playFabId;

    private string entityId;

    public void Start()
    {
        LogInClient();
    }

    public string GetUserDisplayName() => this.userDisplayName;

    public string GetPlayFabId() => this.playFabId;

    public string GetEntityId() => this.entityId;

    public static event Action UserAuthenticated;


#region LogIn
    private void LogInClient()
    {
        var localId = GUIDUtility.getUniqueID();

        var logIdRequest =
            new LoginWithCustomIDRequest()
            {
                TitleId = PlayFabSettings.TitleId,
                CreateAccount = true,
                CustomId = localId
            };

        PlayFabClientAPI
            .LoginWithCustomID(logIdRequest,
            this.HandleLogInSuccess,
            this.HandleLogInError);
    }

    private void HandleLogInError(PlayFabError error)
    {
        Logger.Instance.LogError("Login  -   HandleLogInError");
        Logger.Instance.LogError(error.ToString());
    }

    private void HandleLogInSuccess(LoginResult response)
    {
        Logger.Instance.Log("Login  -   HandleLogInSuccess");
        var entityToken = response.EntityToken;
        this.playFabId = response.PlayFabId;
        this.entityId = entityToken.Entity.Id;
        UserAuthenticated?.Invoke();
    }


#endregion

}
