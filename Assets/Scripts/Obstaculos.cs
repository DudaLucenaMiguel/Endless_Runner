using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public float velocidadeDoObstaculo = 10f;
    public float sobrevidaDoObstaculo = -50;

    void Update()
    {
        if(transform.position.z <= sobrevidaDoObstaculo)
        {
            Destroy(gameObject);
        }
        MovimentoDoObstaculo();
    }
    void MovimentoDoObstaculo()
    {
        transform.position += Vector3.back * velocidadeDoObstaculo * Time.deltaTime;
    }
}
