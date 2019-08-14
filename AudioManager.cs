using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource backgroundMusic;
    public AudioClip coinSound;
    public AudioClip winSound;
    public AudioClip clickSound;
    public AudioClip gameoverSound;

    public float volume;

    public bool playEffect;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start()
    {
        //DontDestroyOnLoad(this);
        backgroundMusic = GetComponent<AudioSource>();
        backgroundMusic.Play();
        //backgroundMusic.loop = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnGUI()
    {
        
    }
}
