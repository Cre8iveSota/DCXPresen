using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SildesManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Sprite[] slideList;
    [SerializeField] Image displayImageObj;
    GameManager gm;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        UpdateSlide(gm.slidesCounter.currentSlideNum);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (gm.slidesCounter.currentSlideNum < slideList.Length - 1)
            {
                gm.slidesCounter.currentSlideNum++;
            }
            else gm.slidesCounter.currentSlideNum = slideList.Length - 1;

            if (
                gm.slidesCounter.currentSlideNum == 3
            || gm.slidesCounter.currentSlideNum == 5
            || gm.slidesCounter.currentSlideNum == 7
            || gm.slidesCounter.currentSlideNum == 10
            || gm.slidesCounter.currentSlideNum == 12
            || gm.slidesCounter.currentSlideNum == 13
            || gm.slidesCounter.currentSlideNum == 14
            || gm.slidesCounter.currentSlideNum == 15
            || gm.slidesCounter.currentSlideNum == 16
            || gm.slidesCounter.currentSlideNum == 17
            || gm.slidesCounter.currentSlideNum == 18
            || gm.slidesCounter.currentSlideNum == 19
            || gm.slidesCounter.currentSlideNum == 20
            )
            {
                gm.slidesCounter.currentSlideNum--;
                SceneManager.LoadScene("Presen");
            }
            else
            {
                UpdateSlide(gm.slidesCounter.currentSlideNum);
            }
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            gm.slidesCounter.currentSlideNum--;
            if (gm.slidesCounter.currentSlideNum >= 0) UpdateSlide(gm.slidesCounter.currentSlideNum);
            else gm.slidesCounter.currentSlideNum = 0;
        }
    }
    private void UpdateSlide(int displaySlideIndex)
    {
        displayImageObj.sprite = slideList[displaySlideIndex];
    }
}
