using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaObjeto : MonoBehaviour
{
    public bool destruirConCursor;
    public bool destruirAutomatico;
    public logicapersonaje LogicaPersonaje;

    public int tipo; 
    void Start()
    {
        LogicaPersonaje = GameObject.FindGameObjectWithTag("Player").GetComponent<logicapersonaje>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Efecto(){

        switch(tipo){
            case 1:
            LogicaPersonaje.gameObject.transform.localScale = new Vector3(3, 3, 3);
            break;
            case 2:
            LogicaPersonaje.velocidadMovimiento += 3;
            break;
            case 3:
            LogicaPersonaje.fuerzaDeSalto += 6;
            break;

            default:
            Debug.Log("Sin efecto");
            break;
        }
    }
}
