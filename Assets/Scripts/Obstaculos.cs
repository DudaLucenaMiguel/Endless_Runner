using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public float velocidadeDoObstaculo = 10f;
    public float pontoDeMorte = -50;

    void Update()
    {
        MovimentoDoObstaculo();
        DestruiObstaculo();
    }
    void MovimentoDoObstaculo()
    {
        transform.position += Vector3.back * velocidadeDoObstaculo * Time.deltaTime;
    }
    void DestruiObstaculo()
    {
        if (transform.position.z <= pontoDeMorte)
        {
            Destroy(gameObject);
        }
    }
}
