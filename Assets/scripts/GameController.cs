using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public static GameController Instance { get { return instance; } }
    private static GameController instance;

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
    
    public void Play()
    {
        FieldController.Instance.Play();
    }

    //Gets play from play panel
    public Play GetSelectedPlay()
    {
        return PlayPanelController.Instance.GetSelectedPlay();
    }

}
