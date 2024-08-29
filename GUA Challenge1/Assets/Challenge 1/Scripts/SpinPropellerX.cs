using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    [SerializeField] float PropellerSpeed;

    // Update is called once per frame
    void FixedUpdate()
    {
        this.gameObject.transform.Rotate(Vector3.forward * PropellerSpeed * Time.deltaTime);
    }
}
