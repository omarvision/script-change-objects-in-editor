using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    #region --- helpers ---
    //Note: the 1st enum is the default enum
    public enum enumVisibility
    {
        Visible,
        Hidden,
    }

    //Note: we need the child objects defined (before the script runs)
    //      so the script can make changes in the editor before play pressed
    [System.Serializable]
    public struct structParts
    {
        public GameObject Windows;
        public GameObject WheelFL;
        public GameObject WheelFR;
        public GameObject WheelBL;
        public GameObject WheelBR;
    }

    [System.Serializable]
    public struct structPartVisibility
    {
        public enumVisibility Windows;
        public enumVisibility WheelFL;
        public enumVisibility WheelFR;
        public enumVisibility WheelBL;
        public enumVisibility WheelBR;
    }
    #endregion

    [Tooltip("Define the parts of the car to the script, so we can edit them in OnValidate")]
    public structParts Parts;

    [Tooltip("The visibility of parts of the car, will work in from inspector in edit mode thanks to OnValidate")]
    public structPartVisibility Visibility;

    private void OnValidate()
    {
        //Note: This function is called when the script is loaded or a value is changed in the inspector 
        //      (Called in the editor only).

        //windows
        if (Visibility.Windows == enumVisibility.Hidden)
        {
            Parts.Windows.SetActive(false);
        }
        else
        {
            Parts.Windows.SetActive(true);
        }

        //wheels forward
        if (Visibility.WheelFL == enumVisibility.Hidden)
        {
            Parts.WheelFL.SetActive(false);
        }
        else
        {
            Parts.WheelFL.SetActive(true);
        }

        if (Visibility.WheelFR == enumVisibility.Hidden)
        {
            Parts.WheelFR.SetActive(false);
        }
        else
        {
            Parts.WheelFR.SetActive(true);
        }

        //wheels back
        if (Visibility.WheelBL == enumVisibility.Hidden)
        {
            Parts.WheelBL.SetActive(false);
        }
        else
        {
            Parts.WheelBL.SetActive(true);
        }
        if (Visibility.WheelBR == enumVisibility.Hidden)
        {
            Parts.WheelBR.SetActive(false);
        }
        else
        {
            Parts.WheelBR.SetActive(true);
        }
    }
}