using UnityEngine;
using System.IO;
public class Example : MonoBehaviour
{
    //float mouseX;
    //float mouseY;
    //public bool invertedMouse ;
    //public float speed = 1f;
    //public GameObject[] myObject;
    public GameObject newObject;
    public GameObject[] gos;
    void Start()
    {
        gos = new GameObject[10];
        for(int i=0; i < 10; i++)
        {
            GameObject go = GameObject.Instantiate(newObject, transform.position, transform.rotation);
            Vector3 v = new Vector3();
            v.x = Random.Range(-10, 10);
            v.z = Random.Range(-10, 10);
            go.transform.position = v;
            go.name = i.ToString();
            if(i%2 == 0)
            {
                go.AddComponent(typeof(returnZombie));

            }
            gos[i] = go;
        }
        //GameObject[,] twoDimension = new GameObject[2, 3];
        //for(int i=0; i<twoDimension.Length; i++)
        //{
        //    Debug.Log(i);
        //} 
        /*int[] scores = new int[10];
        int i = 0;
        while (i < 10)
        {
            scores[i] = Random.Range(1, 100);
            print(scores[i]);
            i++;
        }
        */
    }
    void Update()
    {
        
      //  mouseX += Input.GetAxis("Mouse X");
      //  if (invertedMouse)
      //  {
      //      mouseY += Input.GetAxis("Mouse Y");
      //  }
      //  else
      //  {
      //      mouseY -= Input.GetAxis("Mouse Y");
      //  }
        
      ////  Debug.Log("Mouse X position: " + mouseX);
      ////  Debug.Log("Mouse Y position: " + mouseY);
      //  transform.eulerAngles = new Vector3(mouseY , mouseX , 0);

      //  if (Input.GetKey(KeyCode.W)) transform.position += transform.forward * speed;
      //  if(Input.GetKey(KeyCode.S)) transform.position -= transform.forward * speed;
      //  if(Input.GetKey(KeyCode.A)) transform.position -= transform.right * speed;
      //  if(Input.GetKey(KeyCode.D)) transform.position += transform.right * speed;

    }
}