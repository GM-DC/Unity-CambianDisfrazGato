using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cb_boca : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Boca_1.SetActive(false);
        Boca_2.SetActive(false);
        Boca_3.SetActive(true);
    }

    public GameObject Boca_1;
    public GameObject Boca_2;
    public GameObject Boca_3;
    private int num = 0;

    public void CambiarBoca(){
        if (num==0)
        {
            Boca_1.SetActive(true);
            Boca_2.SetActive(false);
            Boca_3.SetActive(false);
            num = 1;

        } else if (num==1)
        {
            Boca_1.SetActive(false);
            Boca_2.SetActive(true);
            Boca_3.SetActive(false);
            num = 2;

        } else if (num==2)
        {
            Boca_1.SetActive(false);
            Boca_2.SetActive(false);
            Boca_3.SetActive(true);
            num = 0;
        }
    }

}
