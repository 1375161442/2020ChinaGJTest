using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUIScript : MonoBehaviour
{
    public GameObject Image = null;
    public GameObject CtrlButton = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeShowImage(bool isShow)
    {
        if (isShow)
        {
            CtrlButton.SetActive(false);
            Image.SetActive(true);
        }
        else
        {
            CtrlButton.SetActive(true);
            Image.SetActive(false);
        }
    }
}
