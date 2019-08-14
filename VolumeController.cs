using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Audio;
using Assets.Scripts;

public class VolumeController : MonoBehaviour
{
    public Slider slider;
    public AudioMixer mixer;
    public Toggle toggle;

    private bool playMusic;

    public void Start()
    {
        AssignButtons();
        slider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
    }

    public void SetLevel(float sliderValue)
    {
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MusicVolume", sliderValue);
    }

    public void ToggleSounds(bool value)
    {
        playMusic = value;

        if (!value)
        {
            AudioManager.instance.backgroundMusic.Stop();
            UIManager.instance.sound.Stop();
        }
        else if (value)
        {
            AudioManager.instance.backgroundMusic.Play();
            UIManager.instance.sound.Play();
        }
    }

    public void AssignButtons()
    {
        toggle.onValueChanged.AddListener(x => ToggleSounds(x));
    }
}
