using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //public Vector3 offset;
    public float speed = 15f;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] private Transform target;


    /*
    void LateUpdate()
    {
        // Hedefin pozisyonunu ve rotasyonunu al
        Vector3 targetPosition = target.position + offset;
        Quaternion targetRotation = Quaternion.LookRotation(target.position - transform.position);

        // Kameranýn pozisyonunu ve rotasyonunu hedefe doðru yumuþak bir geçiþle güncelle
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smoothTime);
    }
    */

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, speed * Time.deltaTime);
    }
}
