﻿using System.Collections;

{
    public class Winchester : Weapon
    {
        public Winchester() : base(5) { }

        protected override IEnumerator EquipTrigger(PlayerController pc)
        {
            yield return pc.Equip<Winchester>(this);
        }

        public override IEnumerator CardUsed(PlayerController pc)
        {
            yield return GameController.Instance.UsedCard<Winchester>(pc);
        }

        public override string ToString()
        {
            return "Winchester";
        }
    }
}