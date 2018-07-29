﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
   public Transform target;

    private const float _distance = 10.2f;
    private Vector3 _offset = new Vector3(0f, 2f, -_distance);
    private Vector3 _lookDown = new Vector3(10f, 0f, 0f);
    private const float _followRate = 0.1f;

	void Start () {
        transform.position = target.TransformPoint(_offset);
        transform.LookAt(target, Vector3.up);
	}
	
    void FixedUpdate () {
        Vector3 desiredPosition = target.TransformPoint(_offset);
        Vector3 lerp = Vector3.Lerp(transform.position, desiredPosition, _followRate);
        Vector3 toTarget = target.position - lerp;
        toTarget.Normalize();
        toTarget *= _distance;
        transform.position = target.position - toTarget;
        transform.LookAt(target, Vector3.up);
        transform.Rotate(_lookDown);
	}
}
