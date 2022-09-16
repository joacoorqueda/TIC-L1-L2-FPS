using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Codigoparaapagar : MonoBehaviour
{
    public GameObject input;
    public InputField codigo;
    public GameObject parlantedos;
    public GameObject parlanteuno;
    public GameObject Pollo1;
    public GameObject Pollo2;
    public GameObject NPCInteract;

    public GameObject TextF;

    public bool hasTalked;




    // Start is called before the first frame update
    void Start()
    {
        input.SetActive(false);
        NPCInteract.SetActive(false);
        TextF.SetActive(false);
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
                Destroy(Pollo1);
                Destroy(Pollo2);

                hasTalked = true;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        input.SetActive(true);

        if (other.gameObject.tag == "NPCPOLLO")
        {
            if (hasTalked == false)
            {


                NPCInteract.SetActive(true);
            }
            if (hasTalked == true)
            {
                TextF.SetActive(true);
            }

        }

        if(hasTalked == true)
        {

        }
        
    }

    void OnTriggerExit(Collider other)
    {
        input.SetActive(false);

        NPCInteract.SetActive(false);

        if (other.gameObject.CompareTag("NPCPOLLO"))
        {
            NPCInteract.SetActive(false);
        }
    }











}
