using UnityEngine;
public class Jump : MonoBehaviour
{
    public float jumpforce = 3f;
    Rigidbody rb;
    private bool wantJump = false;
    private bool onGround = true;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (wantJump && onGround)
        {
            Debug.Log("Yes");
            rb.AddForce(Vector3.up * jumpforce,ForceMode.Impulse);
            onGround = false;
            
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

    void OnCollisionEnter(Collision col)
    {
		if (col.gameObject.tag == "Map") 
        {
			onGround = true;
		}
    }
}

