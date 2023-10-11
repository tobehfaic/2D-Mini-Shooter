using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleFire_Enabler : MonoBehaviour
{

    public int firemode;
    public GameObject ShotSpawn, ShotSpawn2, ShotSpawn3;
    // Start is called before the first frame update
    void Start()
    {
        firemode = 0;
    }

    // Update is called once per frame
    void Update()
    {
        changeFiremode();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "FireRatePowerUp")
        {
            
            if(firemode < 2)
            {
                firemode ++;
            }

            Destroy(collision.gameObject);
        }
    }

    void changeFiremode()
    {
        switch (firemode)

        {
            case 0:
                ShotSpawn.SetActive(true);
                ShotSpawn2.SetActive(false);
                ShotSpawn3.SetActive(false);
                break;

            case 1:
                ShotSpawn.SetActive(false);
                ShotSpawn2.SetActive(true);
                ShotSpawn3.SetActive(true);
                break;

            case 2:
                ShotSpawn.SetActive(true);
                ShotSpawn2.SetActive(true);
                ShotSpawn3.SetActive(true);
                break;
        }
    }
}
