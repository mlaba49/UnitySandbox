using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "You find yourself facing two doors, each flanked by a single " +
            "man. There is a plaque in front of you. 'One of these men always tells the truth; one always lies. " +
            "You may ask one question. One door leads to heaven; one leads to hell.' " +
            "How will you approach this?\n" +
            "1. Shoot one of the men in the balls.\n" +
            "2. Figure out a question you can ask that will get you through no matter what.\n" +
            "3. Build a lie detector.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
