using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorControllerKey : MonoBehaviour
{
    public float rotationSpeed = 90f;
    public float tr;
    bool doorOpened = false;

    private void OnEnable()
    {
        KeyCol.open += OpenDoor;
    }
    private void OnDisable()
    {
        KeyCol.open -= OpenDoor;
    }

    public void OpenDoor()
    {
        // Si la puerta ya est� abierta, no hacer nada
        if (doorOpened)
            return;
            // Rota la puerta hacia la posici�n abierta
            Quaternion targetRotation = Quaternion.Euler(0f, tr, 0f);
            StartCoroutine(RotateDoor(targetRotation));

            // Marca la puerta como abierta
            doorOpened = true;
    }

    private IEnumerator RotateDoor(Quaternion targetRotation)
    {
        // Obtiene la rotaci�n actual de la puerta
        Quaternion startRotation = transform.rotation;

        // Calcula el tiempo total de rotaci�n en funci�n de la velocidad de rotaci�n
        float rotationTime = Quaternion.Angle(startRotation, targetRotation) / rotationSpeed;

        // Realiza la rotaci�n gradual de la puerta
        float elapsedTime = 0f;
        while (elapsedTime < rotationTime)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / rotationTime);
            transform.rotation = Quaternion.Lerp(startRotation, targetRotation, t);
            yield return null;
        }
    }
}

