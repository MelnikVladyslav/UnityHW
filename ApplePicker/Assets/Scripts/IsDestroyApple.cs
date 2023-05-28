using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class IsDestroyApple : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Apple")
        {
            Destroy(other.gameObject);
        }
    }
}
