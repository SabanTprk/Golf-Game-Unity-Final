using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI textOutput;
    public AudioSource audioSource; // Eklenen ses kaynağı

    private string PlayerPrefsKey = "SliderValue";

    void Start()
    {
        // Slider'ın değişikliklerini dinle
        slider.onValueChanged.AddListener(delegate { UpdateText(); UpdateAudioVolume(); });

        // Önceki kaydedilmiş değeri kontrol et
        if (PlayerPrefs.HasKey(PlayerPrefsKey))
        {
            float savedValue = PlayerPrefs.GetFloat(PlayerPrefsKey);
            slider.value = savedValue / 100f; // Kaydedilen değeri slider'a uygula
        }

        // Başlangıçta bir kere metni güncelle
        UpdateText();
        UpdateAudioVolume();
    }

    void UpdateText()
    {
        // Slider'dan alınan değeri 100 ile çarp ve tam sayıya dönüştür
        int intValue = Mathf.RoundToInt(slider.value * 100f);

        // Metni güncelle
        textOutput.text = intValue.ToString();
    }

    void UpdateAudioVolume()
    {
        // Slider'dan alınan değeri direkt olarak ses seviyesine uygula
        audioSource.volume = slider.value;
    }

    public void SaveValue()
    {
        // Butona basıldığında değeri kaydet
        PlayerPrefs.SetFloat(PlayerPrefsKey, Mathf.RoundToInt(slider.value * 100f));
        PlayerPrefs.Save();
    }
}