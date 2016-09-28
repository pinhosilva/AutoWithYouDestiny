using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WYD.Automatizar.Projeto.Core.Domain.Entities;
using WYD.Automatizar.Projeto.Core.WFA.View.Views.PrincipalView;

namespace WYD.Automatizar.Projeto.Core.WFA.View.Views.NpcView
{
    public class NpcGeneration
    {
        public IEnumerable<Npc> IniciarVerificação(string caminho)
        {
            using (var result = new StreamReader(caminho, Encoding.UTF8))
            {
                var lines = result.ReadToEnd().Split('#');
                return GerarNpcs(lines);
            }
        }

        public IEnumerable<Npc> GerarNpcs(string[] lines)
        {
            var npcs = new List<Npc>();

            foreach (var line in lines.Select(RemoverCharInvalidos).Where(line => line != ""))
            {
                var npc = new Npc();
                var attribute = new AttributeDto();

                var valuesInline = line.Split('\t')
                    .Select(RemoverCharInvalidos)
                    .Select(v => RemoverCharInvalidos(v.Split('/').FirstOrDefault()))
                    .Where(v => v != "").ToList();

                for (var i = 1; i < valuesInline.Count - 1; i++)
                {
                    attribute = CastAttribute(attribute, valuesInline.ElementAt(i));
                    if (attribute.Key == null || attribute.Value == null) continue;

                    new FrmGeneration(new Principal()).statusProgress.Value += i;
                    npc = CastNpc(npc, attribute);
                    attribute = new AttributeDto();
                }

                npcs.Add(npc);
            }

            return npcs;
        }

        private static string RemoverCharInvalidos(string value)
        {
            return value.Trim('*', '[', ']', ' ', '/', '\r', '\n', '�', 'ݷ', 'μ', ':');
        }

        private static AttributeDto CastAttribute(AttributeDto npcDto, string item)
        {
            if (npcDto.Key == null)
                npcDto.Key = item;
            else
                npcDto.Value = item;
            return npcDto;
        }

        public static Npc CastNpc(Npc npc, AttributeDto atributo)
        {
            switch (atributo.Key)
            {
                case "MinuteGenerate":
                    npc.MinuteGenerate = int.Parse(atributo.Value);
                    break;
                case "MaxNumMob":
                    npc.MaxNumMob = int.Parse(atributo.Value);
                    break;
                case "MinGroup":
                    npc.MinGroup = int.Parse(atributo.Value);
                    break;
                case "MaxGroup":
                    npc.MaxGroup = int.Parse(atributo.Value);
                    break;
                case "Leader":
                    npc.Leader = atributo.Value;
                    break;
                case "Follower":
                    npc.Follower = atributo.Value;
                    break;
                case "RouteType":
                    npc.RouteType = int.Parse(atributo.Value);
                    break;
                case "Formation":
                    npc.RouteType = int.Parse(atributo.Value);
                    break;
                case "StartX":
                    npc.StartX = int.Parse(atributo.Value);
                    break;
                case "StartY":
                    npc.StartY = int.Parse(atributo.Value);
                    break;
                case "StartRange":
                    npc.StartRange = int.Parse(atributo.Value);
                    break;
                case "StartWait":
                    npc.StartWait = int.Parse(atributo.Value);
                    break;
                case "DestX":
                    npc.DestX = int.Parse(atributo.Value);
                    break;
                case "DestY":
                    npc.DestY = int.Parse(atributo.Value);
                    break;
                case "DestRange":
                    npc.DestRange = int.Parse(atributo.Value);
                    break;
                case "DestWait":
                    npc.DestWait = int.Parse(atributo.Value);
                    break;
            }
            return npc;
        }
    }
}