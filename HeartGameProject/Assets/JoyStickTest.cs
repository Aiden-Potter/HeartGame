using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class JoyStickTest : MonoBehaviour
{
    private string currentButton;//当前按下的按键
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //var values = Enum.GetValues(typeof(KeyCode));//存储所有的按键
        //for (int x = 0; x < values.Length; x++)
        //{
        //    if (Input.GetKeyDown((KeyCode)values.GetValue(x)))
        //    {
        //        currentButton = values.GetValue(x).ToString();//遍历并获取当前按下的按键
        //    }
        //}
        if (Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            print("Joystrickbutton1");
        }
        print("1Left: X:" + Input.GetAxis("PsLeftJoyStick-X1") + ",Y:" + Input.GetAxis("PsLeftJoyStick-Y1"));
        print("1Right: X:" + Input.GetAxis("PsRightJoyStick-X1") + ",Y:" + Input.GetAxis("PsRightJoyStick-Y1"));
        //print("D-pad: X:" + Input.GetAxis("D-padX") + ",Y:" + Input.GetAxis("D-padY"));
        print("2Left: X:" + Input.GetAxis("PsLeftJoyStick-X2") + ",Y:" + Input.GetAxis("PsLeftJoyStick-Y2"));
        print("2Right: X:" + Input.GetAxis("PsRightJoyStick-X2") + ",Y:" + Input.GetAxis("PsRightJoyStick-Y2"));
        //print("D-pad: X:" + Input.GetAxis("D-padX") + ",Y:" + Input.GetAxis("D-padY"));
        // print(Input.GetAxis("PsRightJoyStick-Y"));

    }

    void OnGUI()
    {
        GUI.TextArea(new Rect(0, 0, 250, 40), "Current Button : " + currentButton);//使用GUI在屏幕上面实时打印当前按下的按键
    }
}
