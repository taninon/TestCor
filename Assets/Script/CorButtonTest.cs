using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorButtonTest : MonoBehaviour {

    //sphereのPrefabをアタッチする
    #pragma warning disable 649
    [SerializeField] private GameObject spherePrefab;
    #pragma warning restore 649

    private bool buttonClick = false;

    // Start is called before the first frame update
    void Start () {
        StartCoroutine (ButtonCor ());
    }

    public void ButtonClick () {
        buttonClick = true;
    }

    private GameObject InstantiateSphere(Vector3 setPos)
    {
        var sphere = Instantiate(spherePrefab);
        sphere.transform.localPosition = setPos;
        return sphere;
    }

    private IEnumerator ButtonCor () {

        //buttonClickがTrueになるまでループする
        while(buttonClick == false)
        {
            //1フレーム待つ
            yield return null;
        }

        var sphere1 = InstantiateSphere(new Vector3(0, 0, 0));
        buttonClick = false;

        //buttonClickがFalseになるまで待つ　同じ処理
        yield return new WaitUntil (() => buttonClick);

        var sphere2 = InstantiateSphere(new Vector3(2, 0, 0));
        buttonClick = false;

        //buttonClickがFalseになるまで待つ WaitWhileは正負が逆になる
        yield return new WaitWhile (() => !buttonClick);

        var sphere3 = InstantiateSphere(new Vector3(4, 0, 0));
        buttonClick = false;
    }

}