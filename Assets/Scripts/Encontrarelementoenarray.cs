using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encontrarelementoenarray : MonoBehaviour
{

    public GameObject[] arrayDeMesas;

    public GameObject[] objectsCollection;


    // Start is called before the first frame update
    void Start()
    {
        arrayDeMesas = GameObject.FindGameObjectsWithTag("Mesa");

        objectsCollection = GameObject.FindGameObjectsWithTag("Mesa");

        AgregarScriptMesa();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            //DesactivarMesa();

        }


        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            Destruirunpardemesas();
        }
    }

    void DesactivarMesa()
    {
        for (int i = 0; i<arrayDeMesas.Length;i++)
        {
            arrayDeMesas[i].SetActive(false);
        }
    }

    void DestruirMesas()
    {
        for (int i = 0; i < arrayDeMesas.Length; i++)
        {
            
        }
    }

    void AgregarScriptMesa()
    {
        foreach (GameObject go in arrayDeMesas)
        {

            go.AddComponent<Mesa>();

            go.GetComponent<Mesa>().Destructible = Random.Range(0, 2) == 0;
            
        }
    }


    void Destruirunpardemesas()
    {
        foreach (GameObject go in arrayDeMesas)
        {
            if (go.GetComponent<Mesa>().Destructible)
            {
                Destroy(go);
            }

        }
    }

}
