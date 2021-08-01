using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk : MonoBehaviour
{
    public AudioClip[] audios;


    public Transform jaw;
    public AudioSource audioSource;
    public float strength;
    public float updateStep = 0.001f;
    public int sampleDataLength = 256;

    private float currentUpdateTime = 0f;

    private float clipLoudness;
    private float[] clipSampleData;
    private Vector3 init;


    void Awake()
    {
       
        
        clipSampleData = new float[sampleDataLength];
        audioSource.clip = null;
        init = jaw.localEulerAngles;

    }

    public void Speak(int num)
    {
        audioSource.clip = audios[num];
        
        audioSource.Play();
    }


    void LateUpdate()
    {
        if (audioSource.clip != null)
        {
            jaw.localEulerAngles= init;

            currentUpdateTime += Time.deltaTime;

            if (currentUpdateTime >= updateStep)
            {
                currentUpdateTime = 0f;

                audioSource.clip.GetData(clipSampleData, audioSource.timeSamples); //I read 1024 samples, which is about 80 ms on a 44khz stereo clip, beginning at the current sample position of the clip.
                clipLoudness = 0f;
                foreach (var sample in clipSampleData)
                {
                    clipLoudness += Mathf.Abs(sample);
                }

                clipLoudness /= sampleDataLength; //clipLoudness is what you are looking for
                jaw.Rotate(0, clipLoudness * strength, 0);

            }
        }
    }

    

}
