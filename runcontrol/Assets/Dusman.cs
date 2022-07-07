using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Dusman : MonoBehaviour
{
    public GameObject SaldiriHedefi;
   public NavMeshAgent navMash;
    bool SaldiriBasladiMi;
   
    public void AnimasyonTetikle()
    {
        GetComponent<Animator>().SetBool("Saldir", true);
        SaldiriBasladiMi = true;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        if(SaldiriBasladiMi)
        navMash.SetDestination(SaldiriHedefi.transform.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AltKarakterler"))
        {
            Vector3 yeniPoz = new Vector3(transform.position.x, .23f, transform.position.z);
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().YokOlmaEfektiOlustur(yeniPoz,false,true);

            gameObject.SetActive(false);
        }
    }
}
