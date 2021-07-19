using UnityEngine;

namespace Enemy
{
    public class Enemy : MonoBehaviour, IGetDamage
    {
        [SerializeField] int health;
        public int Health { get; set; }

        void Awake()
        {
            Health = health;
        }

        private void Update()
        {
            Debug.Log(Health);
            if(Health <= 0)
                Destroy(gameObject);
        }
    }
}