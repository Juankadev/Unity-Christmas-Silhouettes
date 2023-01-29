using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance { get; private set; }
    public static int levelcount;

    private void Awake()
    {
        levelcount = SceneManager.GetActiveScene().buildIndex;
        if (instance != null && instance != this)
            Destroy(this);
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }

    public void NextScene()
    {
        levelcount++;
        if (levelcount >= SceneManager.sceneCountInBuildSettings) 
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(levelcount);
        }
    }

}
