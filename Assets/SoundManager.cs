using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioDemo;
    [Range(0f, 1f)]
    public float volumenDemo;

    // AudioMixer del proyecto
    public AudioMixer audioMixer;
    [Range(-80f, 20f)]
    public float volumenMaster;
    [Range(-80f, 20f)]
    public float volumenSFX;
    [Range(-80f, 20f)]
    public float volumenMusic;
    [Range(-80f, 20f)]
    public float volumenAmbiental;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // audioDemo.volume = volumenDemo;
        // audioMixer.SetFloat("volumeMasterAM", volumenMaster);
        // audioMixer.SetFloat("volumeMusicAM", volumenMusic);
        // audioMixer.SetFloat("volumeSFXAM", volumenSFX);
        // audioMixer.SetFloat("volumeAmbientalAM", volumenAmbiental);
    }

    public void SetVolumenMaster(float newVolumen)
    {
        audioMixer.SetFloat("volumeMasterAM", newVolumen);
    }

    public void SetVolumenAmbience(float newVolumen)
    {
        audioMixer.SetFloat("volumeAmbientalAM", newVolumen);
    }

    public void SetVolumenSFX(float newVolumen)
    {
        audioMixer.SetFloat("volumeSFXAM", newVolumen);
    }

    public void SetVolumenMusic(float newVolumen)
    {
        audioMixer.SetFloat("volumeMusicAM", newVolumen);
    }
}
