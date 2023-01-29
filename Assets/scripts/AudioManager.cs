using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance { get; private set; }
    [SerializeField] private AudioSource sfxSource, musicSource;

    [Header("SFX Sounds")]
    public AudioClip sfxDrag;
    public AudioClip sfxCorrect;
    public AudioClip[] sfxWins;

    private void Awake()
    {
        print("awake audio");
        if (instance != null && instance != this)
        {
            Destroy(this);
            print("destroy this");
        }

        else
        {
            print("destroy else");
            instance = this;
            DontDestroyOnLoad(this);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    public void Win()
    {
        //reproducir sonido de win aleatorio
        int i = Random.Range(0, sfxWins.Length);
        PlaySound(sfxWins[i]);
    }

}
