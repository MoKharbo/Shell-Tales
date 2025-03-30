using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private Camera _camera;
    private Bounds _cameraBounds;
    private Vector3 _origin;
    private Vector3 _difference;
    private Vector3 _targetPosition;
    private void Awake() => _camera = Camera.main;
    // Start is called before the first frame update
    void Start()
    {
        var height = _camera.orthographicSize;
        var width = _camera.aspect;

        var minX = Global.WorldBounds.min.x + width;
        var maxX = Global.WorldBounds.extents.x - width;

        var minY = Global.WorldBounds.min.y + height;
        var maxY = Global.WorldBounds.extents.y - height;

        _cameraBounds = new Bounds();
        _cameraBounds.SetMinMax(
            new Vector3(minX, minY, z:0.0f),
            new Vector3(maxX, maxY, z:0.0f)
            );
    }

    private void LateUpdate()
    {
        _targetPosition = _origin - _difference;
        _targetPosition = GetCameraBounds();
        transform.position = _targetPosition;
    }

    private Vector3 GetCameraBounds()
    {
        return new Vector3(
            Mathf.Clamp(value: _targetPosition.x, _cameraBounds.min.x, _cameraBounds.max.x),
            Mathf.Clamp(value: _targetPosition.y, _cameraBounds.min.y, _cameraBounds.max.y),
            transform.position.z
            );
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
