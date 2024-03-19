
using UnityEngine;

public class hajo : MonoBehaviour
{
    [SerializeField] float speed = 5;



    void Update()
    { //ujra és ujra menne fel a startnál egyszer történik meg


      /*  Vector2 lepes = Vector2.up;

        lepes *= Time.deltaTime; //egymásodperc alatti mozgásegység
        //mindig szorzás

        lepes = lepes * speed;  // sebesség növelése

        Vector2 pos= transform.position;    //lekérem a poziciót

        // ehez hozzáadok pozit

        Vector2 newpos = pos + lepes;

        transform.position = newpos; //megadtam az uj helyet*/


        // egyszerûbb forma:

       

       // GetAxisRow durvább mozgás
       //GetAxis finomabb mozgás
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 direction = new(x,y);
        direction.Normalize(); //ugyanazzala sebeséggel mozog átlósan is mint jobbra balra
        Vector3 lepes = direction * speed * Time.deltaTime;
        transform.position = transform.position + lepes;
    }
}
