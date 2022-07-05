using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
    public GameManager _GameManager;
    public GameObject Kamera;
    public bool SonaGeldikMi;
    public GameObject GidecegiYer;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void FixedUpdate()
    {
        if (!SonaGeldikMi)
        {
            transform.Translate(Vector3.forward * .5f * Time.deltaTime);

        }


    }
    // Update is called once per frame
    void Update()
    {
        if (SonaGeldikMi)
        {
            transform.position = Vector3.Lerp(transform.position, GidecegiYer.transform.position, .015f);

        }
        else
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                if (Input.GetAxis("Mouse X") < 0)
                {
                    transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x - .1f,
                        transform.position.y, transform.position.z), .3f);
                }
                if (Input.GetAxis("Mouse X") > 0)
                {
                    transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + .1f,
                       transform.position.y, transform.position.z), .3f);
                }
            }

        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("carpma") || other.CompareTag("toplama") || other.CompareTag("cikarma") || other.CompareTag("bolme"))

        {
            int Sayi = int.Parse(other.name);
            _GameManager.AdamYonetim(other.tag, Sayi, other.transform);
        }
        else if (other.CompareTag("SonTetikleyici"))
        {
            Kamera.GetComponent<Kamera>().SonaGeldikMi = true;
            _GameManager.DusmanlariTetikle();
            SonaGeldikMi = true;
        }
    }
}
