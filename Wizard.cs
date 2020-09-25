using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Wizard : Character
    {
        private float _mana;

        //calls the default for the Wizard, and the calls the base constructer
        public Wizard() : base()
        {
            _mana = 100;
        }

        public Wizard(float healthVal, float damageVal, float manaVal, string nameVal) 
            : base(healthVal, damageVal, nameVal)
        {
            _mana = manaVal;
        }

        public override void Attack(Character enemy)
        {
            if(_mana >= 4)
            {
                float totalDamage = _damage + _mana * .25f;
                _mana -= _mana * .25f;
                //same as:
                //_mana = _mana - (_mana x .25)
                enemy.TakeDamage(totalDamage);
                return;
            }
            base.Attack(enemy);
        }
    }
}
