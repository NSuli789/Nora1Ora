
using UnityEngine;

public class hajo : MonoBehaviour
{
    [SerializeField] float speed = 5;



    void Update()
    { //ujra �s ujra menne fel a startn�l egyszer t�rt�nik meg


      /*  Vector2 lepes = Vector2.up;

        lepes *= Time.deltaTime; //egym�sodperc alatti mozg�segys�g
        //mindig szorz�s

        lepes = lepes * speed;  // sebess�g n�vel�se

        Vector2 pos= transform.position;    //lek�rem a pozici�t

        // ehez hozz�adok pozit

        Vector2 newpos = pos + lepes;

        transform.position = newpos; //megadtam az uj helyet*/


        // egyszer�bb forma:

       

       // GetAxisRow durv�bb mozg�s
       //GetAxis finomabb mozg�s
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 direction = new(x,y);
        direction.Normalize(); //ugyanazzala sebes�ggel mozog �tl�san is mint jobbra balra
        Vector3 lepes = direction * speed * Time.deltaTime;
        transform.position = transform.position + lepes;
    }
}
