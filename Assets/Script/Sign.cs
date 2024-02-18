using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI

public class Sign : MonoBehaviour
{
    public Image massageBox;
    public Text massageText;
    public string signText;
    private bool isPlayerInSign;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("player")
            && other.GetType().ToString()=="UnityEngine.CapsuleCollider2D")
        {
            isPlayerInSign = true;
        }
    }

     void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("player") 
            && other.GetType().ToString() == "UnityEngine.CapsuleCollider2D")
        {
            isPlayerInSign =false;
        }
    }

}
