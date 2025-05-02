using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyPad : MonoBehaviour
{
    public string curPassword = "4592";
    public string input;
    public bool onTrigger;
    public bool doorOpen;
    public bool keypadScreen;
    public Transform doorHinge;


    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;

    }

    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
        keypadScreen = false;
        input = "";
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
        {
            input = input + "0";
        }


        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            input = input + "1";
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            input = input + "2";
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            input = input + "3";
        }

        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            input = input + "4";
        }

        if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            input = input + "5";
        }

        if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
        {
            input = input + "6";
        }

        if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
        {
            input = input + "7";
        }

        if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
        {
            input = input + "8";
        }

        if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
        {
            input = input + "9";
        }



        if (input == curPassword)
        {
            doorOpen = true;
            SceneManager.LoadScene("WinScene");

        }

        if (doorOpen)
        {
            var newRot = Quaternion.RotateTowards(doorHinge.rotation, Quaternion.Euler(0.0f, 90.0f, 0.0f), Time.deltaTime * 250);
            doorHinge.rotation = newRot;



        }
    }

    void OnGUI()
    {
        if (!doorOpen)
        {
            if (onTrigger)
            {
                GUI.Box(new Rect(300, 300, 400, 50), "'E' to open keypad");

                if (Input.GetKeyDown(KeyCode.E))
                {
                    keypadScreen = true;
                    onTrigger = false;
                }
            }

            if (keypadScreen)
            {
                //GUI.Box(new Rect(0, 0, 640, 70), "");
                //GUI.Box(new Rect(10, 10, 620, 50), input);
                GUI.Label(new Rect(510, 350, 100, 100), "'Esc' to exit");


                if (Input.GetKeyDown(KeyCode.Escape))
                {

                    keypadScreen = false;
                }

                if (keypadScreen)
                {
                    GUI.Box(new Rect(500, 10, 320, 455), "");
                    GUI.Box(new Rect(500, 20, 310, 25), input);

                    if (GUI.Button(new Rect(510, 50, 100, 100), "1"))
                    {
                        input = input + "1";
                    }

                    if (GUI.Button(new Rect(610, 50, 100, 100), "2"))
                    {
                        input = input + "2";
                    }

                    if (GUI.Button(new Rect(710, 50, 100, 100), "3"))
                    {
                        input = input + "3";
                    }

                    /////////////////////////
                    if (GUI.Button(new Rect(510, 150, 100, 100), "4"))
                    {
                        input = input + "4";
                    }

                    if (GUI.Button(new Rect(610, 150, 100, 100), "5"))
                    {
                        input = input + "5";
                    }

                    if (GUI.Button(new Rect(710, 150, 100, 100), "6"))
                    {
                        input = input + "6";
                    }

                    ///////////////////////////////////////
                    if (GUI.Button(new Rect(510, 250, 100, 100), "7"))
                    {
                        input = input + "7";
                    }

                    if (GUI.Button(new Rect(610, 250, 100, 100), "8"))
                    {
                        input = input + "8";
                    }

                    if (GUI.Button(new Rect(710, 250, 100, 100), "9"))
                    {
                        input = input + "9";
                    }
                    ///////////////////////////
                    if (GUI.Button(new Rect(610, 355, 100, 100), "0"))
                    {
                        input = input + "0";
                    }

                }

            }
        }
    }
}
