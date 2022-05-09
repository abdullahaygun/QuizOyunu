using Quiz.Data.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Data.Entities.Abstraction
{
    public interface IEvent
    {
        public Player Player { get; set; }
        public Guid PlayerId { get; set; }
        public List<Question> Questions { get; set; }
        public _Joker Joker { get; set; }
        public enum _Joker
        {
            [Display(Description = "Seyircilerin 10 saniye içinde verecekleri cevap ile şıklar belirli yüzdelik değerler kazanır.", Name = "Seyirciye Sorma", ShortName = "Seyirciye Sorma")]
            SeyirciSorma,

            [Display(Description = "Önceden belirlenen 3 adet Jokerden biri aranarak 30 saniye içerisinde bulunulan sorunun cevaplanması istenir.", Name = "Telefon", ShortName = "Telefon")]
            Telefon,

            [Display(Description = "4 adet şıktan rastgele 2 tane yanlış cevap silinir ve risk 50% 'ye düşürülür. ", Name = "YariYariya", ShortName = "YariYariya")]
            YariYariya,

            [Display(Description = "Bir cevap hakkı daha verme imkanı sunulur.(7. sorudan sonra kazanılır.)", Name = "Seyirciye Sorma", ShortName = "Seyirciye Sorma")]
            CiftCevap,
        }

        
    }
}
