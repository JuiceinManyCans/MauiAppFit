using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MauiAppFit.Models
{
    public class Atividade
    {
        [PrimaryKeyAttribute, AutoIncrementAttribute]
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public DataTime Data {  get; set; }
        public double? Peso { get; set; }
        public string? Observacoes { get; set; }
    }
}
