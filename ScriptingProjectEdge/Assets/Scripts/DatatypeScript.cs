using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatatypeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //value type variable
        Vector3 pos = transform.position;
            pos = new Vector3(0, 2, 0);

        //refrence type variable
        Transform tran = transform;
        tran.position = new Vector3(1, 2, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
