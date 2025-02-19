using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(Collider other)
    {
        transform.Translate((float)0.25,(float)-1.3, 0);
    }

    // Update is called once per frame
    void Update(Collider other)
    {
        transform.Translate((float)0.25, (float)-1.3, 0);
    }
    private void OnTriggerExit(Collider other)
    {
        transform.Translate((float)0.25, (float)1.789, 0);
    }
}
