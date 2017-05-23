using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using SmallTalkin.Core;
using Xamarin.Forms;

namespace SmallTalkin.Mobile
{
    public class HomePageViewModel : BaseViewModel, INotifyPropertyChanged
    {
		public HomePageViewModel()
		{
			Title = "Start Talking!";

            UpdateRecommendation();
		}

        private RecommendationService recommendationSevice = new RecommendationService();
        private void UpdateRecommendation()
        {
            Recommendation = recommendationSevice.GetRecommendation();
        }

        public string Recommendation
        {
            get;
            private set;
        }

        private List<string> subjects = new List<string>
        {
            "The Weather",
            "Anything",
            "Politics"
        };
        public List<string> Subjects => subjects;

        public string SelectedSubject
        {
            get;
            set;
        }

        int subjectSelectedIndex;
        public int SubjectsSelectedIndex
        {
            get
            {
                return subjectSelectedIndex;
            }

            set
            {
                if (subjectSelectedIndex != value)
                {
                    subjectSelectedIndex = value;

                    OnPropertyChanged(nameof(SubjectsSelectedIndex));
                    SelectedSubject = Subjects[subjectSelectedIndex];

                    this.UpdateRecommendation();
                }
            }
        }


    }
}
