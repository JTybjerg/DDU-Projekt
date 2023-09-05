using UnityEngine;
public class Jump : MonoBehaviour
{
    public float jumpforce = 3f;
    Rigidbody rb;
    private bool wantJump = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (wantJump)
        {
            Debug.Log("Yes");
            rb.AddForce(Vector3.up * jumpforce,ForceMode.Impulse);
            
        } else {
            Debug.Log("No");
        }
        wantJump = false;
        
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            wantJump = true;
        }
    }
}
