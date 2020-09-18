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
        private int _baseDamage;
        private Items[] _inventory;
        private Items _currentWeapon;
        private Items _hands;

        public Player()
        {
            _inventory = new Items[3];
            _roleName = "Peasant";
            _health = 100;
            _baseDamage = 10;
            _hands.statName = "Your fugly hands";
            _hands.statBoost = 0;
        }
        public Player(string nameVal, string roleVal, int healthVal, int damageVal, int inventorySize)
        {
            _name = nameVal;
            _roleName = roleVal;
            _health = healthVal;
            _baseDamage = damageVal;
            _inventory = new Items[inventorySize];
            _hands.statName = "Your fugly hands";
            _hands.statBoost = 0;
        }

        
        public void AddItemToInventory(Items item, int index)
        {
            _inventory[index] = item;

        }

        public bool Contains(int itemIndex)
        {
            if(itemIndex > 0 && itemIndex < _inventory.Length)
            {
                return true;
            }
            return false;
        }
        
        public void EquipItem(int itemIndex)
        {
            if(Contains(itemIndex) == true);
            {
                _currentWeapon = _inventory[itemIndex];
            }
        }

        public void UnequipItem()
        {
            _currentWeapon = _hands;
        }

        public Items[] GetInventory()
        {
            return _inventory;
        }

        public void EquipRole(Items role)
        {
            _baseDamage += role.statBoost;
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
            
            int totalDamage = _baseDamage + _currentWeapon.statBoost;
            enemy.TakeDamage(totalDamage);
        }

        public void PrintStats()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Role: " + _roleName);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Damage: " + _baseDamage);
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
