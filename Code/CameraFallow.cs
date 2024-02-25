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

        // Kameran�n pozisyonunu ve rotasyonunu hedefe do�ru yumu�ak bir ge�i�le g�ncelle
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
