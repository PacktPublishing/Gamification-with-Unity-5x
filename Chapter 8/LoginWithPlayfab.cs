using UnityEngine;
using System.Collections;
using PlayFab;
using PlayFab.ClientModels;

public class LoginWithPlayfab : MonoBehaviour {

    public string PlayFabId;

    // Use this for initialization
    void Start () {
        PlayFabSettings.TitleId = "YOUR TITLE ID";
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void Login(string titleId) {
        LoginWithCustomIDRequest request = new LoginWithCustomIDRequest() {
            TitleId = titleId,
            CreateAccount = true,
            CustomId = SystemInfo.deviceUniqueIdentifier
        };

        PlayFabClientAPI.LoginWithCustomID(request, (result) => {
            PlayFabId = result.PlayFabId;
            Debug.Log("The PlayFabID is: " + PlayFabId);

            if (result.NewlyCreated) {
                Debug.Log("new account has been created");
            }
            else {
                Debug.Log("Logged in with an existing account");
            }
        },
        (error) => {
            Debug.Log("An error occured");
            Debug.Log(error.ErrorMessage);
        });
    }

}
