using UnityEngine;

public class SocketController : MonoBehaviour
{
    [SerializeField] private LineRenderer wireLine;
    private Transform targetDevice;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // For testing: follow mouse
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorld.z = 0f;

            if (wireLine != null)
            {
                wireLine.positionCount = 2;
                wireLine.SetPosition(0, transform.position);
                wireLine.SetPosition(1, mouseWorld); // replace with actual target later
            }
        }
    }
}
