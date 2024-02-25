using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class CharacterControls : MonoBehaviour
{
    public static CharacterControls Instance;
    public Rigidbody rb;
    public float friction = 1.5f;
    public float xRot, yRot = 0f;
    public float rotateSpeed = 5f;
    public LineRenderer Line;
    public float shootpower = 0f;
    public Slider powerSlider;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI numberText;
    private int currentNumber = 0;
    private bool lineVisible = false;
    private void Start()
    {
        Physics.gravity = new Vector3(0f, -22f, 0f);
    }


    private void Update()
    {
        powerSlider.onValueChanged.AddListener(ChangeShootPower);
        transform.position = rb.position;
        if (Input.GetMouseButtonDown(0))
        {
            // Sol mouse tu�una bas�ld���nda
            lineVisible = true;
        }

        if (lineVisible)
        {
            xRot += Input.GetAxis("Mouse X") * rotateSpeed;
            //yRot += Input.GetAxis("Mouse Y") * rotateSpeed;

            transform.rotation = Quaternion.Euler(0, xRot, 0f);

            Line.gameObject.SetActive(true);
            Line.SetPosition(0, transform.position);
            Line.SetPosition(1, transform.position + transform.forward * 1f);
        }

        if (Input.GetMouseButtonUp(0))
        {
            // Sol mouse tu�u b�rak�ld���nda
            lineVisible = false;
            Line.gameObject.SetActive(false);
        }
        if (Input.GetMouseButton(1))
        {
            Arttir();
            rb.velocity = transform.forward * shootpower;
            Line.gameObject.SetActive(false);
        }

        
    }

    void ChangeShootPower(float value)
    {
        // Slider'�n de�erini shootpower de�i�kenine at�yoruz.
        shootpower = Mathf.RoundToInt(value * 25);

        if (powerText != null)
        {
            powerText.text = shootpower.ToString();
        }
    }

    public void Arttir()
    {
        currentNumber++;
        numberText.text = currentNumber.ToString();
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if(Instance != this) 
        {
            Destroy(this);
        }
        
    }
}