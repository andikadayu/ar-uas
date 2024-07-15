using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Button MyButton = null; // assign in the editor
    public string numberoflevel;
    void Start()
    {
        MyButton.onClick.AddListener(() => {
            LoadGameLevel(numberoflevel);  // replace "level_name" with the actual scene name you want to load  // e.g., LoadGameLevel("SampleScene");  // load a scene named "SampleScene" when the button is clicked  // you can also use the string variable "numberoflevel" to dynamically load different scenes based on user input  // remember to replace "numberoflevel" with your actual variable name  // e.g., LoadGameLevel
        });
    }

    //or
    public void LoadGameLevel(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
