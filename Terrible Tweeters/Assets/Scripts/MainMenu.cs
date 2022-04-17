using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    [SerializeField] AudioMixer _mixer;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            _mixer.SetFloat("MusicVolume", Mathf.Log10(PlayerPrefs.GetFloat("MusicVolume")) * 30f);
        }
        if (PlayerPrefs.HasKey("SFXVolume"))
        {
            _mixer.SetFloat("SFXVolume", Mathf.Log10(PlayerPrefs.GetFloat("MusicVolume")) * 30f);
        }
    }

    public void StartGame()
    {
        PlayerPrefs.Save();
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
