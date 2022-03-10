using UnityEngine;

public class ColliderDetector : MonoBehaviour
{
    private UIManager uIManager;

    void Start()
    {
        uIManager = FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Circle"))
        {
            uIManager.AddScore();
            Destroy(other.gameObject);
        }
    }
}