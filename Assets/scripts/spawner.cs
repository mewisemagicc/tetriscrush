using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] panels;
    public GameObject[] objeler;
    public int index;
    public int maxint;
    public Transform spawnNoktas�;
    public Transform objspawnNoktas�;
    public static spawner instance;

    // Start is called before the first frame update
    public void Awake()
    {

        if (instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
       //nvokeRepeating("Spawn",5f, 5f);
        Spawn2();
        maxint = panels.Length;

        maxint = objeler.Length;

    }
    //void Spawn()
    //{
    //    //for (int i =0; i < 1 ; i++)
    //    //{
    //    //    Instantiate(panels[i], spawnNoktas�.position, Quaternion.identity);

    //    //}
    //    Instantiate(panels[index], spawnNoktas�.position, Quaternion.identity);
    //    index++;
    //    if(index==maxint)
    //    {
    //        index = 0;
    //    }



    //}
    public void Spawn2()
    {
        //for (int i =0; i < 1 ; i++)
        //{
        //    Instantiate(panels[i], spawnNoktas�.position, Quaternion.identity);

        //}
        Instantiate(panels[index], spawnNoktas�.position, Quaternion.identity);
        Instantiate(objeler[index], objspawnNoktas�.position, Quaternion.identity);
        index++;
        if (index == maxint)
        {
            index = 0;
        }



    }

}
