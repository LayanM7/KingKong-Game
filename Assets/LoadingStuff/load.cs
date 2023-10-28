using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class load : MonoBehaviour
{

    public Slider slider;

    public float sliderValue = 5;

    public string sceneToLoad;

    public Text text;
    public int count;

    // Start is called before the first frame update
    void Start()



    {

        InvokeRepeating("ChangeCount", 1, 1);


        StartCoroutine(Counting());



    }
    public void Update()
    {
        slider.value = sliderValue;


        if (sliderValue == 0f)
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneToLoad);
        }

        text.text = ( count +"%" );

    }

    public void ChangeCount()
    {
        count -= 5;
    }

    public IEnumerator Counting()
    {
       

        while (true)
        {


            yield return new WaitForSeconds(1);
            sliderValue -= 5;




        }



    }
}
