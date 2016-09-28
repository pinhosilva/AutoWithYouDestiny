using System;
using WYD.Automatizar.Projeto.Core.Domain.Entities.KeyEntity;

namespace WYD.Automatizar.Projeto.Core.Domain.Entities
{
    public class Npc : KeyEntityId
    {
        public int MinuteGenerate { get; set; }
        public int MaxNumMob { get; set; }
        public int MinGroup { get; set; }
        public string Leader { get; set; }
        public string Follower { get; set; }
        public int RouteType { get; set; }
        public int Formation { get; set; }
        public int StartX { get; set; }
        public int StartY { get; set; }
        public int StartRange { get; set; }
        public int StartWait { get; set; }
        public int DestX { get; set; }
        public int DestY { get; set; }
        public int DestRange { get; set; }
        public int DestWait { get; set; }
    }
}