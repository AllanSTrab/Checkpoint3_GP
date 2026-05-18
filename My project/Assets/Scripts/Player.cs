using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 10f;
    void Start()
    {
        print("Jogador 01 use A e D para se mover");
        print("Jogador 02 use as setas para se mover");
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space)) { }
        if (gameObject.tag == "Player01")
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate((-1f * Time.deltaTime * speed), 0f, 0f);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.Translate((1f * Time.deltaTime * speed), 0f, 0f);
            }
        }
        if (gameObject.tag == "Player02")
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate((-1f * Time.deltaTime * speed), 0f, 0f);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate((1f * Time.deltaTime * speed), 0f, 0f);
            }
        }
    }
}
