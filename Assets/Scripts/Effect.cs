using UnityEngine;

public class Effect : MonoBehaviour
{
    SpriteRenderer sprite;
    Vector2 dir;
    public float moveSpeed = 0.1f;
    public float minSize = 0.1f;
    public float maxSize = 0.3f;
    public float sizeSpeed = 1;

    public Color[] colors;
    private float colorSpeed = 5f;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        dir = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
        float size = Random.Range(minSize, maxSize);
        transform.localScale = new Vector2 (size, size);  
        
        sprite.color = colors[Random.Range(0,colors.Length)];
    }

    private void Update()
    {
        transform.Translate(dir * moveSpeed);
        transform.localScale = Vector2.Lerp(transform.localScale, Vector2.zero, Time.deltaTime * sizeSpeed);

        Color color = sprite.color;
        color.a = Mathf.Lerp(sprite.color.a, 0, Time.deltaTime * colorSpeed);
        sprite.color = color;

        if(sprite.color.a <= 0.01f)
        {
            Destroy(gameObject);
        }
    }
}