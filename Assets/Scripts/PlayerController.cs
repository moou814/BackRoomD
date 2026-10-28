using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Move(Vector3 direction)
    {
        transform.Translate(direction * Time.deltaTime);
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
