using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AltKarakter : MonoBehaviour
{
    GameObject Target;
    NavMeshAgent _NavMesh;
    public GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _NavMesh = GetComponent<NavMeshAgent>();
        Target = _gameManager.Vn;

    }

    
    private void LateUpdate()
    {
        _NavMesh.SetDestination(Target.transform.position);
    }
    Vector3 PozisyonVer()
    {
        return new Vector3(transform.position.x, .23f, transform.position.z);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enmy"))
        {

            _gameManager.YokOlmaEfektiOlustur(PozisyonVer());
            gameObject.SetActive(false);
        }
        if (other.CompareTag("Testere"))
        {

            _gameManager.YokOlmaEfektiOlustur(PozisyonVer());
            gameObject.SetActive(false);
        }
        if (other.CompareTag("pervaneIgneler"))
        {

            _gameManager.YokOlmaEfektiOlustur(PozisyonVer());
            gameObject.SetActive(false);
        }
        if (other.CompareTag("Balyoz"))
        {

            _gameManager.YokOlmaEfektiOlustur(PozisyonVer(), true);

            gameObject.SetActive(false);
        }
        if (other.CompareTag("Dusman"))
        {

            _gameManager.YokOlmaEfektiOlustur(PozisyonVer(), false, false);

            gameObject.SetActive(false);
        }
    }
}
