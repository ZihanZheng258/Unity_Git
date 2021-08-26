using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 3;
    public Renderer rend;
    public int randomInt;
    // Start is called before the first frame update
    void Start()
    {
        randomInt = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i += 1;
        Debug.Log(name+":"+i);
        if (CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }
        else if(CompareTag("Blue") && i == randomInt)
        {
            GetComponent<Renderer>().enabled = false;
        }
    }
}
