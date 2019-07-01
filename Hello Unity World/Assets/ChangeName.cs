using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeName : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        TMPro.TextMeshProUGUI myText = GetComponent<TextMeshProUGUI>();
        if (Input.GetKeyDown("space"))
        {
        myText.SetText("Hello World! My name is Alejandro");
        }
        if (Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }

    }
}
