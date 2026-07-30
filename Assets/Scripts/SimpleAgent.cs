using UnityEngine;

public class SimpleAgent : MonoBehaviour
{
    public float speed = 5f;
    Vector3 target;

    void Start()
    {
        PickNewTarget();
    }

    void Update()
    {
        Vector3 toTarget = target - transform.position;
        float distance = toTarget.magnitude;

        if (distance < 0.5f)
        {
            PickNewTarget();
            return;
        }

        transform.position += toTarget / distance * speed * Time.deltaTime;
    }

    void PickNewTarget()
    {
        target = new Vector3(
            Random.Range(-40f, 40f),
            0.15f,
            Random.Range(-40f, 40f)
        );
    }
}