using FinalTask.Models;
using System.Collections.Generic;

namespace FinalTask.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Aboutcard> AboutCards { get; set; }
        public AboutImg AboutImgs { get; set; }
        public List<HomeCard> HomeCards { get; set; }
        public List<HomeBrands> HomeBrands { get; set; }

    }
}
