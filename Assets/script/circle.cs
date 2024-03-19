using UnityEngine;

public class circle : MonoBehaviour
{
    [SerializeField] float radius;
    void Start()
    {
        float pi = 3.14f;

        var kerulet= 2 * radius * pi;
        var terulet = radius * radius * pi;


        Debug.Log("Kerület: " + kerulet);
        Debug.Log(terulet);



    }
}
