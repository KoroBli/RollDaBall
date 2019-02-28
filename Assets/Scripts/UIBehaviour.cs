using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBehaviour : MonoBehaviour {

    public Transform arrow;

    public Text countdownText;

    private int direction = 1;
    private int speed = 5;

    private float timeCounter = 0f;
	
	// Update is called once per frame
	void Update ()
    {
        timeCounter += Time.deltaTime;

        countdownText.text = Mathf.Round(timeCounter).ToString();
        arrow.Translate(0, speed * Time.deltaTime * direction, 0);

        if (arrow.position.z <= -60) direction *= -1;
        else if (arrow.position.z >= -55) direction *= -1;
    }
}
