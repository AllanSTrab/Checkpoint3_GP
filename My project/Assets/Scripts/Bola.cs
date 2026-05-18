using UnityEngine;

public class Bola : MonoBehaviour
{
    int score01 = 0;
    int score02 = 0;
    float bolamovy = 1f;
    float bolamovx = 0f;
    private void Start()
    {

    }
    void Update()
    {
        if(score01 > 4 || score02 > 4)
        {
            return;
        }
        if (transform.position.y < -5f)
        {
            print("Ponto para o jogador 02");
            print("Jogador 1: " + score01 + " pontos | Jogador 2: " + score02 + " pontos");
            score02++;
            transform.position = new Vector2(0f, 0f);
            bolamovy = Random.Range(-1, 1);
            if(bolamovy == 0f)
            {
                bolamovy = 1f;
            }
        }
        else if (transform.position.y > 5f)
        {
            print("Ponto para o jogador 01");
            print("Jogador 1: " + score01 + " pontos | Jogador 2: " + score02 + " pontos");
            score01++;
            transform.position = new Vector2(0f, 0f);
            bolamovy = Random.Range(-1, 1);
            if (bolamovy == 0f)
            {
                bolamovy = 1f;
            }
        }
        if (score01 > 4)
        {
            print("--------------------------");
            print("Jogador 01 venceu!");
            print("Pontuação Final:");
            print("Jogador 1: " + score01 + " pontos | Jogador 2: " + score02 + " pontos");
        }
        else if (score02 > 4)
        {
            print("--------------------------");
            print("Jogador 02 venceu!");
            print("Pontuação Final:");
            print("Jogador 1: " + score01 + " pontos | Jogador 2: " + score02 + " pontos");
        }
        transform.Translate(bolamovx * Time.deltaTime * 2f, bolamovy * Time.deltaTime * 7f, 0f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player01" || collision.gameObject.tag == "Player02")
        {
            bolamovy = bolamovy * -1f;
            bolamovx = Random.Range(-2f, 2f);
        }
        if(collision.gameObject.tag == "Parede")
        {
            bolamovx = bolamovx * -1f;
        }
    }
}
