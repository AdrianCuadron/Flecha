using System.Collections;
using UnityEngine;

public class CreadorObstaculos : MonoBehaviour
{
    public GameObject[] lista;
    public GameObject obstaculoArriba;
    public GameObject obstaculoAbajo;
    public GameObject camara;

    public float tiempoCrear;

    public Vector3 posCam;
    // Start is called before the first frame update
    void Start()
    {
        tiempoCrear = 1.25f;
        StartCoroutine("instantiator");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void instanciador()
    {
        posCam = camara.gameObject.transform.position;
        
        
        Instantiate(obstaculoArriba, new Vector3((posCam.x + 15f), Random.Range(2f, 6f), 0f), obstaculoArriba.gameObject.transform.rotation);
        Instantiate(obstaculoAbajo, new Vector3((posCam.x + 15f) + Random.Range(2f, 4f), Random.Range(-6f, -2f), 0f), obstaculoAbajo.gameObject.transform.rotation);
    }


    IEnumerator instantiator()
    {
        
        yield return new WaitForSeconds(tiempoCrear);
        instanciador();
        StartCoroutine("instantiator");
    }
}
