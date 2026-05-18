using UnityEngine;

public class Bola : MonoBehaviour
{
    int score01 = 0;
    int score02 = 0;

    private void Start()
    {
        transform.Translate(0f, -1f * Time.deltaTime * 5f, 0f);
    }
    void Update()
    {
        if (transform.position.y < -5f)
        {
            print("Ponto para o jogador 02");
            score02++;
            transform.position = new Vector2(0f, 0f);
        }
        else if (transform.position.y > 5f)
        {
            print("Ponto para o jogador 01");
            score01++;
            transform.position = new Vector2(0f, 0f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player01" || collision.gameObject.tag == "Player02")
        {
            transform.Translate(0f, -1f * Time.deltaTime * 5f, 0f);
        }
    }
}
