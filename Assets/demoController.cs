using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demoController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0, 0, 0);
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
        direction = Vector3.ClampMagnitude(direction, 1f);
        transform.position += direction * 1 * Time.deltaTime;
    }
}
