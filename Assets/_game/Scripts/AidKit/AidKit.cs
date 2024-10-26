using UnityEngine;

public class AidKit : MonoBehaviour
{
    [SerializeField] private int _healAmount = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Player _))
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.Heal(_healAmount);

                Destroy(gameObject);
            }
        }
    }
}