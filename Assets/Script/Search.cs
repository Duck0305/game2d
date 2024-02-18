using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Search : MonoBehaviour
{
    public GameObject massage2;
    bool isOpened;
   
 

    public void OpenMassage2()
    {
     isOpened = !isOpened;
     massage2.SetActive(isOpened);
    }
}
