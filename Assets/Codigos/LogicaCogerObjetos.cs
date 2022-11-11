using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaCogerObjetos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(ray, out hitInfo)){
                if(hitInfo.collider.gameObject.tag == "objeto" && hitInfo.collider.GetComponent<logicaObjeto>().destruirConCursor == true) {
                    Debug.Log(hitInfo.collider.gameObject.tag);
                    hitInfo.collider.gameObject.GetComponent<logicaObjeto>().Efecto();
                    Destroy(hitInfo.collider.gameObject);
        }
    }
}
    }



     private void OnTriggerStay(Collider other) {

        Debug.Log(other.tag);

        if(other.tag == "objeto" && other.GetComponent<logicaObjeto>().destruirAutomatico == true){
            other.GetComponent<logicaObjeto>().Efecto();
            Destroy(other.gameObject);
        }

         if(Input.GetMouseButtonDown(1) && other.GetComponent<logicaObjeto>().destruirConCursor == false){
            other.GetComponent<logicaObjeto>().Efecto();
            Destroy(other.gameObject);
        }
    }

}