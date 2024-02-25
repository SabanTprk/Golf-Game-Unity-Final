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

        //Toogle'ýn onValueChanged yani, açýk veya kapalý deðiþtiðinde tetiklenir.
        //delegate bir tür veri tipidir ve fonksiyonlarýn bellek adresini tutmak için kullanýlýr.
        toggleWomen.onValueChanged.AddListener(delegate {
            ToggleValueChanged(toggleWomen); //Deðer deðiþtiðinde bu deðeri çaðýrýr.
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
