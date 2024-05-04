using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiveIntoSpecifcEra : MonoBehaviour
{
    [SerializeField] int targetSlideNum;
    GameManager gm;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gm.slidesCounter.currentSlideNum = targetSlideNum;
            gm.slidesCounter.lastPlayerRotation = player.transform.rotation;
            SceneManager.LoadScene("Slide");
        }
    }
}
