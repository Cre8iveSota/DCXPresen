using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incident1983 : MonoBehaviour
{
    // Start is called before the first frame update
    Renderer renderer;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            renderer.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            renderer.enabled = true;
        }
    }
}
