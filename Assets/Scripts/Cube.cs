using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] public CubeType type;
    [SerializeField] private float impulseStrength = 1f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        EventManager.CubePressed += OnCubePressed;
    }

    private void OnDisable()
    {
        EventManager.CubePressed -= OnCubePressed;
    }

    public virtual void OnCubePressed(CubeType type)
    {
        if(this.type == type || type == CubeType.All)
        {
            rb.AddForce(Vector3.up * impulseStrength * RandomFloatModifier(), ForceMode.Impulse);
        }
    }

    private float RandomFloatModifier() => Random.Range(1f, 1.5f);
}
