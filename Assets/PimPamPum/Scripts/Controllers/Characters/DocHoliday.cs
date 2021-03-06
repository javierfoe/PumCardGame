﻿using System.Collections;
using System.Collections.Generic;

namespace PimPamPum
{
    public class DocHoliday : PlayerDiscardTwoCards
    {
        protected override void EnableConfirmOptions(Card one, Card two)
        {
            DoubleCard doubleCard = new DoubleCard(one, two);
            List<int> availablePlayers = GameController.Instance.PlayersInWeaponRange(PlayerNumber, doubleCard);
            GameController.Instance.SetClickablePlayers(PlayerNumber, availablePlayers);
        }

        protected override IEnumerator OnStartTurn()
        {
            yield return base.OnStartTurn();
            skillUsed = false;
        }

        protected override IEnumerator SpecialAction(int target)
        {
            yield return ShootPimPamPum(target);
            skillUsed = true;
        }
    }
}