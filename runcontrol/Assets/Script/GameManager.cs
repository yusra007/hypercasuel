using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using genel;
public class GameManager : MonoBehaviour
{
    public GameObject Vn;

    public static int AnlikKarakterSayisi = 1;

    public List<GameObject> Karakterler;
    public List<GameObject> OlusmaEfektleri;
    public List<GameObject> YokOlmaEfektleri;
    public List<GameObject> AdamLekesiEfektleri;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //    foreach (var item in Karakterler)
        //    {
        //        if(!item.activeInHierarchy)
        //        {
        //            item.transform.position = Dn.transform.position;
        //            item.SetActive(true);
        //            AnlikKarakterSayisi++;
        //            break;
        //        }
        //    }
    }
    public void AdamYonetim(string islemTuru, int GelenSayi, Transform Pozisyon)
    {
        switch (islemTuru)
        {

            case "carpma":
                Kutuphane.Carpma(GelenSayi, Karakterler, Pozisyon, OlusmaEfektleri);

                break;
            case "toplama":
                Kutuphane.Toplama(GelenSayi, Karakterler, Pozisyon,OlusmaEfektleri);


                break;
            case "cikarma":
                Kutuphane.Bolme(GelenSayi, Karakterler, YokOlmaEfektleri);

                break;
            case "bolme":

                Kutuphane.Cikarma(GelenSayi, Karakterler, YokOlmaEfektleri);


                break;

        }


    }
    public void YokOlmaEfektiOlustur(Vector3 Pozisyon, bool Balyoz=false)
    {
        foreach (var item in YokOlmaEfektleri)
        {
            if(!item.activeInHierarchy)
            {
                item.transform.position = Pozisyon;
                item.SetActive(true);
                item.GetComponent<ParticleSystem>().Play();
                AnlikKarakterSayisi--;
                break;

            }

        }
        if(Balyoz)
        {
            Vector3 yeniPoz = new Vector3(Pozisyon.x, 0.005f, Pozisyon.z);
            foreach (var item in AdamLekesiEfektleri)
            {
                if (!item.activeInHierarchy)
                {
                   
                    item.SetActive(true);
                    item.transform.position = yeniPoz;
                    break;

                }

            }
        }
    }
    

}

