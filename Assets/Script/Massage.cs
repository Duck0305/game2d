using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Massage : MonoBehaviour
{
    public GameObject massage;
    bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
      OpenMassage();
    }
    

      void OpenMassage()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                isOpen =!isOpen;
                massage.SetActive(isOpen);
            }
        }
    
}
