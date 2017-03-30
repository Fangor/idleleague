using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour {
    public Button playButton;

    void Start ()
    {
        playButton = GetComponent<Button>();
        playButton.onClick.AddListener(OnMyClick);
        Debug.Log("Play Button initialized.");
    }

    void OnMyClick()
    {
        Debug.Log("Play button pressed.");
        GameController.Instance.Play();
    }
}
