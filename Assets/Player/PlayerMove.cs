	using UnityEngine;
 
public class PlayerMove : MonoBehaviour {
  private Rigidbody2D _body;
  [SerializeField] private float _playerSpeed = 5.0f;
 
  private void Start() {
    _body = GetComponent<Rigidbody2D>();

  }
 
  private void FixedUpdate() {
    if (Input.GetAxis("Horizontal") < 0) {
      // 左邊
      GetComponent<SpriteRenderer>().flipX = true;
      GetComponent<Animator>().SetBool("isRun", true);
      
    } else if (Input.GetAxis("Horizontal") > 0) {
      // 右邊
      GetComponent<SpriteRenderer>().flipX = false;
      GetComponent<Animator>().SetBool("isRun", true);
    } else{
       GetComponent<Animator>().SetBool("isRun", false);
    }
    //
    Vector2 move = new Vector2(
      Input.GetAxis("Horizontal"),
      Input.GetAxis("Vertical")
    );
    Vector2 nowPosition =
        this.gameObject.transform.position;
    if (move != Vector2.zero) {
      _body.MovePosition(nowPosition + move *
                         Time.deltaTime *
                         _playerSpeed);
    }
  }
}