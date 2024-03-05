using UnityEngine;

class valka : MonoBehaviour
{


    [SerializeField] float speed;
    

    void Start()
    {
        Debug.Log("Hello Unity!");
        Debug.Log("Csodás ami csodás :D:D:D:D:D:D:D:DDDDD");
        Debug.Log("Csodás "+name);
        
    }

     void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }

}
