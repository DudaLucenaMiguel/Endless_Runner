using UnityEngine;

public class Origem : MonoBehaviour
{
    public GameObject obstaculoPreFab;
    GameObject obstaculo;
    public int distancia;
    
    
    public float frequencia = 2;
    private float tempo = 0;

    void Update()
    {
        if(tempo>frequencia)
        {
            CriadorDeObstaculos();
            tempo = 0;
        }
        tempo += Time.deltaTime;
    }
    void CriadorDeObstaculos()
    {
        obstaculo = Instantiate(obstaculoPreFab);
        obstaculo.transform.position = transform.position + new Vector3(Random.Range(distancia, -distancia), 0, 45);
    }
}
