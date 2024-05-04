using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warp : MonoBehaviour
{
    float time, enterTime;
    Vector3 newPos = new Vector3(20, 100, -17.7700005f);
    [SerializeField] int warpNum;
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            time += Time.deltaTime;
            if (warpNum == 1)
            {
                gm.slidesCounter.currentSlideNum = 80;
            }
            else if (warpNum == 2)
            {
                gm.slidesCounter.currentSlideNum = 81;
            }
            else if (warpNum == 3)
            {
                gm.slidesCounter.currentSlideNum = 82;
            }
            if (time > 2) SceneManager.LoadScene("Presen");
        }
        Debug.Log("bumped: " + other.gameObject.tag);
    }
}
