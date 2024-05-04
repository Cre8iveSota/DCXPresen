using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public CurrentSlideIndexMemory slidesCounter;
    int usedCount;
    GameObject player;
    Dictionary<int, Vector3> playerPos
    = new Dictionary<int, Vector3> {
         {0,new Vector3(-7.19000006f, 1, -14.6700001f)},//from 0 to 2
         {1,new Vector3(-7.19000006f, 1, -14.6700001f)},//1
         {2,new Vector3(-7.19000006f, 1, -14.6700001f)},//2 
         {3,new Vector3(0.389999986f, 1, 4.53000021f)},//3 1975
         {4,new Vector3(0.389999986f, 1, 4.53000021f)},//4 1975
         {5,new Vector3(0.389999986f, 1, 4.53000021f)},//5 1976
         {6,new Vector3(-7.88000011f,1,17.6800003f)},//6 1976
         {7,new Vector3(-7.88000011f,1,17.6800003f)},//7 1977
         {8,new Vector3(-7.88000011f,1,17.6800003f)},//8 1977
         {9,new Vector3(4.55999994f,13.4653835f,-17.7700005f)},//9 1977
         {10,new Vector3(22f,9,-1.5f)},//10 1977_1982
         {11,new Vector3(22f,9,-1.5f)},//11 1977_1982
         {12,new Vector3(27.5540001f,8f,11.0030003f)},//12 1983
         {13,new Vector3(15.5299997f,2f,22.2000008f)},//13 1983
         {14,new Vector3(-11.1800003f,17.4899998f,33.7700005f)},//14 1985
         {15,new Vector3(-11.1800003f,17.4899998f,33.7700005f)},//15 1989
         {16,new Vector3(-11.1800003f,17.4899998f,33.7700005f)},//16 1990_1991
         {17,new Vector3(-11.1800003f,17.4899998f,33.7700005f)},//17 1994
         {18,new Vector3(-11.1800003f,17.4899998f,33.7700005f)},//18 1996
         {19,new Vector3(-10.5299997f,20.1200008f,42.6399994f)},//19 1998
         {20,new Vector3(-10.0076227f,24.0199986f,49.1457634f)},//20 2000
         {80,new Vector3(4.55999994f,13.4653835f,-17.7700005f)},
         {81,new Vector3(6.46000004f,8.21000004f,33.0499992f)},
         {82,new Vector3(-10.2082815f,56.7999973f,38.7675171f)},
         };
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Start()
    {
        Debug.Log("XX: " + SceneManager.GetActiveScene().name);
        usedCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            SceneManager.LoadScene("Presen");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(slidesCounter.currentSlideNum);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene("Slide");
        }
    }
    void LateUpdate()
    {
        RestartPosForChara(slidesCounter.currentSlideNum);
    }

    private void RestartPosForChara(int cuurentSlideDoneNum)
    {
        if (slidesCounter.currentSlideNum == cuurentSlideDoneNum && SceneManager.GetActiveScene().name == "Presen" && usedCount < 3)
        {
            player.transform.position = playerPos[cuurentSlideDoneNum];
            player.transform.rotation = slidesCounter.lastPlayerRotation;
            usedCount++;
        }
    }

    void PlayerPos()
    {

    }
}
