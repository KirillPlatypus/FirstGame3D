using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class Player : MonoBehaviour, IGetDamage
    {
        public int Health{get; set;} = 100;
        [SerializeField] Head head;
        [SerializeField] float speed;

        void Update()
        {
            transform.eulerAngles += new Vector3(0f, head.speed * Input.GetAxis("Mouse X"), 0f);

            Move(new Move(speed, GetComponent<Rigidbody>()));
        }

        public void Move(IMove move)
        {
            move.horizontal = Input.GetAxis("Horizontal");
            move.vertical = Input.GetAxis("Vertical");

            move.Movement(transform);
        }
    }
}