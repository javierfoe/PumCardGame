﻿using System.Collections;

namespace PimPamPum
{
    public class Remington : Weapon
    {
        public Remington() : base(3) { }

        protected override IEnumerator EquipTrigger(PlayerController pc)
        {
            yield return pc.Equip<Remington>(this);
        }

        public override string ToString()
        {
            return "Remington";
        }
    }
}