using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public GameObject restartPanel;
    public GameObject failPanel;
    public TextMeshProUGUI scoreText;
    private int score = 0;
    public AudioSource pointSource;
    public AudioSource myAudioSource;
    public AudioSource myAudioSourcefail;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Delik")
        {
            restartPanel.SetActive(true);

            if (myAudioSource != null)
            {
                myAudioSource.Play();
            }
            else
            {
                Debug.LogError("AudioSource bulunamadý!");
            }
        }

        if (collision.gameObject.name == "Fail")
        {
            failPanel.SetActive(true);
            Debug.Log("Merahaba");
            if (myAudioSourcefail != null)
            {
                myAudioSourcefail.Play();
            }
            else
            {
                Debug.LogError("AudioSource bulunamadý!");
            }
        }
    


        if (collision.gameObject.name == "Point")
        {
            score += 8;
            scoreText.text = "" + score.ToString();
            Destroy(collision.gameObject);
            pointSource.Play();
        }
    }
}
