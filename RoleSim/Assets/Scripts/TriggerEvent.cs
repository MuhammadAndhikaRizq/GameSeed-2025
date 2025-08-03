using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEvent : MonoBehaviour
{
    public string destinationScene;

    // Update is called once per frame
    void Update()
    {
        InputSystem();
    }

    private void InputSystem()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPos, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == this.gameObject)
            {
                Debug.Log("Kepanggil");
                SceneManager.LoadScene(destinationScene);
            }
        }
        
    }
}
