using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WYD.Automatizar.Projeto.Core.Domain.Entities;

namespace GeradorDeObjetos
{
    public class ObjetoDto
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
    public static class Program
    {
        public static Npc Npc { get; set; }
        static void Main(string[] args)
        {
            var path = System.IO.File.ReadAllText(@"C:\Users\Rafael Pinho\OneDrive\WYD\Server\TMSRV\run\NPCG.txt");
            var valuesOf = StringSplit(path);

            var Npcs = new List<Npc>();
            var dto = new ObjetoDto();
            var dtos = new List<ObjetoDto>();

            foreach (var values in valuesOf)
            {

                var result = values;
                var listados = result.Split('\t').Select(LimparValor).Skip(2);

                var rel = 0;

                foreach (var listado in listados)
                {
                    if (rel == 0 || rel / 2 != 0)
                    {
                        dto = GerarObjeto(dto, listado);
                    }
                    else
                    {
                        dto = GerarObjeto(dto, listado);
                    }
                    rel++;

                    if (dto.Key == null || dto.Value == null) continue;
                    dtos.Add(dto);
                    dto = new ObjetoDto();
                    rel = 0;
                }

                var npc = new Npc();

                foreach (var item in dtos)
                {
                    if (item.Key.Equals("MinuteGenerate"))
                        npc.MinuteGenerate = int.Parse(item.Value);
                    if (item.Key.Equals("MaxNumMob"))
                        npc.MaxNumMob = int.Parse(item.Value);
                    if (item.Key.Equals("MinGroup"))
                        npc.MinGroup = int.Parse(item.Value);
                    if (item.Key.Equals("Leader"))
                        npc.Leader = item.Value;
                    if (item.Key.Equals("Follower"))
                        npc.Follower = item.Value;
                    if (item.Key.Equals("RouteType"))
                        npc.RouteType = int.Parse(item.Value);
                    if (item.Key.Equals("Formation"))
                        npc.Formation = int.Parse(item.Value);
                    if (item.Key.Equals("StartX"))
                        npc.StartX = int.Parse(item.Value);
                    if (item.Key.Equals("StartY"))
                        npc.StartY = int.Parse(item.Value);
                    if (item.Key.Equals("StartRange"))
                        npc.StartRange = int.Parse(item.Value);
                    if (item.Key.Equals("StartWait"))
                        npc.StartWait = int.Parse(item.Value);
                    if (item.Key.Equals("DestX"))
                        npc.DestX = int.Parse(item.Value);
                    if (item.Key.Equals("DestY"))
                        npc.DestY = int.Parse(item.Value);
                    if (item.Key.Equals("DestRange"))
                        npc.DestRange = int.Parse(item.Value);
                    if (item.Key.Equals("DestWait"))
                        npc.DestWait = int.Parse(item.Value);
                }

                if (npc.Leader == null) continue;
                Npcs.Add(npc);
                dtos = new List<ObjetoDto>();
            }
        }

        public static ObjetoDto GerarObjeto(ObjetoDto dto, string obj)
        {
            if (dto.Key == null)
                dto.Key = obj;
            else
                dto.Value = obj;
            return dto;
        }
        
        public static string[] StringSplit(string fileRead)
        {
            return fileRead.Split('#');
        }

        public static string LimparValor(string value)
        {
            if (value.Length >= 21)
                value = value.Substring(0, 4);

            return value.Trim('\r', '\n', ' ', '[', ']', ':','/');
        }
    }
}
