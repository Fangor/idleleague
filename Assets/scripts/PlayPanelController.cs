using UnityEngine;
using System.Collections;

public class PlayPanelController : MonoBehaviour {

    public static PlayPanelController Instance { get { return instance; } }
    private static PlayPanelController instance;

    public Play[] plays;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            //LoadSounds();
        }
        else if (instance != null && instance != this)
        {
            Debug.Log("Deleting singleton Dup.  Someone screwed up");
            Destroy(gameObject);
            return;
        }
    }

    //Gets play from play panel
    public Play GetSelectedPlay()
    {
        //TODO implement
        return plays[0];
    }

}
