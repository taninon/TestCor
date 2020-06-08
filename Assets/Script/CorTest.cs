using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorTest : MonoBehaviour
{
    //sphereのPrefabをアタッチする
    #pragma warning disable 649
    [SerializeField] private GameObject spherePrefab;
    #pragma warning restore 649

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TestCor());
    }

    private IEnumerator TestCor()
    {
        //一秒待つ
        yield return new WaitForSeconds(1f);

        var cube1 = Instantiate(spherePrefab);
        cube1.transform.localPosition = new Vector3(0, 0, 0);

        //一秒待つ
        yield return new WaitForSeconds(1f);

        var cube2 = Instantiate(spherePrefab);
        cube2.transform.localPosition = new Vector3(2, 0, 0);

        //一秒待つ
        yield return new WaitForSeconds(1f);

        var cube3 = Instantiate(spherePrefab);
        cube3.transform.localPosition = new Vector3(4, 0, 0);
    }
}
