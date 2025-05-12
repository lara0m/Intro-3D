using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCloner : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;

    public int randomNumber;
    public int min;
    public int max;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CloneRandom()
    {
        randomNumber = Random.Range(min, max + 1);
        if(randomNumber == 0)
        {
            Instantiate(prefab1);
        } else if (randomNumber == 1)
        {
            Instantiate(prefab2);
        } else
        {
            Instantiate(prefab3);
        }
    }
}
