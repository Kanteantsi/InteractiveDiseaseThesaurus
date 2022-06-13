using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTeeeest
{
    public class Controller
    {
        private List<Disease> list;
        private Profile prof;
        private Controller self;
        private Profile_Menu prof_menu;
        private MainMenu main_menu;
        private DiseaseFlexible disease_info;
        private SearchMenu search_menu;
        private List<string> uniqueSympthoms;

        public Controller(List<Disease> list, Profile prof)
        {
            this.list = list;
            this.prof = prof;
            self = this;
        }

        public Controller(List<string> uniqueSympthoms, Profile profile)
        {
            this.uniqueSympthoms = uniqueSympthoms;
            Profile = profile;
        }

        public List<Disease> Diseases
        {
            get => list;
            set => list = value;
        }
        public Profile Profile
        {
            get => prof;
            set => prof = value;
        }
        public Controller Self
        {
            get => self;
            set => self = value;
        }
        public Profile_Menu ProfileMenu
        {
            get => prof_menu;
            set => prof_menu = value;
        }
        public MainMenu MainMenu
        {
            get => main_menu;
            set => main_menu = value;
        }
        public DiseaseFlexible DiseaseInfo
        {
            get => disease_info;
            set => disease_info = value;
        }
        public SearchMenu Search
        {
            get => search_menu;
            set => search_menu = value;
        }
    }
}
