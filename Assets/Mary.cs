using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mary : MonoBehaviour
{

    [SerializeField] GameObject cammy;
    // Start is called before the first frame update
    void Start()
    {
        cammy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnCamTrigger(){

    if (cammy){
            cammy.SetActive(false);
        }
        Debug.Log("trigga");
        cammy.SetActive(true);

      
    }
}
