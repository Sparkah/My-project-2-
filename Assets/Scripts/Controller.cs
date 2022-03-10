using UnityEngine;

public class Controller : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.tag == "Player")
                {
                    hit.collider.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
                }
            }
        }
    }
}