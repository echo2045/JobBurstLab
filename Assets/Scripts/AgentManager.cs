using UnityEngine;

public class AgentManager : MonoBehaviour
{
    public int agentCount = 3000;
    public float spawnRadius = 40f;
    public float agentScale = 0.3f;

    void Start()
    {
        for (int i = 0; i < agentCount; i++)
        {
            GameObject agent = GameObject.CreatePrimitive(PrimitiveType.Cube);
            agent.name = "Agent_" + i;
            agent.transform.localScale = Vector3.one * agentScale;

            agent.transform.position = new Vector3(
                Random.Range(-spawnRadius, spawnRadius),
                0.15f,
                Random.Range(-spawnRadius, spawnRadius)
            );

            Object.Destroy(agent.GetComponent<Collider>());
            agent.AddComponent<SimpleAgent>();
        }
    }
}