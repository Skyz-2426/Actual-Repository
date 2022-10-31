using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bean_Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0f, 280 * Time.deltaTime,0f, Space.Self);
    }
}
