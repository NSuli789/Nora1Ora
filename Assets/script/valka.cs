using UnityEngine;

class valka : MonoBehaviour
{


    [SerializeField] float speed;
    

    void Start()
    {
        Debug.Log("Hello Unity!");
        Debug.Log("Csod�s ami csod�s :D:D:D:D:D:D:D:DDDDD");
        Debug.Log("Csod�s "+name);
        
    }

     void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }

}
