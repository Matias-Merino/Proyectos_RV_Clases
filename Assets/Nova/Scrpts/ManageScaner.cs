using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ManageScaner : MonoBehaviour
{
    //este va en el player pa que cree los scaner en un intervalo de tiempo
    public AudioLoudnesDetection loudnesDetection;
    public float minimunLoudnes = 0.02f;  // el minimo que hace una voz en el microfono es de 0.01 mas abajo es ruido del ambiente
    public GameObject scanner;
    public bool canCreate;
    float LoudnessMicrophone;
    public float scanerValue;
    public float scannerCooldown = 0.8f;
    float timer;
    public Transform scannerPos;

    public InputActionReference scanerAction;
    public AudioSource scanerclip;


    private void Awake()
    {
        scanerAction.action.started += Presionado;
    }

    private void OnDestroy()
    {
        scanerAction.action.started -= Presionado;
    }
    private void Start()
    {

    }
    private void Presionado(InputAction.CallbackContext context)
    {
        if (canCreate)
        {
            Generar();
            scanerclip.Play();
            canCreate = false;
            Debug.Log("presionado A");
            timer = 0;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        LoudnessMicrophone = loudnesDetection.GetLoudnessFromMicrophone();
        if (LoudnessMicrophone > minimunLoudnes && canCreate)
        {
            Generar();
            canCreate = false;
            Debug.Log("alcanzaste el minimo");
            timer = 0;

        }

        if (!canCreate)
            timer += Time.deltaTime;

        if (timer >= scannerCooldown)
            canCreate = true;
    }
    private void Generar()
    {
            GameObject scaner = Instantiate(scanner, scannerPos.position, transform.rotation);
            scanner.GetComponent<Scaner_Life>().ScanerValues(scanerValue);
    }
}
