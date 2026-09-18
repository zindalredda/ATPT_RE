using MisoL.Attributes;
using Unity.Collections;
using UnityEngine;

namespace Alice
{
    public class BtnAnimation : MonoBehaviour
    {
        [SerializeField] private Sprite defaultSprite;
        [SerializeField] private Sprite highlightSprite;
        [ReadonlyField] [SerializeField] private BoxCollider2D boxCollider;
        [ReadonlyField] [SerializeField] private SpriteRenderer spriteRenderer;

        private void Awake()
        {
            boxCollider = GetComponent<BoxCollider2D>() ?? gameObject.AddComponent<BoxCollider2D>();
            spriteRenderer = GetComponent<SpriteRenderer>() ?? gameObject.AddComponent<SpriteRenderer>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            spriteRenderer.sprite = highlightSprite;
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            spriteRenderer.sprite = defaultSprite;
        }
    }
}
