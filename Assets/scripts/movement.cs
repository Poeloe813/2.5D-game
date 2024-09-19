using UnityEngine;
using UnityEngine.InputSystem;

public class Movement1 : MonoBehaviour
{
    public InputAction PlayerControls;
    public float Xmove2;
    public float Ymove2;
    public float Zmove2;
    public Player Player;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Xmove2 = PlayerControls.ReadValue<Vector3>().x;
        Ymove2 = PlayerControls.ReadValue<Vector3>().y;
        Zmove2 = PlayerControls.ReadValue<Vector3>().z;
        PlayerControls.ReadValue<Vector3>();

        Vector3 movement = new Vector3(Xmove2, Ymove2, Zmove2);
        rb.velocity = transform.forward * Zmove2 * Player.Speed;
        transform.Rotate(Vector3.up, Xmove2 * Player.BodyRotationSpeed * Time.deltaTime);
    }
}
