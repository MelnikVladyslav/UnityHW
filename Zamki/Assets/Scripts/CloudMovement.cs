using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float speed = 1f; // Ўвидк≥сть руху хмаринки

    private void Update()
    {
        // «м≥щуЇмо позиц≥ю об'Їкта хмаринки по горизонтал≥ залежно в≥д швидкост≥
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
