using TMPro;
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
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Space"))
        {
            pontos++;
            pontosText.text = pontos.ToString();
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
