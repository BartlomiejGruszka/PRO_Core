using System.Collections.Generic;
using PRO.Domain.Interfaces;
namespace PRO.UI.ViewModels
{
    public class GameFilterViewModel
    {
        public int[] Plat { get; set; }
        public int[] Stat { get; set; }
        public int[] Genr { get; set; }
        public int[] Seri { get; set; }
        public int[] Publ { get; set; }
        public int[] Deve { get; set; }
        public int[] Lang { get; set; }
        public int[] Tags { get; set; }
        public string Text { get; set; }    
    }
}
