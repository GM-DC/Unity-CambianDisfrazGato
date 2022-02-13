using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cb_gorra : MonoBehaviour
{
    
    public GameObject Gorra_1;
    public GameObject Gorra_2;
    public GameObject Gorra_3;
    public GameObject Gorra_4;
    public GameObject Gorra_5;
    private int num = 0;

    public void CambiarGorra(){
        if (num==0)
        {
            Gorra_1.SetActive(true);
            Gorra_2.SetActive(false);
            Gorra_3.SetActive(false);
            Gorra_4.SetActive(false);
            Gorra_5.SetActive(false);
            num = 1;

        } else if (num==1)
        {
            Gorra_1.SetActive(false);
            Gorra_2.SetActive(true);
            Gorra_3.SetActive(false);
            Gorra_4.SetActive(false);
            Gorra_5.SetActive(false);
            num = 2;

        } else if (num==2)
        {
            Gorra_1.SetActive(false);
            Gorra_2.SetActive(false);
            Gorra_3.SetActive(true);
            Gorra_4.SetActive(false);
            Gorra_5.SetActive(false);
            num = 3;
        }else if (num==3)
        {
            Gorra_1.SetActive(false);
            Gorra_2.SetActive(false);
            Gorra_3.SetActive(false);
            Gorra_4.SetActive(true);
            Gorra_5.SetActive(false);
            num = 4;

        } else if (num==4)
        {
            Gorra_1.SetActive(false);
            Gorra_2.SetActive(false);
            Gorra_3.SetActive(false);
            Gorra_4.SetActive(false);
            Gorra_5.SetActive(true);
            num = 5;
        }else if (num==5)
        {
            Gorra_1.SetActive(false);
            Gorra_2.SetActive(false);
            Gorra_3.SetActive(false);
            Gorra_4.SetActive(false);
            Gorra_5.SetActive(false);
            num = 0;
        }
    }
}
