using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Character
    {
        private float _health;
        protected float _damage;
        private string _name;

        public Character()
        {
            _health = 100;
            _name = "Player";
            _damage = 10;
        }
        public Character(float healthVal, float damageVal, string nameVal)
        {
            _health = healthVal;
            _name = nameVal;
            _damage = damageVal;
        }
        public virtual void Attack(Character enemy)
        {
            enemy.TakeDamage(_damage);
        }
        public virtual void TakeDamage(float damageVal)
        {
            _health -= damageVal;
            if (_health < 0)
                _health = 0;
        }

        public string GetName()
        {
            return _name;
        }

        //need to find out how to put role name

        public bool GetIsAlive()
        {
            return _health > 0;
        }
        public void PrintStats()
        {
            Console.WriteLine("\nName: " + _name);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Damage: " + _damage);
        }
    }
}
