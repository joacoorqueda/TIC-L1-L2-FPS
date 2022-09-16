using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Codigoparaapagar : MonoBehaviour
{
    [SerializeField] GameObject input;
    public InputField codigo;
    public GameObject parlantedos;
    public GameObject parlanteuno;

    // Start is called before the first frame update
    void Start()
    {
        input.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) 
        {



            if (codigo.text == "04050607")
            {
                Destroy(parlantedos);
                Destroy(parlanteuno);
            }
        }
    }

    void OnTriggerEnter()
    {
        input.SetActive(true);
        }

    void OnTriggerExit()
    {
        input.SetActive(false);
    }
}
