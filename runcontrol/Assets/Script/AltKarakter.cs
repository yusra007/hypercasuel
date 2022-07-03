using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AltKarakter : MonoBehaviour
{
    GameObject Target;
    NavMeshAgent _NavMesh;
    // Start is called before the first frame update
    void Start()
    {
        _NavMesh = GetComponent<NavMeshAgent>();
        Target = GameObject.FindWithTag("GameManager").GetComponent<GameManager>().Vn;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        _NavMesh.SetDestination(Target.transform.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("enmy"))
        {
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().AnlikKarakterSayisi--;
            gameObject.SetActive(false);
        }
    }
}
