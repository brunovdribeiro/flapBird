using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    private float _timer;

    public GameObject pipe;
    public float spawnRate = 2;

    private void Start()
    {
        CreatePipe();
    }

    private void Update()
    {
        if (ShouldCreatePipe())
        {
            CreatePipe();
            ResetTimer();
            return;
        }

        IncreaseTimer();
    }

    private void ResetTimer()
    {
        _timer = 0;
    }

    private void IncreaseTimer()
    {
        _timer += Time.deltaTime;
    }

    private bool ShouldCreatePipe()
    {
        return _timer > spawnRate;
    }

    private void CreatePipe()
    {
        var trans = this.transform;
        Instantiate(pipe, trans.position, trans.rotation);
    }
}