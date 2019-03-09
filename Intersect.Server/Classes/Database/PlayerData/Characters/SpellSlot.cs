﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using Intersect.Server.Entities;
using Newtonsoft.Json;

// ReSharper disable UnusedAutoPropertyAccessor.Local
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Local

namespace Intersect.Server.Database.PlayerData.Characters
{
    public class SpellSlot : Spell, ISlot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; private set; }
        public Guid CharacterId { get; private set; }
        [JsonIgnore] public virtual Player Character { get; private set; }
        public int Slot { get; private set; }

        public SpellSlot()
        {

        }

        public SpellSlot(int slot)
        {
            Slot = slot;
        }
    }
}
