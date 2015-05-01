using UnityEngine;
using System.Collections;

public class OpenUitklaptafeltje : MonoBehaviour {


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Schuifje")
        {
            other.transform.Rotate(new Vector3(90, 0, 0));
            //Debug.Log("Schuifje Touched");
        }
    }

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.tag == "Schuifje")
    //    {
    //        other.transform.Rotate(new Vector3(-90, 0, 0));
    //        //Debug.Log("Schuifje Touched");
    //    }
    //}

    
}
