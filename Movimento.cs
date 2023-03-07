using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class Movimento : MonoBehaviour

{

    Vector3 Vec;

    void Start()

    {


    }

    void Update()

    {

        Vec = transform.localPosition;

        Vec.y += Input.GetAxis("Jump") * Time.deltaTime * 5;

        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 5;

        Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 5;

        transform.localPosition = Vec;

    }

}