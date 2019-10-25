using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHero.Models
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }
        public string superHeroName { get; set; }
        public string alterEgo { get; set; }
        public string primaryPower { get; set; }
        public string secondaryPower { get; set; }
        public string catchPhrase { get; set; }

       public static List<Hero> heroList = new List<Hero>(); 



    }
}