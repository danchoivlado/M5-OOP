using DungeonsAndCodeWizards.Entities.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Entities.Contracts
{
    interface IHealable
    {
        void Heal(Character character);
    }
}
