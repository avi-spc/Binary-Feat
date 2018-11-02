using UnityEngine;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
using GooglePlayGames;

public class GpgManager : MonoBehaviour {

    public Text loginMessage;

	// Use this for initialization
	void Start () {
        PlayGamesPlatform.Activate();
        LoginToGooglePlay();
	}

    void LoginToGooglePlay() {
        if (Social.localUser.authenticated) {
            return;
        }

        Social.localUser.Authenticate(
            (bool success) => {
                if (success) {
                    loginMessage.text = "Logged in";
                }
                else {
                    loginMessage.text = "Login failed";
                }
            }
            );
    }

}
