using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Deactivation : MonoBehaviour
{
    //public Button button;
    public GameObject figure;
    //bool was_pushed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (figure.activeSelf == true)
            {
                figure.SetActive(false);
                Debug.Log("Button have been clicked");
                //was_pushed = false;
            }
            else if (figure.activeSelf == false)
            {
                //was_pushed = true;
                figure.SetActive(true);
                Debug.Log("Button have been clicked 2");
            }
        }
    }
    /*
    public void button_click()
    {
        if (button.GetComponent<Button>().enabled == false)
            button.GetComponent<Button>().enabled = true;
        else
            button.GetComponent<Button>().enabled = false;
    }
    */
}
