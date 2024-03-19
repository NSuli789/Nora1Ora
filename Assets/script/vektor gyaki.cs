using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vektorgyaki : MonoBehaviour
{

    void Start()
    {
        Vector2 myvector = new(2, 3);
        float cx = myvector.x;
        float cy = myvector.y;

        Vector2 masikvector = new(4, 9);

        Vector2 osszead = myvector + masikvector;
        Vector2 kivonas = myvector - masikvector;


    }
}
