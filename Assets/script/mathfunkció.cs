using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mathfunkció : MonoBehaviour
{
    [SerializeField] float in1, in2;

    [SerializeField] float power, absolute, sign, rounded, ceiled, floored;
    [SerializeField] float min, max, sqrt;

    void OnValidate()
    {
        power = Mathf.Pow(in1, in2); //valamit valahanyadik 2 a 4-en
        absolute = Mathf.Abs(in1); // nullától való távolság
        sign = Mathf.Sign(in1);      // -1 / 1
        rounded = Mathf.Round(in1); //szimpla kerekítlés 0,5 fel 33
        ceiled = Mathf.Ceil(in1); //felfelé kerekít egészre kerekít
        floored = Mathf.Floor(in1); //lefelé kerekít
        min = Mathf.Min(in1, in2); // a két szám közül akisebbet
        max = Mathf.Max(in1, in2);// két szám között a nagyobbik
        sqrt = Mathf.Sqrt(in1); // gyökvonás





        for (int i = 1; i < 100; i++) 
        {
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
            
           
        }
    }
}
