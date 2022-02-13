using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cb_ojos : MonoBehaviour
{
    void Start()
    {
        Ojos_1.SetActive(true);
        Ojos_2.SetActive(false);
        Ojos_3.SetActive(false);
        Ojos_4.SetActive(false);
        Ojos_5.SetActive(false);
    }

    public GameObject Ojos_1;
    public GameObject Ojos_2;
    public GameObject Ojos_3;
    public GameObject Ojos_4;
    public GameObject Ojos_5;
    private int num = 0;

    public void CambiarOjos(){
        if (num==0)
        {
            Ojos_1.SetActive(true);
            Ojos_2.SetActive(false);
            Ojos_3.SetActive(false);
            Ojos_4.SetActive(false);
            Ojos_5.SetActive(false);
            num = 1;

        } else if (num==1)
        {
            Ojos_1.SetActive(false);
            Ojos_2.SetActive(true);
            Ojos_3.SetActive(false);
            Ojos_4.SetActive(false);
            Ojos_5.SetActive(false);
            num = 2;

        } else if (num==2)
        {
            Ojos_1.SetActive(false);
            Ojos_2.SetActive(false);
            Ojos_3.SetActive(true);
            Ojos_4.SetActive(false);
            Ojos_5.SetActive(false);
            num = 3;
        }else if (num==3)
        {
            Ojos_1.SetActive(false);
            Ojos_2.SetActive(false);
            Ojos_3.SetActive(false);
            Ojos_4.SetActive(true);
            Ojos_5.SetActive(false);
            num = 4;

        } else if (num==4)
        {
            Ojos_1.SetActive(false);
            Ojos_2.SetActive(false);
            Ojos_3.SetActive(false);
            Ojos_4.SetActive(false);
            Ojos_5.SetActive(true);
            num = 0;

        }
    }


}
