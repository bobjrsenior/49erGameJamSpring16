using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class TheDot : MonoBehaviour {

    private float score = 0;

    private SpriteRenderer renderer;

    private float cooldown;

    private bool active;

    void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();

        updateColor();

        active = false;
        cooldown = Random.Range(0.2f, 1.1f);
    }

	// Update is called once per frame
	void Update () {
        cooldown -= Time.deltaTime;

        if(cooldown <= 0)
        {
            active = !active;
            cooldown = Random.Range(0.2f, 1.1f);
            if (active)
            {
                renderer.enabled = true;
            }
            else
            {
                renderer.enabled = false;
            }
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (active)
            {
                score += 0.05f;
                if(score >= 1)
                {
                    SceneManager.LoadScene("End");
                }
            }
            else
            {
                if (score > 0)
                {
                    score -= 0.05f;
                }

            }
            updateColor();
        }
	}

    private void updateColor()
    {
        Color color = Color.green * score;
        color.a = 1;
        renderer.color = color;
    }
}
