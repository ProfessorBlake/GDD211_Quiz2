using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public void SetPosition(float xPosition)
	{
		transform.position = new Vector3(xPosition, 0f, 0f);
	}
}
