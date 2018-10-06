using DungeonsAndCodeWizards.Entities.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Entities.Contracts
{
    interface IAttackable
    {
        void Attack(Character character);

    }
}
