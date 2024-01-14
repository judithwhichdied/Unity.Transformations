
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        var scale = transform.localScale;

        scale.x += _scaleSpeed;
        scale.y += _scaleSpeed;
        scale.z += _scaleSpeed;

        transform.localScale = scale;
    }
}
