using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace genel
{
    public class Kutuphane : MonoBehaviour
    {
        public static void Carpma(int GelenSayi, List<GameObject> Karakterler,Transform Pozisyon, List<GameObject> Olu�turmaEfektleri)
        {
            int DonguSayisi = (GameManager.AnlikKarakterSayisi * GelenSayi) - GameManager.AnlikKarakterSayisi;
            int sayi = 0;
            foreach (var item in Karakterler)
            {

                if (sayi < DonguSayisi)
                {
                    if (!item.activeInHierarchy)
                    {
                        foreach (var item2 in Olu�turmaEfektleri)
                        {
                            if (!item2.activeInHierarchy)
                            {
                                item2.SetActive(true);
                                item2.transform.position = Pozisyon.position;
                                item2.GetComponent<ParticleSystem>().Play();
                                break;
                            }
                        }

                        item.transform.position = Pozisyon.position;
                        item.SetActive(true);
                        sayi++;
                    }
                }
                else
                {
                    sayi = 0;
                    break;
                }
            }
            GameManager.AnlikKarakterSayisi *= GelenSayi;

        }
        public static void Toplama(int GelenSayi, List<GameObject> Karakterler, Transform Pozisyon, List<GameObject> Olu�turmaEfektleri)
        {
            int sayi2 = 0;
            foreach (var item in Karakterler)
            {

                if (sayi2 < GelenSayi)
                {
                    if (!item.activeInHierarchy)
                    {
                        foreach (var item2 in Olu�turmaEfektleri)
                        {
                            if (!item2.activeInHierarchy)
                            {
                                item2.SetActive(true);
                                item2.transform.position = Pozisyon.position;
                                item2.GetComponent<ParticleSystem>().Play();
                                break;
                            }
                        }
                        item.transform.position = Pozisyon.position;
                        item.SetActive(true);
                        sayi2++;
                    }
                }
                else
                {
                    sayi2 = 0;
                    break;
                }
            }
            GameManager.AnlikKarakterSayisi += GelenSayi;

        }

        public static void Bolme(int GelenSayi, List<GameObject> Karakterler, List<GameObject> YokOlmaEfektleri)
        {

            if (GameManager.AnlikKarakterSayisi < GelenSayi)
            {


                foreach (var item in Karakterler)
                {
                    foreach (var item2 in YokOlmaEfektleri)
                    {
                        if (!item2.activeInHierarchy)
                        {
                            Vector3 yeniPoz = new Vector3(item.transform.position.x, .23f, item.transform.position.z);

                            item2.SetActive(true);
                            item2.transform.position = yeniPoz;
                            item2.GetComponent<ParticleSystem>().Play();
                            break;
                        }
                    }

                    item.transform.position = Vector3.zero;
                    item.SetActive(false);
                }
                GameManager.AnlikKarakterSayisi = 1;
            }
            else
            {
                int bolen = GameManager.AnlikKarakterSayisi / GelenSayi;

                int sayi3 = 0;
                foreach (var item in Karakterler)
                {

                    if (sayi3 != 4)
                    {
                        if (item.activeInHierarchy)
                        {
                            foreach (var item2 in YokOlmaEfektleri)
                            {
                                if (!item2.activeInHierarchy)
                                {
                                    Vector3 yeniPoz = new Vector3(item.transform.position.x, .23f, item.transform.position.z);

                                    item2.SetActive(true);
                                    item2.transform.position = yeniPoz;
                                    item2.GetComponent<ParticleSystem>().Play();
                                    break;
                                }
                            }
                            item.transform.position = Vector3.zero;
                            item.SetActive(false);
                            sayi3++;
                        }
                    }
                    else
                    {
                        sayi3 = 0;
                        break;
                    }
                }
                if (GameManager.AnlikKarakterSayisi % GelenSayi == 0)
                {
                    GameManager.AnlikKarakterSayisi /= GelenSayi;
                }
                else if (GameManager.AnlikKarakterSayisi % GelenSayi == 1)
                {
                    GameManager.AnlikKarakterSayisi /= GelenSayi;
                    GameManager.AnlikKarakterSayisi++;
                }
                else if (GameManager.AnlikKarakterSayisi % GelenSayi == 2)
                {
                    GameManager.AnlikKarakterSayisi /= GelenSayi;
                    GameManager.AnlikKarakterSayisi += 2;
                }


            }


        }
        public static void Cikarma(int GelenSayi, List<GameObject> Karakterler, List<GameObject> YokOlmaEfektleri)
        {

            if (GameManager.AnlikKarakterSayisi < GelenSayi)
            {


                foreach (var item in Karakterler)
                {
                    foreach (var item2 in YokOlmaEfektleri)
                    {
                        if(!item2.activeInHierarchy)
                        {
                            Vector3 yeniPoz = new Vector3(item.transform.position.x, .23f, item.transform.position.z);

                            item2.SetActive(true);
                            item2.transform.position = yeniPoz;
                            item2.GetComponent<ParticleSystem>().Play();
                            break;
                        }
                    }


                    item.transform.position = Vector3.zero;
                    item.SetActive(false);
                }
                GameManager.AnlikKarakterSayisi = 1;
            }
            else
            {


                int sayi4 = 0;
                foreach (var item in Karakterler)
                {


                    if (sayi4 != GelenSayi)
                    {
                        if (item.activeInHierarchy)
                        {
                            foreach (var item2 in YokOlmaEfektleri)
                            {
                                if (!item2.activeInHierarchy)
                                {
                                    Vector3 yeniPoz = new Vector3(item.transform.position.x, .23f, item.transform.position.z);

                                    item2.SetActive(true);
                                    item2.transform.position = yeniPoz;
                                    item2.GetComponent<ParticleSystem>().Play();
                                    break;
                                }
                            }
                            item.transform.position = Vector3.zero;
                            item.SetActive(false);
                            sayi4++;
                        }
                    }
                    else
                    {
                        sayi4 = 0;
                        break;
                    }
                }
                GameManager.AnlikKarakterSayisi -= 4;

            }


        }
    }
}
