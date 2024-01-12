using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp_MVVM_06._11.Models;

namespace WpfApp_MVVM_06._11.ViewModels
{
    public class SummaryViewModel : ViewModel_Base
    {
        private static readonly DependencyProperty SummaryInfoProperty;

        private static readonly DependencyProperty SummaryInfoProperty_Vacancy;
        public static readonly DependencyProperty SummaryInfoFullNameProperty;
        public static readonly DependencyProperty SummaryInfoAgeProperty;
        public static readonly DependencyProperty SummaryInfoMaritalStatusProperty;
        public static readonly DependencyProperty SummaryInfoAddressProperty;
        public static readonly DependencyProperty SummaryInfoEmailProperty;
        public static readonly DependencyProperty SummaryInfoContactsProperty;
        public static readonly DependencyProperty SummaryInfoLanguagesProperty;
        public static readonly DependencyProperty SummaryInfoLanguages_ProgrammerProperty;
        public static readonly DependencyProperty SummaryInf_Additional_SkillsProperty;
        public static readonly DependencyProperty SummaryInf_Professional_achievements_and_awards_Property;
        public static readonly DependencyProperty SummaryInfo_Work_experience_Property;
        public static readonly DependencyProperty SummaryInfo_Any_Words_Property;

        static SummaryViewModel()
        {
            SummaryInfoProperty = DependencyProperty.Register("SummaryInfo", typeof(string), typeof(MainViewModel));
            SummaryInfoProperty_Vacancy = DependencyProperty.Register("SummaryInfo_Vacancy", typeof(string), typeof(MainViewModel));
            SummaryInfoFullNameProperty = DependencyProperty.Register("SummaryInfo_FullName", typeof(string), typeof(MainViewModel));
            SummaryInfoAgeProperty = DependencyProperty.Register("SummaryInfo_Age", typeof(int), typeof(MainViewModel));
            SummaryInfoMaritalStatusProperty = DependencyProperty.Register("SummaryInfo_MaritalStatus", typeof(string), typeof(MainViewModel));
            SummaryInfoAddressProperty = DependencyProperty.Register("SummaryInfo_Address", typeof(string), typeof(MainViewModel));
            SummaryInfoEmailProperty = DependencyProperty.Register("SummaryInfo_Email", typeof(string), typeof(MainViewModel));
            SummaryInfoContactsProperty = DependencyProperty.Register("SummaryInfo_Contacts", typeof(string), typeof(MainViewModel));
            SummaryInfoLanguagesProperty = DependencyProperty.Register("SummaryInfo_Languages", typeof(string), typeof(MainViewModel));
            SummaryInfoLanguages_ProgrammerProperty = DependencyProperty.Register("SummaryInfo_Languages_Programmer", typeof(string), typeof(MainViewModel));
            SummaryInf_Additional_SkillsProperty = DependencyProperty.Register("SummaryInfo_Additional_Skills", typeof(string), typeof(MainViewModel));
            SummaryInf_Professional_achievements_and_awards_Property = DependencyProperty.Register("SummaryInfo_Professional_achievements_and_awards", typeof(string), typeof(MainViewModel));
            SummaryInfo_Work_experience_Property = DependencyProperty.Register("SummaryInfo_Work_experience", typeof(string), typeof(MainViewModel));
            SummaryInfo_Any_Words_Property = DependencyProperty.Register("SummaryInfo_Any_Words", typeof(string), typeof(MainViewModel));

        }

        public SummaryViewModel(SummaryModel model)
        {
            //SummaryInfo = Info_G(model);
            SummaryInfo_Vacancy = model.Vacancy;
            SummaryInfo_FullName = model.FullName;
            SummaryInfo_Age = model.Age;
            SummaryInfo_MaritalStatus = model.MaritalStatus;
            SummaryInfo_Address = model.Address;
            SummaryInfo_Email = model.Email;
            SummaryInfo_Contacts = model.Contacts;
            SummaryInfo_Languages = Info_languages(model);
            SummaryInfo_Languages_Programmer = Info_languages_Programmer(model);
            SummaryInfo_Additional_Skills = Info_additional_Skills(model);
            SummaryInfo_Professional_achievements_and_awards = Info_Professional_achievements_and_awards(model);
            SummaryInfo_Work_experience = Info_Work(model);
            SummaryInfo_Any_Words = model.AdditionalInformation;


        }


        private string Info_languages(SummaryModel model)
        {
            string eng = model.English ? "yes" : "no";
            string armenia = model.Armenian ? "yes" : "no";
            string spanish = model.Spanish ? "yes" : "no";
            string german = model.German ? "yes" : "no";
            string japanese = model.Armenian ? "yes" : "no";
            string arabic = model.Spanish ? "yes" : "no";
            string swedish = model.German ? "yes" : "no";

            string result = $"";

            if (model.English)
            {
                result += $"Английский:{eng}\n\n";
            }
            if (model.Armenian)
            {
                result += $"Армянский:{armenia}\n\n";
            }
            if (model.Spanish)
            {
                result += $"Испанский:{spanish}\n\n";
            }
            if (model.German)
            {
                result += $"Немецкий:{german}\n\n";
            }
            if (model.Japanese)
            {
                result += $"Японский:{japanese}\n\n";
            }
            if (model.Arabic)
            {
                result += $"Арабский:{arabic}\n\n";
            }
            if (model.Swedish)
            {
                result += $"Шведский:{swedish}\n\n";
            }

            return result;
        }

        private string Info_languages_Programmer(SummaryModel model)
        {
            string java = model.Java ? "yes" : "no";
            string javaScript = model.JavaScript ? "yes" : "no";
            string cSharp = model.CSharp ? "yes" : "no";
            string php = model.PHP ? "yes" : "no";
            string kotlin = model.Kotlin ? "yes" : "no";
            string swift = model.Swift ? "yes" : "no";
            string python = model.Python ? "yes" : "no";

            string result = $"";

            if (model.Java)
            {
                result += $"Java:{java}\n\n";
            }

            if (model.JavaScript)
            {
                result += $"JavaScript:{javaScript}\n\n";
            }

            if (model.CSharp)
            {
                result += $"C#:{cSharp}\n\n";
            }

            if (model.PHP)
            {
                result += $"PHP:{php}\n\n";
            }

            if (model.Kotlin)
            {
                result += $"Kotlin:{kotlin}\n\n";
            }

            if (model.Swift)
            {
                result += $"Swift:{swift}\n\n";
            }

            if (model.Python)
            {
                result += $"Python:{python}\n\n";
            }
            return result;
        }
        private string Info_additional_Skills(SummaryModel model)
        {
            string testing = model.Testing ? "yes" : "no";
            string cloudServices = model.CloudServices ? "yes" : "no";
            string mobileDevelopment = model.MobileDevelopment ? "yes" : "no";
            string architecturalPatterns = model.ArchitecturalPatterns ? "yes" : "no";
            string versionControlSystems = model.VersionControlSystems ? "yes" : "no";
            string databases = model.Databases ? "yes" : "no";
            string webFrameworks = model.WebFrameworks ? "yes" : "no";

            string res = $"";
            if (model.Testing)
            {
                res += $"Тестирование:{testing}\n\n";
            }

            if (model.CloudServices)
            {
                res += $"Облачные сервисы:{cloudServices}\n\n";
            }

            if (model.MobileDevelopment)
            {
                res += $"Разработка мобильных приложений:{mobileDevelopment}\n\n";
            }

            if (model.ArchitecturalPatterns)
            {
                res += $"Архитектурные шаблоны:{architecturalPatterns}\n\n";
            }

            if (model.VersionControlSystems)
            {
                res += $"Системы управления версиями:{versionControlSystems}\n\n";
            }

            if (model.Databases)
            {
                res += $"Базы данных:{databases}\n\n";
            }

            if (model.WebFrameworks)
            {
                res += $"Веб-фреймворки:{webFrameworks}\n\n";
            }

            return res;
        }
        private string Info_Professional_achievements_and_awards(SummaryModel model)
        {
            string technicalSkills = model.TechnicalSkillsDevelopment ? "yes" : "no";
            string projectManagement = model.ProjectManagement ? "yes" : "no";
            string leadership = model.Leadership ? "yes" : "no";
            string newTechnologySpecialization = model.NewTechnologySpecialization ? "yes" : "no";
            string businessAnalytics = model.BusinessAnalyticsSkillsDevelopment ? "yes" : "no";

            string result = $"";

            if (model.TechnicalSkillsDevelopment)
            {
                result += $"Развитие технических навыков:{technicalSkills}\n\n";
            }

            if (model.ProjectManagement)
            {
                result += $"Управление проектами:{projectManagement}\n\n";
            }

            if (model.Leadership)
            {
                result += $"Лидерство:{leadership}\n\n";
            }

            if (model.NewTechnologySpecialization)
            {
                result += $"Специализация на новых технологиях:{newTechnologySpecialization}\n\n";
            }

            if (model.BusinessAnalyticsSkillsDevelopment)
            {
                result += $"Развитие навыков бизнес-аналитики:{businessAnalytics}\n\n";
            }


            return result;
        }
        private string Info_Work(SummaryModel model)
        {
            string moreThan5Years = model.MoreThan5YearsExperience ? "yes" : "no";
            string threeToFiveYears = model.ThreeToFiveYearsExperience ? "yes" : "no";
            string oneToThreeYears = model.OneToThreeYearsExperience ? "yes" : "no";
            string lessThanOneYear = model.LessThanOneYearExperience ? "yes" : "no";
            string noExperience = model.NoExperience ? "yes" : "no";

            string result = $"";

            if (model.MoreThan5YearsExperience)
            {
                result += $"Более 5 лет:{moreThan5Years}\n\n";
            }
            if (model.ThreeToFiveYearsExperience)
            {
                result += $"От 3 до 5 лет:{threeToFiveYears}\n";
            }

            if (model.OneToThreeYearsExperience)
            {
                result += $"От 1 до 3 лет:{oneToThreeYears}\n";
            }

            if (model.LessThanOneYearExperience)
            {
                result += $"Менее 1 года:{lessThanOneYear}\n";
            }

            if (model.NoExperience)
            {
                result += $"Нет опыта:{noExperience}\n";
            }
            return result;
        }
        //private string Info_G(SummaryModel model)
        //{
        //    string eng = model.English ? "yes" : "no";
        //    string armenia = model.Armenian ? "yes" : "no";
        //    string spanish = model.Spanish ? "yes" : "no";
        //    string german = model.German ? "yes" : "no";

        //    // Additional languages
        //    string japanese = model.Japanese ? "yes" : "no";
        //    string arabic = model.Arabic ? "yes" : "no";
        //    string swedish = model.Swedish ? "yes" : "no";

        //    // Programming languages
        //    string java = model.Java ? "yes" : "no";
        //    string javaScript = model.JavaScript ? "yes" : "no";
        //    string cSharp = model.CSharp ? "yes" : "no";
        //    string php = model.PHP ? "yes" : "no";
        //    string kotlin = model.Kotlin ? "yes" : "no";
        //    string swift = model.Swift ? "yes" : "no";
        //    string python = model.Python ? "yes" : "no";

        //    // Professional achievements and awards
        //    string technicalSkills = model.TechnicalSkillsDevelopment ? "yes" : "no";
        //    string projectManagement = model.ProjectManagement ? "yes" : "no";
        //    string leadership = model.Leadership ? "yes" : "no";
        //    string newTechnologySpecialization = model.NewTechnologySpecialization ? "yes" : "no";
        //    string businessAnalytics = model.BusinessAnalyticsSkillsDevelopment ? "yes" : "no";

        //    // Experience
        //    string moreThan5Years = model.MoreThan5YearsExperience ? "yes" : "no";
        //    string threeToFiveYears = model.ThreeToFiveYearsExperience ? "yes" : "no";
        //    string oneToThreeYears = model.OneToThreeYearsExperience ? "yes" : "no";
        //    string lessThanOneYear = model.LessThanOneYearExperience ? "yes" : "no";
        //    string noExperience = model.NoExperience ? "yes" : "no";

        //    // Additional Information
        //    string additionalInformation = model.AdditionalInformation;

        //    // Additional Skills
        //    string testing = model.Testing ? "yes" : "no";
        //    string cloudServices = model.CloudServices ? "yes" : "no";
        //    string mobileDevelopment = model.MobileDevelopment ? "yes" : "no";
        //    string architecturalPatterns = model.ArchitecturalPatterns ? "yes" : "no";
        //    string versionControlSystems = model.VersionControlSystems ? "yes" : "no";
        //    string databases = model.Databases ? "yes" : "no";
        //    string webFrameworks = model.WebFrameworks ? "yes" : "no";



        //    return $"Vacancy: {model.Vacancy}\n" +
        // $"FullName: {model.FullName}\n" +
        // $"Age: {model.Age}\n" +
        // $"MaritalStatus: {model.MaritalStatus}\n" +
        // $"Address: {model.Address}\n" +
        // $"Email: {model.Email}\n" +
        // $"Contacts: {model.Contacts}\n" +
        // $"English: {eng}\n" +
        // $"Armenian: {armenia}\n" +
        // $"Spanish: {spanish}\n" +
        // $"German: {german}\n" +
        // $"Japanese: {japanese}\n" +
        // $"Arabic: {arabic}\n" +
        // $"Swedish: {swedish}\n" +
        // $"Java: {java}\n" +
        // $"JavaScript: {javaScript}\n" +
        // $"CSharp: {cSharp}\n" +
        // $"PHP: {php}\n" +
        // $"Kotlin: {kotlin}\n" +
        // $"Swift: {swift}\n" +
        // $"Python: {python}\n" +
        // $"Testing: {testing}\n" +
        // $"CloudServices: {cloudServices}\n" +
        // $"MobileDevelopment: {mobileDevelopment}\n" +
        // $"ArchitecturalPatterns: {architecturalPatterns}\n" +
        // $"VersionControlSystems: {versionControlSystems}\n" +
        // $"Databases: {databases}\n" +
        // $"WebFrameworks: {webFrameworks}\n" +
        // $"TechnicalSkillsDevelopment: {technicalSkills}\n" +
        // $"ProjectManagement: {projectManagement}\n" +
        // $"Leadership: {leadership}\n" +
        // $"NewTechnologySpecialization: {newTechnologySpecialization}\n" +
        // $"BusinessAnalyticsSkillsDevelopment: {businessAnalytics}\n" +
        // $"MoreThan5YearsExperience: {moreThan5Years}\n" +
        // $"ThreeToFiveYearsExperience: {threeToFiveYears}\n" +
        // $"OneToThreeYearsExperience: {oneToThreeYears}\n" +
        // $"LessThanOneYearExperience: {lessThanOneYear}\n" +
        // $"NoExperience: {noExperience}\n" +
        // $"AdditionalInformation: {additionalInformation}";

        //}
        public string SummaryInfo
        {
            get { return (string)GetValue(SummaryInfoProperty); }
            set { SetValue(SummaryInfoProperty, value); }
        }

        public string SummaryInfo_Vacancy
        {
            get { return (string)GetValue(SummaryInfoProperty_Vacancy); }
            set { SetValue(SummaryInfoProperty_Vacancy, value); }
        }

        public string SummaryInfo_FullName
        {
            get { return (string)GetValue(SummaryInfoFullNameProperty); }
            set { SetValue(SummaryInfoFullNameProperty, value); }
        }

        public int SummaryInfo_Age
        {
            get { return (int)GetValue(SummaryInfoAgeProperty); }
            set { SetValue(SummaryInfoAgeProperty, value); }
        }

        public string SummaryInfo_MaritalStatus
        {
            get { return (string)GetValue(SummaryInfoMaritalStatusProperty); }
            set { SetValue(SummaryInfoMaritalStatusProperty, value); }
        }

        public string SummaryInfo_Address
        {
            get { return (string)GetValue(SummaryInfoAddressProperty); }
            set { SetValue(SummaryInfoAddressProperty, value); }
        }

        public string SummaryInfo_Email
        {
            get { return (string)GetValue(SummaryInfoEmailProperty); }
            set { SetValue(SummaryInfoEmailProperty, value); }
        }

        public string SummaryInfo_Contacts
        {
            get { return (string)GetValue(SummaryInfoContactsProperty); }
            set { SetValue(SummaryInfoContactsProperty, value); }
        }
        public string SummaryInfo_Languages
        {
            get { return (string)GetValue(SummaryInfoLanguagesProperty); }
            set { SetValue(SummaryInfoLanguagesProperty, value); }
        }
        public string SummaryInfo_Languages_Programmer 
        {
            get { return (string)GetValue(SummaryInfoLanguages_ProgrammerProperty); }
            set { SetValue(SummaryInfoLanguages_ProgrammerProperty, value); }
        }
        public string SummaryInfo_Additional_Skills
        {
            get { return (string)GetValue(SummaryInf_Additional_SkillsProperty); }
            set { SetValue(SummaryInf_Additional_SkillsProperty, value); }
        }
        public string SummaryInfo_Professional_achievements_and_awards 
        {
            get { return (string)GetValue(SummaryInf_Professional_achievements_and_awards_Property); }
            set { SetValue(SummaryInf_Professional_achievements_and_awards_Property, value); }
        }
        public string SummaryInfo_Work_experience 
        {
            get { return (string)GetValue(SummaryInfo_Work_experience_Property); }
            set { SetValue(SummaryInfo_Work_experience_Property, value); }
        }

        public string SummaryInfo_Any_Words
        {
            get { return (string)GetValue(SummaryInfo_Any_Words_Property); }
            set { SetValue(SummaryInfo_Any_Words_Property, value); }
        }
    }
}
