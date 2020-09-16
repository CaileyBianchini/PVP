using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        private string _name;
        private string _roleName;
        private int _health;
        private int _damage;
        //private string _roleName;

        public Player()
        {
            _roleName = "Peasant";
            _health = 100;
            _damage = 10;
        }
        public Player(string nameVal, string roleVal, int healthVal, int damageVal)
        {
            _name = nameVal;
            _roleName = roleVal;
            _health = healthVal;
            _damage = damageVal;
        }

        
        
        public void EquipItem(Items weapon)
        {
            _damage += weapon.statBoost;
        }

        public void EquipRole(Items role)
        {
            _damage += role.statBoost;
            _roleName = role.statName;
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

        public void Attack(Player enemy)
        {
            enemy.TakeDamage(_damage);
        }

        public void PrintStats()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Role: " + _roleName);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Damage: " + _damage);
        }

        public void TakeDamage(int damageVal)
        {
            if(GetIsAlive())
            {
                _health -= damageVal;
            }
            Console.WriteLine(_name + " took " + damageVal + " damage!!!");
        }


    }
}
