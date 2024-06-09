using UnityEngine;

public class RotateCube : MonoBehaviour
{
    [SerializeField] float m_rotSpeed = 1f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, m_rotSpeed * Time.deltaTime, 0);
    }
}
