using UnityEngine;
using System;
using Assets.Completed.Scripts;
using Completed;

namespace Assets
{
    public class PigeonMove : MonoBehaviour
    {
        public GameObject pigeon;
        public int lifetime;
        public Vector2 direction;
        public int speed;
        public bool active;

        public void Start()
        {
            pigeon = GameObject.FindGameObjectWithTag("Pigeon").GetComponent<GameObject>();
        }

        public void SpawnCar()
        {
            if (active)
            {
                GameObject pigeonClone = Pigeon.Instantiate(pigeon, this.transform.position, this.transform.rotation);
                var pigeonCloneScript = pigeonClone.GetComponent<Pigeon>();
                pigeonCloneScript.direction = direction;
                pigeonCloneScript.lifetime = lifetime;
                pigeonCloneScript.speed = speed;
                pigeonClone.tag = "car";
            }
        }
    }
}
