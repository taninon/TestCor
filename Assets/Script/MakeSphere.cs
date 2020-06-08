using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSphere : MonoBehaviour
{
    [SerializeField] private GameObject spherePrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (InstantiateCor ());
    }
     private GameObject InstantiateSphere(Vector3 setPos)
    {
        var sphere = Instantiate(spherePrefab);
        sphere.transform.localPosition = setPos;
        return sphere;
    }


   private IEnumerator InstantiateCor () {
         //一秒待つ
        yield return new WaitForSeconds(1f);

        for (int i = 0; i < 15000; i++)
        {
            yield return null;
            InstantiateSphere(new Vector3(Random.Range(-10f,10f),Random.Range(-10.0f, 10.0f),Random.Range(0f, 10.0f)));
        }
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
