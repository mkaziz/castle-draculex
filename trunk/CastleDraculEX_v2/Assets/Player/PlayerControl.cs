using UnityEngine;
using System.Collections;


public class PlayerControl : MonoBehaviour {
    public float speed = 12.0F;
    //public float jumpSpeed = 8.0F;
    //public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    void Update() {
        CharacterController controller = GetComponent<CharacterController>();

	            moveDirection = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"), 0);

		if (Input.GetKeyUp(KeyCode.LeftArrow) && Input.GetKeyUp(KeyCode.RightArrow) && 
			Input.GetKeyUp(KeyCode.UpArrow) && Input.GetKeyUp(KeyCode.DownArrow))
			{
	            moveDirection = Vector3.zero;
		}
		else 
		{
			moveDirection = transform.TransformDirection(moveDirection);
	        moveDirection *= speed;
			
		}

			controller.Move(moveDirection * Time.deltaTime);
	  }
    
	public float pushPower = 2.0F;
    void OnControllerColliderHit(ControllerColliderHit hit) {
        Rigidbody body = hit.collider.attachedRigidbody;
        Debug.Log("HIT");
		if (body == null || body.isKinematic)
            return;
        
        Vector3 pushDir = new Vector3(0, hit.moveDirection.y, hit.moveDirection.z);
        body.velocity = pushDir * pushPower;
		
    }
}

