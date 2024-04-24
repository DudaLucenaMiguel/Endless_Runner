using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float velocidade = 10f;
    public float disBarreiras = 7.5f;
    public TextMeshProUGUI pontosText;
    public int pontos = 0;

    void Update()
    {
        Move();
    }
    private void Move()
    {
        if (Input.GetAxis("Horizontal") > 0 && transform.position.x < disBarreiras)
        {
            transform.Translate(velocidade * Time.deltaTime, 0, 0);
        }
        else if (Input.GetAxis("Horizontal") < 0 && transform.position.x > -disBarreiras)
        {
            transform.Translate(-velocidade * Time.deltaTime, 0, 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Passagem"))
        {
            pontos++;
            pontosText.text = pontos.ToString();
        }
    }
}
