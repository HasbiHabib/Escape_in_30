using UnityEngine;

public class TopDownMovement : MonoBehaviour {


	public ItemTargetScanner playerScanner;

    [Header("GameObject Interactable Items")]
    public GameObject[] Items;

	public gamemaster _gm;


    [Header("Movement Component")]
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed = 5;
    [SerializeField] private float _turnSpeed = 360;
    private Vector3 _input;

    public Animator playerAnimation;
    float Movements;

    void Start() {
		_gm = FindObjectOfType<gamemaster>();
        // sprintSpeed = walkSpeed + (walkSpeed / 2);
    }
 
	void FixedUpdate() {

		if (_gm.paused == false && _gm.OnInteract == false)
		{
            _input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
            Movements = _input.normalized.magnitude * _speed;
            Look();
            Move();

            foreach (GameObject b in Items)
			{
				playerScanner.DetectPlayer(transform, b);
			}
        }

        playerAnimation.SetFloat("Run", Movements);
    }

    private void Look()
    {
        if (_input == Vector3.zero) return;

        var rot = Quaternion.LookRotation(_input.ToIso(), Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, _turnSpeed * Time.deltaTime);
    }
    private void Move()
    {
        _rb.MovePosition(transform.position + transform.forward * Movements * Time.deltaTime);
    }

#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        playerScanner.EditorGizmo(transform);
    }
#endif
}

public static class Helpers
{
    private static Matrix4x4 _isoMatrix = Matrix4x4.Rotate(Quaternion.Euler(0, 0, 0));
    public static Vector3 ToIso(this Vector3 input) => _isoMatrix.MultiplyPoint3x4(input);
}

