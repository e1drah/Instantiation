using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    public static int SphereAmount = 5000;
    GameObject[] sphere = new GameObject[SphereAmount];
    int index = 0;
    Vector3 sphereSize = new Vector3(0.25f, 0.25f, 0.25f);


    // Start is called before the first frame update
    void Start()
    {
       for (int i = 0; i < sphere.Length - 1; i++)
        {
            sphere[i] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere[i].transform.localScale = sphereSize;
            sphere[i].AddComponent<Moveforward>();
            sphere[i].SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        int x = Random.Range(-50, 50);
        int y = 50;
        int z = Random.Range(-50, 50);
        Vector3 sphereStart = new Vector3(x, y, z);
        sphere[index].SetActive(true);
        sphere[index].transform.position = sphereStart;
        index ++;
        if (index == sphere.Length - 1)
        {
            index = 0;
        }
    }
}
