using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormControl : MonoBehaviour
{
    public Toggle toggleMan;
    public Toggle toggleWomen;

    private void Start()
    {
        toggleMan.isOn = false;
        toggleWomen.isOn = false;
    }

    private void Update()
    {
        toggleMan.onValueChanged.AddListener(delegate {
            ToggleValueChanged(toggleMan);
        });

        //Toogle'�n onValueChanged yani, a��k veya kapal� de�i�ti�inde tetiklenir.
        //delegate bir t�r veri tipidir ve fonksiyonlar�n bellek adresini tutmak i�in kullan�l�r.
        toggleWomen.onValueChanged.AddListener(delegate {
            ToggleValueChanged(toggleWomen); //De�er de�i�ti�inde bu de�eri �a��r�r.
        });

        void ToggleValueChanged(Toggle change)
        {
            if (change == toggleMan && change.isOn)
            {
                toggleWomen.isOn = false;
            }
            else if (change == toggleWomen && change.isOn)
            {
                toggleMan.isOn = false;
            }
        }
    }



}
