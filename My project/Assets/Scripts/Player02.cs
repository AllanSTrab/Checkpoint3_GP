using UnityEngine;

public class Player02 : MonoBehaviour
{
    int score01 = 0;
    int score02 = 0;
    float speed = 10f;
    bool podeMover = true;
    void Update()
    {
        if (score01 > 4 || score02 > 4)
        {
            podeMover = false;
            return;
        }
        if (gameObject.tag == "Bola")
        {
            if (transform.position.y < -5f)
            {
                score02++;
            }
            else if (transform.position.y > 5f)
            {
                score01++;
            }
        }
        if(podeMover == true)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate((-1f * Time.deltaTime * speed), 0f, 0f);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate((1f * Time.deltaTime * speed), 0f, 0f);
            }
            if (score01 > 4 || score02 > 4)
            {
                transform.position = new Vector2(0f, 4f);
            }
        }
    }
}
