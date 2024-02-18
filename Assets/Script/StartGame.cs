using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class StartGame : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
   // [SerializeField] private Button button;
    //[SerializeField] private GameObject currentScene;
   // [SerializeField] private GameObject nextScene;

   // private void Start()
    //{
        
        //_button.onClick.AddListener(_ChangeScene);
    //}

    //private void OnDistory()
   // {
       // _button.onClick.RemoveListener(__ChangeScene);
   // }

    //private void _ChangeScene()
    //{
        //_currentScene.SetActive(false);
        //_nextScene.SetActive(true);
   // }
}
    

