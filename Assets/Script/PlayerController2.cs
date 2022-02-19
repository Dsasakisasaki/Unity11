using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal"));
        //CharactorController付けた時はSimpleMoveかMoveでしか動かせない
        //SimpleMove便利だがジャンプできない　重力はあるので段差登ったあと降りる
        //Moveは重力ないから一度上がったらそのままの高さになってしまう
        //rigidbodyを付けて動かす場合は、AddForceかVerocityを設定して動かす
        cc.SimpleMove(transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * 200.0f);
    }
}
