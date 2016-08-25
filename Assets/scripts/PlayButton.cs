using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {

    void OnMouseDown()
    {
        GameController.Instance.Play();
    }
}
