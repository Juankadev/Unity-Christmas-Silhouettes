using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
    public static int itemsCorrectos;
    private float delayLevel;

    private void Awake()
    {
        itemsCorrectos = 0;

        if (instance != null && instance != this)
            Destroy(this);
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }

    public void Correcto()
    {
        itemsCorrectos++;
        if (itemsCorrectos >= 3)
        {
            itemsCorrectos=0;
            StartCoroutine(Win());
        }
    }

    private IEnumerator Win()
    {
        AudioManager.instance.Win();
        yield return new WaitForSeconds(4);
        LevelManager.instance.NextScene();
    }
}
