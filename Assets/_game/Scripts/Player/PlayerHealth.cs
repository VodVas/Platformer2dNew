using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;

    private int _currentHealth;

    void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(int damage)
    {
        _currentHealth = Mathf.Max(_currentHealth - damage, 0);

        if (_currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int healAmount)
    {
        _currentHealth = Mathf.Min(_currentHealth + healAmount, _maxHealth);
    }

    private void Die()
    {
        Debug.Log("Ты умер");
    }
}