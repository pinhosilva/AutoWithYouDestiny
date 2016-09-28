using System;

namespace WYD.Automatizar.Projeto.Core.Domain.Entities.KeyEntity
{
    public abstract class KeyEntityId : IKeyEntityId
    {
        public int Id { get; set; }
    }
}